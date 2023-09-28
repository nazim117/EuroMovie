using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_DAL_Library
{
    public class ProductDAL : Connection, IProductRepository<Product>
    {
        public Product[] LoadProduct()
        {
            List<Product> products = new List<Product>();
            using (GetSQLConnection())
            {
                string sql = $"SELECT * FROM [Product]";
                using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = GetProductById(reader.GetInt32(0));
                            if (product != null)
                            {
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            return products.ToArray();
        }
        public Product GetProductById(int id)
        {
            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [Product] WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Product product = new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), (byte[])reader[3]);
                                return product;
                            }
                        }
                    }
                }
                catch (SqlNullValueException ex)
                {
                    throw new SqlNullValueException("Error, reading null values. :" + ex.ToString());

                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. :" + ex.ToString());
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occured in the SQL Server database. : " + ex.ToString());
                }
                catch (TimeoutException ex)
                {
                    throw new TimeoutException("Database operation takes too long to complete, and the timeout period is exceeded.  " + ex.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return null;
        }
    }
}
