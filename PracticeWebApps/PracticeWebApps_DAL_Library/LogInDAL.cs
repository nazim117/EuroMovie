using PracticeWebApps_Domain.Models.Users;
using PracticeWebApps_LogicLibrary.Interfaces;
using System.Data.SqlClient;

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
            catch (Exception ex)
            {
                throw new Exception("Something went wrong in the database:" + ex.ToString());
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
            catch (Exception ex)
            {
                throw new Exception("Something went wrong in the database:" + ex.ToString());
            }
            return null;
        }
    }
}
