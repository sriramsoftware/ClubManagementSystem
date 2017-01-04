using ClubManagement.Classes.Permissions;

namespace ClubManagement.Classes.DataTypes
{
    public class Moderator : Coach
    {
        public static readonly new string className = "Moderator";// Readonly to prevent edit!
        public Moderator()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Moderator);
        }
    }
}
