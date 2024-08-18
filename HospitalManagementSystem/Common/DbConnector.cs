using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Common
{
    public class DbConnector
    {
        public static string ConnectionString = "";

        private static SqlConnection con = null;

        public DbConnector(string cs)
        {
            con = new SqlConnection(cs);
        }

        public static SqlConnection Connect()
        {
            try
            {
                if (con != null)
                {
                    con.Close();
                    con = null;
                }
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }

            catch (Exception)
            {
            }
            return null;
        }

    }
}
