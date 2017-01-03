using ClubManagement.Classes.DataTypes;
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
        
        /// <summary>
        /// here in UpdateDynamic i want make it to work dynamically 
        /// instead of create same block for each dataType etc...
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="pathObj"></param>
        /// <returns></returns>
        public DBResultClass UpdateDynamic(int ID, object pathObj)
        {
            //Dy will be the type of path object param
            //DetectType.dName(pathObj) will be name of class
            Type Dy;
            Dy = DetectType.dType(pathObj);

            DBResultClass result = null;
            try
            {
                result = new DBResultClass(DBResultClass.DBResult.Success, DetectType.dName(pathObj) + " Updated Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;

        }



        //public DBResultClass Update(int ID,Member member)
        //{
        //    DBResultClass result = null;
        //    try
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
        //    }
        //    catch (SqlException ex)
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
        //    }
        //    return result;

        //}
        //public DBResultClass Update(int ID, Coach coach)
        //{
        //    DBResultClass result = null;
        //    try
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
        //    }
        //    catch (SqlException ex)
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
        //    }
        //    return result;

        //}
        //public DBResultClass Update(int ID, Moderator moderator)
        //{
        //    DBResultClass result = null;
        //    try
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
        //    }
        //    catch (SqlException ex)
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
        //    }
        //    return result;
        //}
        //public DBResultClass Update(int ID, Admins admin)
        //{
        //    DBResultClass result = null;
        //    try
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Success, "Member Updated Successfully");
        //    }
        //    catch (SqlException ex)
        //    {
        //        result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
        //    }
        //    return result;
        //}

    }
}
