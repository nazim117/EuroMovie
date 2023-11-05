using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;
using PracticeWebApps_LogicLibrary.Managers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_DAL_Library
{
    public class UserDAL : Connection, IUserOperations<UserModel>
    {
        public UserModel[] LoadObjects()
        {
            List<UserModel> users = new List<UserModel>();
            using (GetSQLConnection())
            {
                string sql = $"SELECT * FROM [User]";
                using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserModel user = GetObject(reader.GetString(1));
                            if (user != null)
                            {
                                users.Add(user);
                            }
                        }
                    }
                }
            }
            return users.ToArray();
        }
        public UserModel GetObject(string emailToFind)
        {

            using (GetSQLConnection())
            {
                try
                {
                    string sql = $"SELECT * FROM [User] WHERE name = @emailToFind";
                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@emailToFind", emailToFind);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new UserModel(
                                    reader.GetString(1), 
                                    reader.GetString(2), 
                                    reader.GetString(3),
                                    reader.GetString(5));
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

        public bool CreateObject(UserModel user, string salt)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"INSERT INTO [User](Name, Email, Phone, Password, Salt) " +
                        $"values(@Name, @Email, @Phone, @Password, @Salt)";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Phone", user.Phone);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Salt", salt);

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

        public bool EditObject(UserModel user, string previousEmail)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"UPDATE [User] " +
                        $"SET Name = @Name, Email = @Email, Phone = @Phone " +
                        $"WHERE Email = @previousEmail";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Phone", user.Phone);
                        command.Parameters.AddWithValue("@previousEmail", previousEmail);

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

        public bool DeleteObject(UserModel user)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql = $"DELETE FROM [User] WHERE Email = @email";

                    using (SqlCommand command = new SqlCommand(sql, GetSQLConnection()))
                    {
                        command.Parameters.AddWithValue("@email", user.Email);

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
