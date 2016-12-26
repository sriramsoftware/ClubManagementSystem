namespace GYMManagementMetroUI.Classes
{
    class Coach : Person
    {
        public float Salary { get; set; }
        public Coach()
        {
            this.Permissions = Classes.Permissions.Permissions.SetTo(Classes.Permissions.Permissions.PermissionType.Coach);
        }
    }
}
