﻿using System;
using GYMManagementMetroUI.Classes.Permissions;

namespace GYMManagementMetroUI.Classes.DataTypes
{
   public class Member : Person
    {
        public string TrainerName { get; set; }
        public int TrainerID { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }

        public int PaidCurrecy { get; set; }
        public int RestCurrency { get; set; }
        public Member()
        {
            Permissions =PermissionsClass.SetTo(PermissionsClass.PermissionType.None);
        }
    }
}
