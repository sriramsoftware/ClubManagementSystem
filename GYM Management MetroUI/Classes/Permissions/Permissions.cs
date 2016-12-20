using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Permissions
{
    public class Permissions
    {
        #region Members
        public static class Members
        {
            public static bool CanAddMembers { get; set; }
            public static bool CanViewMembers { get; set; }
            public static bool CanEditMembers { get; set; }
            public static bool CanDeleteMembers { get; set; }
            public static bool CanPendMembers { get; set; } // = !CanPendMembers
        }
        #endregion

        #region Trainers
        public static class Trainers
        {
            public static bool CanAddTrainer { get; set; }
            public static bool CanViewTrainer { get; set; }
            public static bool CanEditTrainer { get; set; }
            public static bool CanDeleteTrainer { get; set; }
            public static bool CanPendTrainer { get; set; } // = !CanPendTrainer
        }
        #endregion

        #region Moderators
        public static class Moderators
        {
            public static bool CanAddModerator { get; set; }
            public static bool CanViewModerator { get; set; }
            public static bool CanEditModerator { get; set; }
            public static bool CanDeleteModerator { get; set; }
            public static bool CanPendModerator { get; set; }  //= !CanDeleteModerator

        }
        #endregion

        #region Admins
        public static class Admins
        {
            public static bool CanAddAdmin { get; set; }
            public static bool CanViewAdmin { get; set; }
            public static bool CanEditAdmin { get; set; }
            public static bool CanDeleteAdmin { get; set; }
            public static bool CanPendAdmin { get; set; } // = !CanDeleteAdmin
        }
        #endregion

        #region Forms
        #region Attendance
        public static class Attendance
        {
            public static bool ViewAttendanceForm { get; set; }
            public static bool ViewTrainersAttendance { get; set; }
            public static bool ViewModeratorsAttendance { get; set; }
            public static bool ViewAdminsAttendance { get; set; }
            
        }
        #endregion
        #endregion




    }
}
