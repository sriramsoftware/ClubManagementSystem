using GYMManagementMetroUI.Classes.Permissions;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Moderator : Coach
    {
        public Moderator()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Moderator);
        }
    }
}
