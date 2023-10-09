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
//TODO: CREATE A PRODUCT DB
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
                    string sql = $"INSERT INTO [Product](Name, Description, Rating, Duration, Picture) " +
                        $"values(@Name, @Description, @Rating, @Duration, @Picture)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@Rating", (int)product.MovieRating);
                        command.Parameters.AddWithValue("@Duration", product.Duration);
                        command.Parameters.AddWithValue("@Picture", product.Picture);

                        command.ExecuteNonQuery();
                    }
                }
                if (product is Movie)
                {
                    return CreateMovie((Movie)product);
                }
                if (product is Serie)
                {
                    return CreateSerie((Serie) product);
                }
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
            return false;
        }
//TODO: IMPLEMENT
        private bool CreateSerie(Serie serie)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"INSERT INTO [Serie](Name, Description, Rating, Duration, Picture, Seasons, Episodes) " +
                        $"values(@Name, @Description, @Rating, @Duration, @Picture, @Seasons, @Episodes)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", serie.Name);
                        command.Parameters.AddWithValue("@Description", serie.Description);
                        command.Parameters.AddWithValue("@Rating", (int)serie.MovieRating);
                        command.Parameters.AddWithValue("@Duration", serie.Duration);
                        command.Parameters.AddWithValue("@Picture", serie.Picture);
                        command.Parameters.AddWithValue("@Seasons", serie.Seasons);
                        command.Parameters.AddWithValue("@Episodes", serie.Episodes);

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

        public bool CreateMovie(Movie movie)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"INSERT INTO [Movie](Name, Description, Rating, Duration, Picture) " +
                        $"values(@Name, @Description, @Rating, @Duration, @Picture)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", movie.Name);
                        command.Parameters.AddWithValue("@Description", movie.Description);
                        command.Parameters.AddWithValue("@Rating", (int)movie.MovieRating);
                        command.Parameters.AddWithValue("@Duration", movie.Duration);
                        command.Parameters.AddWithValue("@Picture", movie.Picture);

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
