using GYMManagementMetroUI.Classes.Permissions;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    public class Admins : Coach
    {
        public static string className = "Admin";
        public bool IsSuperAdmin { get; set; } // Will be true if an admin has all permissions
        public Admins()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Admin);
        }
    }
}
