using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes
{
    class Coach : Person
    {
        public float Salary { get; set; }
        public Coach()
        {
            this.Permissions = GYMManagementMetroUI.Permissions.Permissions.SetTo(GYMManagementMetroUI.Permissions.Permissions.PermissionType.Coach);
        }
    }
}
