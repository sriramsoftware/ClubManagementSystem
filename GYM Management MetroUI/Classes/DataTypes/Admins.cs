using ClubManagement.Classes.Permissions;

namespace ClubManagement.Classes.DataTypes
{
    public class Admins : Coach
    {
        public static readonly new string className = "admin"; // Readonly to prevent edit!
        public bool IsSuperAdmin { get; set; } // Will be true if an admin has all permissions
        public Admins()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Admin);
        }
    }
}
