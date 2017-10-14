using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TD_N2
{
    class Connexion
    {
        private static SqlConnection connection = connection = new SqlConnection(Properties.Settings.Default.chcon);
        public static SqlConnection getCon()
        {
            try
            {
                connection.Open();
            }
            catch (SqlException e) { throw e; }
            return connection;
        }
        public static void closeCon() 
        {
            if (connection != null)
            {
                try
                {
                    connection.Close();
                }
                catch (SqlException ex) 
                {
                    throw ex;
                }

             }
        }
    }
}
