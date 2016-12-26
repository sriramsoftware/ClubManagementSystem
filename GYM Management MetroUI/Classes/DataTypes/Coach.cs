using GYMManagementMetroUI.Classes.Permissions;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Coach : Person
    {
        public float Salary { get; set; }
        public Coach()
        {
            Permissions = PermissionsClass.SetTo(PermissionsClass.PermissionType.Coach);
        }
    }
}
