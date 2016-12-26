namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Moderator : Coach
    {
        public Moderator()
        {
            this.Permissions = Classes.Permissions.Permissions.SetTo(Classes.Permissions.Permissions.PermissionType.Moderator);
        }
    }
}
