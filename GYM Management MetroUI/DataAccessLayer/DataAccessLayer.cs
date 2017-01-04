using System.Data;
using System.Data.SqlClient;

namespace ClubManagement.DataAccessLayer
{
    /// <summary>
    /// Class which uses to access database
    /// </summary>
    class DataAccessLayer
    {
        #region Variables
        SqlConnection connection;
        private string _dataBaseName = "GYM";
        private string _server = "Ibrahim";
        #endregion
        #region Properties

        /// <summary>
        /// Get or set Database name
        /// </summary>
        public string Databasename
        {
            get { return _dataBaseName; }
            set { _dataBaseName = value; }
        }

        /// <summary>
        /// Get or set Server name
        /// </summary>
        public string Server
        {
            get { return _server; }
            set { _server = value; }
        }
        #endregion
        #region Methods
        public DataAccessLayer():this("Ibrahim", "Club")
        {}
        public DataAccessLayer(string server, string databaseName)
        {
            this.Server = server;
            this.Databasename = _dataBaseName;
            connection = new SqlConnection(string.Format(@"Data Source=.\{0};Initial Catalog={1};Integrated Security=True", server, databaseName));
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
        /// <param name="storedProcedure">Stored Procedure Name To Get Data form it</param>
        /// <param name="parms">Stored Procedure Parameters</param>
        /// <returns>Data which has been getten from database</returns>
        public DataTable SelectData(string storedProcedure, SqlParameter[] parms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProcedure;
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
        /// <param name="storedProcedure">Stored Procedure Name To Execute Command on it</param>
        /// <param name="parms">Stored Procedure Parameters</param>
        public void ExecuteCommand(string storedProcedure, SqlParameter[] parms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.CommandText = storedProcedure;
            if (parms != null)
                cmd.Parameters.AddRange(parms);
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }


        #endregion
    }

}
