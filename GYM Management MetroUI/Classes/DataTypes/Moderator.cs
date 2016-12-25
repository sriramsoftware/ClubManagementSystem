using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Moderator : Coach
    {
        public Moderator()
        {
            this.Permissions = GYMManagementMetroUI.Permissions.Permissions.SetTo(GYMManagementMetroUI.Permissions.Permissions.PermissionType.Moderator);
        }
    }
}
