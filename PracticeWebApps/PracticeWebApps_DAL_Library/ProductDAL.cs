﻿using PracticeWebApps_Domain.Models;
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
                try
                {
                    string sql = $"SELECT * FROM [Product]";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product;
                                if (reader.GetString(7) == "Movie")
                                {

                                    product = new Movie(reader.GetString(1),
                                        reader.GetString(2),
                                        (Rating)reader.GetInt32(3),
                                        (Genre)reader.GetInt32(4),
                                        reader.GetInt32(5),
                                        reader.GetString(6));
                                }
                                else
                                {
                                    int[] seasonsAndEpisodes = GetSeasonsAndEpisodes(reader.GetInt32(0));

                                    product = new Serie(reader.GetString(1),
                                        reader.GetString(2),
                                        (Rating)reader.GetInt32(3),
                                        (Genre)reader.GetInt32(4),
                                        reader.GetInt32(5),
                                        reader.GetString(6),
                                        seasonsAndEpisodes[0],
                                        seasonsAndEpisodes[1]);
                                }
                                if (product != null)
                                {
                                    products.Add(product);
                                }
                            }
                        }
                    }
                    return products.ToArray();
                }
                catch (SqlNullValueException ex)
                {
                    throw new SqlNullValueException("Error, reading null values. " + ex.ToString());
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
                }
                catch (TimeoutException ex)
                {
                    throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
        }
        
        public Product GetObject(string name)
        {
            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [Product] WHERE Name = @Name";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader.GetString(7) == "Movie")
                                {

                                    return new Movie(reader.GetString(1),
                                        reader.GetString(2),
                                        (Rating)reader.GetInt32(3),
                                        (Genre)reader.GetInt32(4),
                                        reader.GetInt32(5),
                                        reader.GetString(6));
                                }
                                else
                                {
                                    int[] seasonsAndEpisodes = GetSeasonsAndEpisodes(reader.GetInt32(0));

                                    return new Serie(reader.GetString(1),
                                        reader.GetString(2),
                                        (Rating)reader.GetInt32(3),
                                        (Genre)reader.GetInt32(4),
                                        reader.GetInt32(5),
                                        reader.GetString(6),
                                        seasonsAndEpisodes[0],
                                        seasonsAndEpisodes[1]);
                                }

                            }
                        }
                    }
                }
                catch (SqlNullValueException ex)
                {
                    throw new SqlNullValueException("Error, reading null values. " + ex.ToString());

                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
                }
                catch (TimeoutException ex)
                {
                    throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return null;
        }
        private int[] GetSeasonsAndEpisodes(int productId)
        {
            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [Serie] WHERE ProductId = @ProductId";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                return new int[]
                                {
                                    reader.GetInt32(2),
                                    reader.GetInt32(3)
                                };

                            }
                        }
                    }
                }
                catch (SqlNullValueException ex)
                {
                    throw new SqlNullValueException("Error, reading null values. " + ex.ToString());

                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
                }
                catch (TimeoutException ex)
                {
                    throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
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
                    string sql = $"INSERT INTO [Product](Name, Description, Rating, Genre, Duration, Picture, ProductType) " +
                        $"values(@Name, @Description, @Rating, @Genre, @Duration, @Picture, @ProductType)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@Rating", (int)product.MovieRating);
                        command.Parameters.AddWithValue("@Genre", (int)product.Genre);
                        command.Parameters.AddWithValue("@Duration", product.Duration);
                        command.Parameters.AddWithValue("@Picture", product.Picture);

                        if (product is Movie)
                        {
                            command.Parameters.AddWithValue("@ProductType", "Movie");
                        }
                        if (product is Serie)
                        {
                            command.Parameters.AddWithValue("@ProductType", "Serie");
                        }

                        command.ExecuteNonQuery();
                    }
                }
                if (product is Movie)
                {
                    return CreateMovie();
                }
                if (product is Serie)
                {
                    return CreateSerie((Serie) product);
                }
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values. " + ex.ToString());
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return false;
        }
        private bool CreateSerie(Serie serie)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"INSERT INTO [Serie](ProductId, Seasons, Episodes) " +
                        $"values((SELECT MAX(Id) From [Product]), @Seasons, @Episodes)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Seasons", serie.Seasons);
                        command.Parameters.AddWithValue("@Episodes", serie.Episodes);

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values. " + ex.ToString());

            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        private bool CreateMovie()
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"INSERT INTO [Movie](ProductId) " +
                        $"VALUES((SELECT MAX(Id) FROM [Product]))";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values. " + ex.ToString());
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        public bool IsObjectPresent(Product product)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = "SELECT COUNT(*) FROM [Product] WHERE Name = @name";

                    using (SqlCommand cmd = new SqlCommand(sql, GetSQLConnection()))
                    {
                        cmd.Parameters.AddWithValue("@name", product.Name);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

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
        }
        public int GetObjectId(string stringForSearch)
        {
            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [Product] WHERE Name = @Name";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", stringForSearch);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader.GetInt32(0);
                            }
                        }
                    }
                }
                catch (SqlNullValueException ex)
                {
                    throw new SqlNullValueException("Error, reading null values. " + ex.ToString());

                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
                }
                catch (SqlException ex)
                {
                    throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
                }
                catch (TimeoutException ex)
                {
                    throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
            }
            return 0;
        }
        public bool EditObject(Product product, string previousName)
        {
            try
            {
                if (product is Serie)
                {
                    EditSerie((Serie)product);
                }
                using (GetSQLConnection())
                {
                    string sql = $"UPDATE [Product] " +
                        $"SET Name = @Name, Description = @Description, Rating = @Rating, Genre = @Genre, Duration = @Duration, Picture = @Picture " +
                        $"WHERE Name = @previousName";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Description", product.Description);
                        command.Parameters.AddWithValue("@Rating", product.MovieRating);
                        command.Parameters.AddWithValue("@Genre", product.Genre);
                        command.Parameters.AddWithValue("@Duration", product.Duration);
                        command.Parameters.AddWithValue("@Picture", product.Picture);
                        command.Parameters.AddWithValue("@previousName", previousName);

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
        private void EditSerie(Serie serie)
        {
            try
            {
                int productId = GetObjectId(serie.Name);

                if (productId > 0)
                {

                    using (GetSQLConnection())
                    {
                        string sql = $"UPDATE [Serie] " +
                            $"SET Seasons = @Seasons, Episodes = @Episodes " +
                            $"WHERE ProductId = @ProductId";

                        using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                        {
                            command.Parameters.AddWithValue("@Seasons", serie.Seasons);
                            command.Parameters.AddWithValue("@Episodes", serie.Episodes);
                            command.Parameters.AddWithValue("@ProductId", productId);

                            command.ExecuteNonQuery();
                        }
                    }
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

        }
        public bool DeleteObject(Product product)
        {
            try
            {
                using (GetSQLConnection())
                {

                    if (product is Movie)
                    {
                        DeleteMovie((Movie)product);
                    }
                    if (product is Serie)
                    {
                        DeleteSerie((Serie)product);
                    }

                    string sql = $"DELETE FROM [Product] WHERE Name = @Name";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);

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
        private void DeleteSerie(Serie product)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"DELETE FROM [Serie] WHERE ProductId = (SELECT Id FROM [Product] WHERE Name = @ProductName)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@ProductName", product.Name);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values. " + ex.ToString());

            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        private void DeleteMovie(Movie product)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"DELETE FROM [Movie] WHERE ProductId = (SELECT Id FROM [Product] WHERE Name = @ProductName)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@ProductName", product.Name);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlNullValueException ex)
            {
                throw new SqlNullValueException("Error, reading null values. " + ex.ToString());

            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("An operation is attempted that is not valid for the current state of the database connection. " + ex.ToString());
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occured in the SQL Server database. " + ex.ToString());
            }
            catch (TimeoutException ex)
            {
                throw new TimeoutException("Database operation takes too long to complete. " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
