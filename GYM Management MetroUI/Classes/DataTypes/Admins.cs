using GYMManagementMetroUI.Classes.Permissions;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Admins : Coach
    {
        public bool IsSuperAdmin { get; set; } // Will be true if an admin has all permissions
        public float Salay { get; set; }
        public Admins()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Admin);
        }
    }
}
