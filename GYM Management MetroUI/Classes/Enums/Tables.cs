using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.Enums
{
    public class TablesClass
    {
        public enum Tables 
        {
            tblAdmins,
            tblMembers,
            tblAttendance,
            tblCoaches,
            tblEquipments,
            tblModerators,
            tblPricesPlans,
            tblPermissions,
            tblSettings,
            tnlTmpModify,
            tblAds
        }
        public enum TblAdmins
        {
            AdminID,
            AdminName,
            AdminUserName,
            AdminPassword,
            AdminGender,
            AdminEmail,
            AdminMobileNumber,
            AdminAddress,
            AdminPhoto,
            AdminBirthDay,
            AdminJoinDate,
            DeactivateDate,
            AdminSalary,
            AdminPendingState,
            AdminPermission,
            AdminIsSuper,
            Comments,
            Theme
        }
        public enum TblMembers
        {
            MemberID,
            MemberName,
            MemberUserName,
            MemberPassword,
            MemberGender,
            MemberEmail,
            MemberMobileNumber,
            MemberAddress,
            MemberPhoto,
            MemberBirthDay,
            MemberJoinDate,
            MemberCoachID,
            MemberSubscribePlan,
            MemberSubscriptionDateStart,
            MemberSubscriptionDateEnd,
            MemberDeactivateDate,
            MemberPaidAmount,
            MemberRestRest,
            MemberDuration,
            MemberPendingState,
            Comments
                
        }
        public enum TblAttendance
        {
            PersonID,
            PersonName,
            PersonType,
            PersonState,
            PersonAttendTime,
            PersonLeaveTime,
            DayDate,
        }
        public enum TblCoaches
        {
            CoachID,
            CoachName,
            CoachUserName,
            CoachPassword,
            CoachGender,
            CoachEmail,
            CoachMobileNumber,
            CoachAddress,
            CoachPhoto,
            CoachBirthDay,
            CoachJoinDate,
            DeactivateDate,
            CoachSalary,
            CoachPendingState,
            CoachPermission,
            Comments,
            Theme
        }
        public enum TblEquipments
        {
            EquipmentID,
            EquipmentName,
            EquipmentQuantity,
            EquipmentPricePerOne,
            EquipmentPhoto,
            EquipmentCompany,
            EquipmentBuyDate,
            EquipmentMaintainPeriod
        }
        public enum TblModerators
        {
            ModeratorID,
            ModeratorName,
            ModeratorUserName,
            ModeratorPassword,
            ModeratorGender,
            ModeratorEmail,
            ModeratorMobileNumber,
            ModeratorAddress,
            ModeratorPhoto,
            ModeratorBirthDay,
            ModeratorJoinDate,
            DeactivateDate,
            ModeratorSalary,
            ModeratorPendingState,
            ModeratorPermission,
            Comments,
            Theme
        }
        public enum TblPricesPlans
        {
            PlanID,
            PlanName,
            PlanPricePerDay,
            PlanPricePerMonth,
            PlanPricePerQYear,
            PlanPricePerHYear,
            PlanPricePerYear,
            PlanDescription,
            Comments
        }
        public enum tblAds
        {
            AdID,
            AdDescription,
            AdTextColor,
            AdPeriod,
            AdImage
        }
        public enum tblPermissions
        {
            PermissionsID
        }
        public enum tblSettings
        {
            SettingsID,
            SettingsClubName,
            SettingsLogo,
            SettingsPermissions,
            SettingsTheme,
            SettingsComments
        }
        public enum tblTmpModify
        {
            TmpModifyID,
            TmpModifyName,
            TmpModifyUsername,
            TmpModifyPassword,
            TmpModifyState,
            TmpModifyGender,
            TmpModifyEmail,
            TmpModifyAdress,
            TmpModifyMobile,
            TmpModifyPhoto,
            TmpModifyBirthDate,
            TmpModifyCouchID,
            TmpModifyPermissions,
            TmpModifyDayDate

        }
    }
}
