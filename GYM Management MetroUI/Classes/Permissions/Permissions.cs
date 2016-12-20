using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Permissions
{
    public class Permissions
    {
        
        #region Members
        public class MembersPermissionsClass
        {
            public  bool CanAddMembers { get; set; }
            public  bool CanViewMembers { get; set; }
            public  bool CanEditMembers { get; set; }
            public  bool CanDeleteMembers { get; set; }
            public  bool CanPendMembers { get; set; } // = !CanPendMembers
        }
        #endregion

        #region Trainers
        public class TrainersPermissionsClass
        {
            public  bool CanAddTrainer { get; set; }
            public  bool CanViewTrainer { get; set; }
            public  bool CanEditTrainer { get; set; }
            public  bool CanDeleteTrainer { get; set; }
            public  bool CanPendTrainer { get; set; } // = !CanPendTrainer
        }
        #endregion

        #region Moderators
        public class ModeratorsPermissionsClass
        {
            public  bool CanAddModerator { get; set; }
            public  bool CanViewModerator { get; set; }
            public  bool CanEditModerator { get; set; }
            public  bool CanDeleteModerator { get; set; }
            public  bool CanPendModerator { get; set; }  //= !CanDeleteModerator

        }
        #endregion

        #region Admins
        public class AdminsPermissionsClass
        {
            public bool CanAddAdmin { get; set; }
            public bool CanViewAdmin { get; set; }
            public bool CanEditAdmin { get; set; }
            public bool CanDeleteAdmin { get; set; }
            public bool CanPendAdmin { get; set; } // = !CanDeleteAdmin
        }
        #endregion

        #region Forms
        public class FormsPermissionsClass
        {
            public AttendancePermissionsClass Attendance { get; private set; }
            #region Attendance
            public FormsPermissionsClass()
            {
                Attendance = new AttendancePermissionsClass();
            }
            public class AttendancePermissionsClass
            {
                public bool ViewAttendanceForm { get; set; }
                public  bool ViewTrainersAttendance { get; set; }
                public  bool ViewModeratorsAttendance { get; set; }
                public  bool ViewAdminsAttendance { get; set; }

            }
            #endregion
        }
        #endregion
        #region PermissionsProperity
        public FormsPermissionsClass Forms { get; private set; }
        public MembersPermissionsClass Members { get; private set; }
        public TrainersPermissionsClass Trainers { get; private set; }
        public ModeratorsPermissionsClass Moderators { get; private set; }
        public AdminsPermissionsClass Admins { get; private set; }

        #endregion
        public Permissions()
        {
            Forms = new FormsPermissionsClass();
            Members = new MembersPermissionsClass();
            Admins = new AdminsPermissionsClass();
            Trainers = new TrainersPermissionsClass();
            Moderators = new ModeratorsPermissionsClass();
            Admins = new AdminsPermissionsClass();
        }
    }
}
