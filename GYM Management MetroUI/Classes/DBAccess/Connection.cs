using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DBAccess
{
    /// <summary>
    /// this class to check DB connections and stuff
    /// </summary>
    class Connection
    {

        private static bool state = false;
        private static string conString = "";

      
        public static bool isConnected()
        {
            try
            {
                using (var connection = new SqlConnection(conString))
                {
                    connection.Open();
                    return state = true;
                }
            }
            catch (SqlException)
            {
                return  false;
            }
        }




    }
}
