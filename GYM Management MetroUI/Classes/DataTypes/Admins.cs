using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Admins : Coach
    {
        public bool IsSuperAdmin { get; set; } // Will be true if an admin has all permissions
        public float Salay { get; set; }
        public Admins()
        {
            this.Permissions = GYMManagementMetroUI.Permissions.Permissions.SetTo(GYMManagementMetroUI.Permissions.Permissions.PermissionType.Admin);
        }
    }
}
