using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApps_DAL_Library
{
    public class Connection
    {
        public const string connect = "Data Source=NAZIM\\SQLEXPRESS;Initial Catalog=EcommerceSite;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection GetSQLConnection()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            return conn;
        }
    }
}
