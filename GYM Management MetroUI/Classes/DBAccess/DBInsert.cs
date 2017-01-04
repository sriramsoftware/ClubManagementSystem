using ClubManagement.Classes.DataTypes;
using ClubManagement.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using static ClubManagement.Classes.Enums.TablesClass;

namespace ClubManagement.Classes.DBAccess
{
    /// <summary>
    /// We'll use it to insert Any thing in db
    /// Leave this Class i'll finish it!
    /// </summary>
    public class DBInsert
    {
        private static DataAccessLayer.DataAccessLayer DAL = new DataAccessLayer.DataAccessLayer();
        /// <summary>
        /// Insert New Member in datebase with full details
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static DBResultClass Insert(Member member)
        {
            DBResultClass result  = null;
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = member.Name;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberUserName), System.Data.SqlDbType.NVarChar, 50));
                param[1].Value = member.UserName;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberPassword), System.Data.SqlDbType.NVarChar, 50));
                param[2].Value = member.Password;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberGender), System.Data.SqlDbType.Bit));
                param[3].Value = (byte)member.Gender;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberEmail), System.Data.SqlDbType.NVarChar,50));
                param[4].Value = member.Email;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberMobileNumber), System.Data.SqlDbType.Int));
                param[5].Value = member.PhoneNumber;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberAddress), System.Data.SqlDbType.NVarChar,250));
                param[6].Value = member.Address;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberPhoto), System.Data.SqlDbType.Text));
                using (MemoryStream ms= new MemoryStream())
                {
                    param[7].Value = "";
                    if (member.UserImage != null)
                    {
                        member.UserImage.Save(ms, member.UserImage.RawFormat);
                        param[7].Value = Convert.ToBase64String(ms.ToArray());
                    }
                    
                }
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberTall), System.Data.SqlDbType.Float));
                param[8].Value = member.Height;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberWeight), System.Data.SqlDbType.Float ));
                param[9].Value = member.Weight;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberBirthDay), System.Data.SqlDbType.Date));
                param[10].Value = member.BirthDay;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberJoinDate), System.Data.SqlDbType.Date));
                param[11].Value = member.JoinDate;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberCoachID), System.Data.SqlDbType.Int));
                param[12].Value = member.TrainerID;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberSubscribePlan), System.Data.SqlDbType.Int));
                param[13].Value = member.SubscriptionID;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberSubscriptionDateStart), System.Data.SqlDbType.Date));
                param[14].Value = member.SubscriptionStartDate;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberSubscriptionDateEnd), System.Data.SqlDbType.Date));
                param[15].Value = member.SubscriptionEndDate;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberDeactivateDate), System.Data.SqlDbType.Date));
                param[16].Value = DateTime.MaxValue;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberPaidAmount), System.Data.SqlDbType.Float));
                param[17].Value = member.PaidCurrecy;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberRestRest), System.Data.SqlDbType.Float));
                param[18].Value = member.RestCurrency;
                param.Add(new SqlParameter(GetParamName(TblMembers.MemberPendingState), System.Data.SqlDbType.Bit ));
                param[19].Value = member.PendingState;
                param.Add(new SqlParameter(GetParamName(TblMembers.Comments), System.Data.SqlDbType.Bit));
                param[20].Value = member.Comments;
                /* param.Add(new SqlParameter(GetParamName(TblMembers.MemberDuration), System.Data.SqlDbType.Bit));
                   param[19].Value = 0;*/
                //
                DAL.ExecuteCommand(StoredProcedures.InsertNewMember.ToString(), param.ToArray());
                result = new DBResultClass(DBResultClass.DBResult.Success, "Member Inserted Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;

        }
        public static DBResultClass Insert(Coach coach)
        {
            DBResultClass result = null;
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = coach.Name;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachUserName), System.Data.SqlDbType.NVarChar, 50));
                param[1].Value = coach.UserName;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachPassword), System.Data.SqlDbType.NVarChar, 50));
                param[2].Value = coach.Password;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachGender), System.Data.SqlDbType.Bit));
                param[3].Value = (byte)coach.Gender;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachEmail), System.Data.SqlDbType.NVarChar, 50));
                param[4].Value = coach.Email;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachMobileNumber), System.Data.SqlDbType.Int));
                param[5].Value = coach.PhoneNumber;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachAddress), System.Data.SqlDbType.NVarChar, 250));
                param[6].Value = coach.Address;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachPhoto), System.Data.SqlDbType.Text));
                using (MemoryStream ms = new MemoryStream())
                {
                    param[7].Value = "";
                    if (coach.UserImage != null)
                    {
                        coach.UserImage.Save(ms, coach.UserImage.RawFormat);
                        param[7].Value = Convert.ToBase64String(ms.ToArray());
                    }

                }
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachTall), System.Data.SqlDbType.Float));
                param[8].Value = coach.Height;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachWeight), System.Data.SqlDbType.Float));
                param[9].Value = coach.Weight;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachBirthDay), System.Data.SqlDbType.Date));
                param[10].Value = coach.BirthDay;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachJoinDate), System.Data.SqlDbType.Date));
                param[11].Value = coach.JoinDate;
                param.Add(new SqlParameter(GetParamName(TblCoaches.DeactivateDate), System.Data.SqlDbType.Date));
                param[12].Value = DateTime.MaxValue;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachSalary), System.Data.SqlDbType.Float));
                param[13].Value = coach.Salary;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachPendingState), System.Data.SqlDbType.Int));
                param[14].Value = coach.PendingState;
                param.Add(new SqlParameter(GetParamName(TblCoaches.CoachPermission), System.Data.SqlDbType.Text));
                param[15].Value = coach.Permissions.ToString();
                param.Add(new SqlParameter(GetParamName(TblCoaches.Comments), System.Data.SqlDbType.Text));
                param[16].Value = coach.Comments;
                param.Add(new SqlParameter(GetParamName(TblCoaches.Theme), System.Data.SqlDbType.NVarChar,50));
                param[17].Value = coach.Theme;
                DAL.ExecuteCommand(StoredProcedures.InsertNewCoach.ToString(), param.ToArray());
                result = new DBResultClass(DBResultClass.DBResult.Success, "Coach Inserted Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;

        }
        public static DBResultClass Insert(Moderator moderator)
        {
            DBResultClass result = null;
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = moderator.Name;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorUserName), System.Data.SqlDbType.NVarChar, 50));
                param[1].Value = moderator.UserName;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorPassword), System.Data.SqlDbType.NVarChar, 50));
                param[2].Value = moderator.Password;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorGender), System.Data.SqlDbType.Bit));
                param[3].Value = (byte)moderator.Gender;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorEmail), System.Data.SqlDbType.NVarChar, 50));
                param[4].Value = moderator.Email;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorMobileNumber), System.Data.SqlDbType.Int));
                param[5].Value = moderator.PhoneNumber;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorAddress), System.Data.SqlDbType.NVarChar, 250));
                param[6].Value = moderator.Address;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorPhoto), System.Data.SqlDbType.Text));
                using (MemoryStream ms = new MemoryStream())
                {
                    param[7].Value = "";
                    if (moderator.UserImage != null)
                    {
                        moderator.UserImage.Save(ms, moderator.UserImage.RawFormat);
                        param[7].Value = Convert.ToBase64String(ms.ToArray());
                    }

                }
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorTall), System.Data.SqlDbType.Float));
                param[8].Value = moderator.Height;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorWeight), System.Data.SqlDbType.Float));
                param[9].Value = moderator.Weight;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorBirthDay), System.Data.SqlDbType.Date));
                param[10].Value = moderator.BirthDay;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorJoinDate), System.Data.SqlDbType.Date));
                param[11].Value = moderator.JoinDate;
                param.Add(new SqlParameter(GetParamName(TblModerators.DeactivateDate), System.Data.SqlDbType.Date));
                param[12].Value = DateTime.MaxValue;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorSalary), System.Data.SqlDbType.Int));
                param[13].Value = moderator.Salary;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorPendingState), System.Data.SqlDbType.Date));
                param[14].Value = moderator.PendingState;
                param.Add(new SqlParameter(GetParamName(TblModerators.ModeratorPermission), System.Data.SqlDbType.Date));
                param[15].Value = moderator.Permissions;
                param.Add(new SqlParameter(GetParamName(TblModerators.Comments), System.Data.SqlDbType.Date));
                param[16].Value = moderator.Comments;
                param.Add(new SqlParameter(GetParamName(TblModerators.Theme), System.Data.SqlDbType.Float));
                param[17].Value = moderator.Theme;
                DAL.ExecuteCommand(StoredProcedures.InsertNewModerator.ToString(), param.ToArray());
                result = new DBResultClass(DBResultClass.DBResult.Success, "Moderator Inserted Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;
        }
        public static DBResultClass Insert(Admins admin)
        {
            DBResultClass result = null;
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = admin.Name;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminUserName), System.Data.SqlDbType.NVarChar, 50));
                param[1].Value = admin.UserName;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminPassword), System.Data.SqlDbType.NVarChar, 50));
                param[2].Value = admin.Password;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminGender), System.Data.SqlDbType.Bit));
                param[3].Value = (byte)admin.Gender;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminEmail), System.Data.SqlDbType.NVarChar, 50));
                param[4].Value = admin.Email;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminMobileNumber), System.Data.SqlDbType.Int));
                param[5].Value = admin.PhoneNumber;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminAddress), System.Data.SqlDbType.NVarChar, 250));
                param[6].Value = admin.Address;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminPhoto), System.Data.SqlDbType.Text));
                using (MemoryStream ms = new MemoryStream())
                {
                    param[7].Value = "";
                    if (admin.UserImage != null)
                    {
                        admin.UserImage.Save(ms, admin.UserImage.RawFormat);
                        param[7].Value = Convert.ToBase64String(ms.ToArray());
                    }
                }
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminTall), System.Data.SqlDbType.Float));
                param[8].Value = admin.Height;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminWeight), System.Data.SqlDbType.Float));
                param[9].Value = admin.Weight;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminBirthDay), System.Data.SqlDbType.Date));
                param[10].Value = admin.BirthDay;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminJoinDate), System.Data.SqlDbType.Date));
                param[11].Value = admin.JoinDate;
                param.Add(new SqlParameter(GetParamName(TblAdmins.DeactivateDate), System.Data.SqlDbType.Date));
                param[12].Value = DateTime.MaxValue;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminSalary), System.Data.SqlDbType.Int));
                param[13].Value = admin.Salary;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminPendingState), System.Data.SqlDbType.Date));
                param[14].Value = admin.PendingState;
                param.Add(new SqlParameter(GetParamName(TblAdmins.AdminPermission), System.Data.SqlDbType.Date));
                param[15].Value = admin.Permissions;
                param.Add(new SqlParameter(GetParamName(TblAdmins.Comments), System.Data.SqlDbType.Date));
                param[16].Value = admin.Comments;
                param.Add(new SqlParameter(GetParamName(TblAdmins.Theme), System.Data.SqlDbType.Float));
                param[17].Value = admin.Theme;
                DAL.ExecuteCommand(StoredProcedures.InsertNewAdmin.ToString(), param.ToArray());
                result = new DBResultClass(DBResultClass.DBResult.Success, "Admin Inserted Successfully");
            }
            catch (SqlException ex)
            {
                result = new DBResultClass(DBResultClass.DBResult.Failed, ex.Message);
            }
            return result;
        }
        public static DBResultClass Insert(Equipment equip)
        {
            DBResultClass result;
            try
            {
                List<SqlParameter> param = new List<SqlParameter>();
                param.Add(new SqlParameter(GetParamName(TblEquipments.EquipmentName), System.Data.SqlDbType.NVarChar, 100));
                param[0].Value = equip.Name;
                param.Add(new SqlParameter(GetParamName(TblEquipments.EquipmentQuantity), System.Data.SqlDbType.Int));
                param[1].Value = equip.Quantity;

                result = new DBResultClass(DBResultClass.DBResult.Success, "Equipment Inserted Successfully");
            }
            catch (SqlException ex)
            {
                result=new  DBResultClass(DBResultClass.DBResult.Success, ex.Message);
            }
            return result;
        }

    }
}
