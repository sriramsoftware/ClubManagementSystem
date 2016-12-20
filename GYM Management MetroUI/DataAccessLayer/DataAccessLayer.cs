using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GYMManagementMetroUI.DataAccessLayer
{
    /// <summary>
    /// Class which uses to access database
    /// </summary>
    class DataAccessLayer
    {
        #region Variables
        SqlConnection connection;
        private string dataBaseName = "GYM";
        private string server = "Ibrahim";
        #endregion
        #region Properties

        /// <summary>
        /// Get or set Database name
        /// </summary>
        public string Databasename
        {
            get { return dataBaseName; }
            set { dataBaseName = value; }
        }

        /// <summary>
        /// Get or set Server name
        /// </summary>
        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        #endregion
        #region Methods
        public DataAccessLayer():this("Ibrahim", "GYM")
        {}
        public DataAccessLayer(string Server, string DatabaseName)
        {
            this.Server = Server;
            this.Databasename = dataBaseName;
            connection = new SqlConnection(string.Format(@"Data Source=.\{0};Initial Catalog={1};Integrated Security=True", Server, Databasename));
        }

        /// <summary>
        /// Open Connection to Database
        /// </summary>
        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Close Connection to Database
        /// </summary>
        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method to Select Data form database
        /// </summary>
        /// <param name="StoredProcedure">Stored Procedule Name To Get Data form it</param>
        /// <param name="parms">Stored Procedule Parameters</param>
        /// <returns>Data which has been getten from database</returns>
        public DataTable SelectData(string StoredProcedure, SqlParameter[] parms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedure;
            cmd.Connection = connection;
            if (parms != null)
                cmd.Parameters.AddRange(parms);
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Method to Insert, Update, Delete Data From Database
        /// </summary>
        /// <param name="StoredProcedure">Stored Procedule Name To Execute Command on it</param>
        /// <param name="parms">Stored Procedule Parameters</param>
        public void ExecuteCommand(string StoredProcedure, SqlParameter[] parms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.CommandText = StoredProcedure;
            if (parms != null)
                cmd.Parameters.AddRange(parms);
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }


        #endregion
    }

}
