using System.Data;
using System;
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
        /// Gets or sets Database name
        /// </summary>
        public string Databasename
        {
            get { return _dataBaseName; }
            set { _dataBaseName = value; }
        }

        /// <summary>
        /// Gets or sets Server name
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
            try
            {
                this.Server = server;
                this.Databasename = _dataBaseName;
                connection = new SqlConnection(string.Format(@"Data Source=.\{0};Initial Catalog={1};Integrated Security=True", server, databaseName));
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message,"Club Management",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open Connection to Database
        /// </summary>
        public void Open()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Club Management", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Close Connection to Database
        /// </summary>
        public void Close()
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Club Management", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
            try
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
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Club Management", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Method to Insert, Update, Delete Data From Database
        /// </summary>
        /// <param name="storedProcedure">Stored Procedure Name To Execute Command on it</param>
        /// <param name="parms">Stored Procedure Parameters</param>
        public void ExecuteCommand(string storedProcedure, SqlParameter[] parms)
        {
            try
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
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Club Management", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Close();
            }
        }
        #endregion
    }

}
