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
        private const string connect = "Server=mssqlstud.fhict.local;Database=dbi499773;User Id=dbi499773;Password=Fml01HwD33;";

        public SqlConnection GetSQLConnection()
        {
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            return conn;
        }
    }
}
