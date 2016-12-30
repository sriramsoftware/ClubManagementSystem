using GYMManagementMetroUI.Classes.DataTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DBAccess
{
    /// <summary>
    /// We'll use it to insert Any thing in db
    /// </summary>
    public class DBInsert
    {
        private DataAccessLayer.DataAccessLayer DAL = new DataAccessLayer.DataAccessLayer();
        public DBResultClass Insert(Member member)
        {
            DBResultClass result  = null;
            try
            {
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;

        }
        public DBResultClass Insert(Coach coach)
        {
            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;

        }
        public DBResultClass Insert(Moderator moderator)
        {
            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;
        }
        public DBResultClass Insert(Admins admin)
        {
            DBResultClass result = null;
            try
            {

                
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;
        }
    }
}
