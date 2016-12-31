using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DBAccess
{
    /// <summary>
    /// Under Constructing
    /// </summary>
   public class DBResultClass
    {
        public enum Connetion
        {
            Success,
            Failed
        }

     
        public string ResultMessage { get; }
        public Connetion Result { get;}
        public DBResultClass(Connetion result, string resultMessage)
        {
            this.Result = result;
            ResultMessage = resultMessage;
        }
        

        public static string  Query(string qString)
        {
            string qResult = "";
            try
            {
                return qResult = Run(qString); // << run qString query here
            }
            catch (SqlException)
            {
                  return qResult = "~";
            }
        }




        public static string Run(string q)
        {
            string s = "";
            //              << query process here
            return s;

        }




    }
}
