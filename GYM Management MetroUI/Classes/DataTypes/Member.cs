using System;
using ClubManagement.Classes.Permissions;

namespace ClubManagement.Classes.DataTypes
{
   public class Member : Person
    {
        public static readonly new string className = "Member";// Readonly to prevent edit!
        public string TrainerName { get; set; }
        public int TrainerID { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }
        public int PaidCurrecy { get; set; }
        public int RestCurrency { get; set; }
        public float Session { get; set; } // in minutes



        public Member()
        {
            Permissions =PermissionsClass.SetTo(PermissionsClass.PermissionType.None);
        }
    }
}
