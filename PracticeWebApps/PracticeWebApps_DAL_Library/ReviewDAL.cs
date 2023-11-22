using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeWebApps_DAL_Library
{
    public class ReviewDAL : Connection, IReviewOperations<Review>
    {
        public bool CreateReview(Review review, string userName, string productName)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = 
                        $"INSERT INTO [Review](Rating, Description, ProductId, UserId) " +
                        $"values(@Rating, @Description, " +
                        $"(SELECT Id FROM [Product] WHERE Name = @ProductName), " +
                        $"(SELECT Id FROM [User] WHERE Name = @UserName));";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Rating", review.Rating);
                        command.Parameters.AddWithValue("@Description", review.Description);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@ProductName", productName);

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

        public Review GetReviewForProduct(int id)
        {
            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [Review] WHERE ProductId = @ProductId";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@ProductId", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Review(
                                    reader.GetInt32(1),
                                    reader.GetString(2));
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

        public Review[] LoadReviewsForProduct(int productId)
        {
            List<Review> reviews = new List<Review>();
            using (GetSQLConnection())
            {
                string sql = $"SELECT * FROM [Review] WHERE ProductId = @ProductId";
                using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                {
                    command.Parameters.AddWithValue("@ProductId", productId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reviews.Add(new Review(
                                reader.GetInt32(1),
                                reader.GetString(2)));
                        }
                    }
                }
            }
            return reviews.ToArray();
        }
    }
}
