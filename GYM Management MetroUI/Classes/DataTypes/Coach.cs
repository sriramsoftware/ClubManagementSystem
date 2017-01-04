using ClubManagement.Classes.Permissions;

namespace ClubManagement.Classes.DataTypes
{
   public class Coach : Person
    {
        public static readonly new string className = "coach";// Readonly to prevent edit!
        public float Salary { get; set; }
        public Coach()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Coach);
        }
    }
}
