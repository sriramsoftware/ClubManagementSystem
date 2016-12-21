using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Permissions
{
    public class Permissions
    {
        public enum PermissionType
        {
            Coach       = 0,
            Moderator   = 1,
            Admin       = 2
        }

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
            public AdsPermissionsClass Ads { get; private set; }
            public PermissionFormPermissionsClass Permissions { get; set; }
            public ViewFormsPermissionClass ViewForms { get; set; }
            public FormsPermissionsClass()
            {
                Attendance = new AttendancePermissionsClass();
                Ads = new AdsPermissionsClass();
                Permissions = new PermissionFormPermissionsClass();
                ViewForms = new ViewFormsPermissionClass();
            }
            #region Attendance
            
            public class AttendancePermissionsClass
            {
                public bool ViewTrainersAttendance { get; set; }
                public bool ViewModeratorsAttendance { get; set; }
                public bool ViewAdminsAttendance { get; set; }

                
            }
            #endregion
            #region ADS
            public class AdsPermissionsClass
            {
                public bool CanAddAd { get; set; }
                public bool CanEditAd { get; set; }
                public bool CanRemoveAd { get; set; }

            }
            #endregion
            #region Permissions

            public class PermissionFormPermissionsClass
            {
                public bool CanAddPermission { get; set; }
                public bool CanEditPermission { get; set; }
                public bool CanViewPermissionForm { get; set; }
                public bool CanDeletePermission { get; set; }
            }
            #endregion
            #region FormsView
            public class ViewFormsPermissionClass
            {
                public bool ViewAttendanceForm { get; set; }
                public bool ViewAdsForm { get; set; }
                public bool ViewPermissionsForm { get; set; }
                
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
