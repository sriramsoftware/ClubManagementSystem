using GYMManagementMetroUI.Classes.DataTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DBAccess
{
    /// <summary>
    /// We'll use it to update Any thing in db
    /// </summary>
    public class DBUpdate
    {
        private DataAccessLayer.DataAccessLayer DAL = new DataAccessLayer.DataAccessLayer();
        public DBResultClass Update(int ID,Member member)
        {
            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.Connetion.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.Connetion.Failed, ex.Message);
            }
            return result;

        }
        public DBResultClass Update(int ID, Coach coach)
        {
            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.Connetion.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.Connetion.Failed, ex.Message);
            }
            return result;

        }
        public DBResultClass Update(int ID, Moderator moderator)
        {
            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.Connetion.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.Connetion.Failed, ex.Message);
            }
            return result;
        }
        public DBResultClass Update(int ID, Admins admin)
        {
            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.Connetion.Success, "Member Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.Connetion.Failed, ex.Message);
            }
            return result;
        }

    }
}
