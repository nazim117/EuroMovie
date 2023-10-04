using PracticeWebApps_Domain.Models;
using PracticeWebApps_Domain.Models.Products;
using PracticeWebApps_LogicLibrary.Interfaces;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_DAL_Library
{
    public class ProductDAL : Connection, IOperations<Product>
    {
        public Product[] LoadObjects()
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
                            Product product = GetObject(reader.GetString(1));
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
        public Product GetObject(string name)
        {
            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [Product] WHERE Name = @name";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Movie(reader.GetString(1),
                                    reader.GetString(2),
                                    (Rating)reader.GetInt32(3),
                                    reader.GetInt32(4),
                                    reader.GetString(5)); ;
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
        public bool CreateObject(Product product)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"INSERT INTO [User](Name, Email, Phone, IsAdmin, Password, Salt) " +
                        $"values(@Name, @Email, @Phone, @IsAdmin, @Password, @Salt)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@MovieRating", product.MovieRating);
                        command.Parameters.AddWithValue("@Duration", product.Duration);
                        command.Parameters.AddWithValue("@Picture", product.Picture);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values :" + ex.ToString());

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
    }
}
