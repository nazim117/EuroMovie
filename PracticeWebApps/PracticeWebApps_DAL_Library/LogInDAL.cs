using PracticeWebApps_Domain.Models;
using PracticeWebApps_LogicLibrary.Interfaces;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace PracticeWebApps_DAL_Library
{
    public class LogInDAL : Connection, ILogInRepository<UserModel>
    {
        public string GetSalt(string name)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql =
                        "SELECT Salt " +
                        "FROM [User] " +
                        "WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(sql, GetSQLConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            return dr["Salt"].ToString();
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
            return null;
        }
        public string GetHashedPassword(string name)
        {
            try
            {
                using (GetSQLConnection())
                {
                    string sql =
                        "SELECT Password " +
                        "FROM [User] " +
                        "WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(sql, GetSQLConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            return dr["Password"].ToString();
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
            return null;
        }
    }
}
