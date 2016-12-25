using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Member : Person
    {
        public string TrainerName { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }

        public int PaidCurrecy { get; set; }
        public int RestCurrency { get; set; }
        public Member()
        {
            this.Permissions = GYMManagementMetroUI.Permissions.Permissions.SetTo(GYMManagementMetroUI.Permissions.Permissions.PermissionType.None);
        }
    }
}
