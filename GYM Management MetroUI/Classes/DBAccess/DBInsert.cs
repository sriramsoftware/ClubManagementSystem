using GYMManagementMetroUI.Classes.DataTypes;
using GYMManagementMetroUI.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DBAccess
{
    /// <summary>
    /// We'll use it to insert Any thing in db
    /// Leave this Class i'll finish it!
    /// </summary>
    public class DBInsert
    {
        private DataAccessLayer.DataAccessLayer DAL = new DataAccessLayer.DataAccessLayer();
        /// <summary>
        /// Imsert New Member in datebase with full details
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public DBResultClass Insert(Member member)
        {
            DBResultClass result  = null;
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = member.Name;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberUserName), System.Data.SqlDbType.NVarChar, 50));
                param[1].Value = member.UserName;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberPassword), System.Data.SqlDbType.NVarChar, 50));
                param[2].Value = member.Password;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberGender), System.Data.SqlDbType.Bit));
                param[3].Value = (byte)member.Gender;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberEmail), System.Data.SqlDbType.NVarChar,50));
                param[4].Value = member.Email;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberMobileNumber), System.Data.SqlDbType.Int));
                param[5].Value = member.PhoneNumber;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberAddress), System.Data.SqlDbType.NVarChar,250));
                param[6].Value = member.Address;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberPhoto), System.Data.SqlDbType.Text));
                using (MemoryStream ms= new MemoryStream())
                {
                    param[7].Value = "";
                    if (member.UserImage != null)
                    {
                        member.UserImage.Save(ms, member.UserImage.RawFormat);
                        param[7].Value = Convert.ToBase64String(ms.ToArray());
                    }
                    
                }
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberTall), System.Data.SqlDbType.Float));
                param[8].Value = member.Height;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberWeight), System.Data.SqlDbType.Float ));
                param[9].Value = member.Weight;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberBirthDay), System.Data.SqlDbType.Date));
                param[10].Value = member.BirthDay;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberJoinDate), System.Data.SqlDbType.Date));
                param[11].Value = member.JoinDate;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberCoachID), System.Data.SqlDbType.Int));
                param[12].Value = member.TrainerID;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberSubscribePlan), System.Data.SqlDbType.Int));
                param[13].Value = member.SubscriptionID;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberSubscriptionDateStart), System.Data.SqlDbType.Date));
                param[14].Value = member.SubscriptionStartDate;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberSubscriptionDateEnd), System.Data.SqlDbType.Date));
                param[15].Value = member.SubscriptionEndDate;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberDeactivateDate), System.Data.SqlDbType.Date));
                param[16].Value = DateTime.MaxValue;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberPaidAmount), System.Data.SqlDbType.Float));
                param[17].Value = member.PaidCurrecy;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberRestRest), System.Data.SqlDbType.Float));
                param[18].Value = member.RestCurrency;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberPendingState), System.Data.SqlDbType.Bit ));
                param[19].Value = member.PendingState;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.Comments), System.Data.SqlDbType.Bit));
                param[20].Value = member.Comments;
                /* param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblMembers.MemberDuration), System.Data.SqlDbType.Bit));
                   param[19].Value = 0;*/
                //
                DAL.ExecuteCommand(TablesClass.StoredProcedures.InsertNewMember.ToString(), param.ToArray());
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Inserted Successfully");
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
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = coach.Name;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachUserName), System.Data.SqlDbType.NVarChar, 50));
                param[1].Value = coach.UserName;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachPassword), System.Data.SqlDbType.NVarChar, 50));
                param[2].Value = coach.Password;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachGender), System.Data.SqlDbType.Bit));
                param[3].Value = (byte)coach.Gender;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachEmail), System.Data.SqlDbType.NVarChar, 50));
                param[4].Value = coach.Email;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachMobileNumber), System.Data.SqlDbType.Int));
                param[5].Value = coach.PhoneNumber;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachAddress), System.Data.SqlDbType.NVarChar, 250));
                param[6].Value = coach.Address;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachPhoto), System.Data.SqlDbType.Text));
                using (MemoryStream ms = new MemoryStream())
                {
                    param[7].Value = "";
                    if (coach.UserImage != null)
                    {
                        coach.UserImage.Save(ms, coach.UserImage.RawFormat);
                        param[7].Value = Convert.ToBase64String(ms.ToArray());
                    }

                }
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachTall), System.Data.SqlDbType.Float));
                param[8].Value = coach.Height;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachWeight), System.Data.SqlDbType.Float));
                param[9].Value = coach.Weight;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachBirthDay), System.Data.SqlDbType.Date));
                param[10].Value = coach.BirthDay;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachJoinDate), System.Data.SqlDbType.Date));
                param[11].Value = coach.JoinDate;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.DeactivateDate), System.Data.SqlDbType.Date));
                param[12].Value = DateTime.MaxValue;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachSalary), System.Data.SqlDbType.Int));
                param[13].Value = coach.Salary;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachPendingState), System.Data.SqlDbType.Date));
                param[14].Value = coach.PendingState;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.CoachPermission), System.Data.SqlDbType.Date));
                param[15].Value = coach.Permissions;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.Comments), System.Data.SqlDbType.Date));
                param[16].Value = coach.Comments;
                param.Add(new SqlParameter(TablesClass.GetParamName(TablesClass.TblCoaches.Theme), System.Data.SqlDbType.Float));
                param[17].Value = coach.Theme;
                result = new DBResultClass(DBResultClass.DBResult.Success, "Coach Inserted Successfully");
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
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Inserted Successfully");
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

                
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Inserted Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;
        }
    }
}
