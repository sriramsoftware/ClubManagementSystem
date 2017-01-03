using GYMManagementMetroUI.Classes.Permissions;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    public class Moderator : Coach
    {
        public static string className = "Moderator";
        public Moderator()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Moderator);
        }
    }
}
