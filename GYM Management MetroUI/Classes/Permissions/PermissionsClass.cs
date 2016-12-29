using System.Text;

namespace GYMManagementMetroUI.Classes.Permissions
{
    public class PermissionsClass
    {
        public enum PermissionType
        {
            None        = 0,
            Coach       = 1,
            Moderator   = 2,
            Admin       = 3,
            SuperAdmin  = 4
        }

        #region Members
        public class MembersPermissionsClass
        {
            private bool _setAll;
            public  bool CanAddMembers { get; set; }
            public  bool CanViewMembers { get; set; }
            public  bool CanEditMembers { get; set; }
            public  bool CanDeleteMembers { get; set; }
            public bool SetAll {
                get { return _setAll; }
                set
                {
                    CanAddMembers = value;
                    CanViewMembers = value;
                    CanEditMembers = value;
                    CanDeleteMembers = value;
                    _setAll = value;
                }
            }
        }
        #endregion

        #region Trainers
        public class TrainersPermissionsClass
        {
            private bool _setAll;
            public  bool CanAddTrainer { get; set; }
            public  bool CanViewTrainer { get; set; }
            public  bool CanEditTrainer { get; set; }
            public  bool CanDeleteTrainer { get; set; }
            public bool SetAll
            {
                get { return _setAll; }
                set
                {
                    CanAddTrainer = value;
                    CanViewTrainer = value;
                    CanEditTrainer = value;
                    CanDeleteTrainer = value;
                    _setAll = value;
                }
            }
        }
        #endregion

        #region Moderators
        public class ModeratorsPermissionsClass
        {
            private bool _setAll;
            public  bool CanAddModerator { get; set; }
            public  bool CanViewModerator { get; set; }
            public  bool CanEditModerator { get; set; }
            public  bool CanDeleteModerator { get; set; }
            public bool SetAll
            {
                get { return _setAll; }
                set
                {
                    CanAddModerator = value;
                    CanViewModerator = value;
                    CanEditModerator = value;
                    CanDeleteModerator = value;
                    _setAll = value;
                }
            }

        }
        #endregion

        #region Admins
        public class AdminsPermissionsClass
        {
            private bool _setAll;
            public bool CanAddAdmin { get; set; }
            public bool CanViewAdmin { get; set; }
            public bool CanEditAdmin { get; set; }
            public bool CanDeleteAdmin { get; set; }
            public bool SetAll
            {
                get { return _setAll; }
                set
                {
                    CanAddAdmin = value;
                    CanViewAdmin = value;
                    CanEditAdmin = value;
                    CanDeleteAdmin = value;
                    _setAll = value;
                }
            }
        }
        #endregion

        #region Forms
        public class FormsPermissionsClass
        {
            private bool _setAll;
            public AttendancePermissionsClass Attendance { get; }
            public AdsPermissionsClass Ads { get; }
            public PermissionFormPermissionsClass Permissions { get; set; }
            public ViewFormsPermissionClass ViewForms { get; set; }
            public bool SetAll
            {
                get { return _setAll; }
                set
                {
                    Attendance.SetAll = value;
                    Ads.SetAll = value;
                    Permissions.SetAll = value;
                    ViewForms.SetAll = value;
                    _setAll = value;
                }
            }
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
                private bool _ssetAll;
                
                public bool ViewTrainersAttendance { get; set; }
                public bool ViewModeratorsAttendance { get; set; }
                public bool ViewAdminsAttendance { get; set; }
                public bool SetAll
                {
                    get { return _ssetAll; }
                    set
                    {
                        ViewTrainersAttendance = value;
                        ViewModeratorsAttendance = value;
                        ViewAdminsAttendance = value;
                        _ssetAll = value;
                    }
                }
                
            }
            #endregion
            #region ADS
            public class AdsPermissionsClass
            {
                private bool _ssetAll;
                public bool CanAddAd { get; set; }
                public bool CanEditAd { get; set; }
                public bool CanRemoveAd { get; set; }
                public bool SetAll
                {
                    get { return _ssetAll; }
                    set
                    {
                        CanAddAd = value;
                        CanEditAd = value;
                        CanRemoveAd = value;
                        _ssetAll = value;
                    }
                }

            }
            #endregion
            #region Permissions

            public class PermissionFormPermissionsClass
            {
                private bool _ssetAll;
                public bool CanAddPermission { get; set; }
                public bool CanEditPermission { get; set; }
                public bool CanViewPermissionForm { get; set; }
                public bool CanDeletePermission { get; set; }
                public bool SetAll
                {
                    get { return _ssetAll; }
                    set
                    {
                        CanAddPermission = value;
                        CanEditPermission = value;
                        CanViewPermissionForm = value;
                        CanDeletePermission = value;
                        _ssetAll = value;
                    }
                }
            }
            #endregion
            #region FormsView
            public class ViewFormsPermissionClass
            {
                private bool _ssetAll;
                public bool ViewAttendanceForm { get; set; }
                public bool ViewAdsForm { get; set; }
                public bool ViewPermissionsForm { get; set; }
                public bool SetAll
                {
                    get { return _ssetAll; }
                    set
                    {
                        ViewAttendanceForm = value;
                        ViewAdsForm = value;
                        ViewPermissionsForm = value;
                        _ssetAll = value;
                    }
                }
            }
            #endregion
        }

        #endregion

        #region PermissionsProperity
        public FormsPermissionsClass Forms { get; }
        public MembersPermissionsClass Members { get; }
        public TrainersPermissionsClass Trainers { get; }
        public ModeratorsPermissionsClass Moderators { get; }
        public AdminsPermissionsClass Admins { get; }

        #endregion
        public PermissionsClass():this(PermissionType.None)
        {
        }
        public PermissionsClass(PermissionType permission)
        {
            Forms = new FormsPermissionsClass();
            Members = new MembersPermissionsClass();
            Admins = new AdminsPermissionsClass();
            Trainers = new TrainersPermissionsClass();
            Moderators = new ModeratorsPermissionsClass();
            SetDefault(permission);
        }
        private void SetDefault(PermissionType permission)
        {
            switch (permission)
            {
                case PermissionType.None:
                    Forms.SetAll = false;
                    Members.SetAll = false;
                    Admins.SetAll = false;
                    Trainers.SetAll = false;
                    Moderators.SetAll = false;
                    break;
                case PermissionType.Coach:
                    Members.SetAll = true;
                    Admins.SetAll = false;
                    Trainers.SetAll = false;
                    Moderators.SetAll = false;
                    Forms.SetAll = false;
                    Forms.ViewForms.ViewAttendanceForm = true;
                    break;
                case PermissionType.Moderator:
                    Members.SetAll = true;
                    Forms.SetAll = false;
                    Forms.ViewForms.ViewAttendanceForm = true;
                    Forms.Attendance.ViewTrainersAttendance = true;
                    Admins.SetAll = false;
                    Trainers.SetAll = false;
                    Moderators.SetAll = false;
                    break;
                case PermissionType.Admin:
                    Members.SetAll = true;
                    Forms.SetAll = true;
                    Trainers.SetAll = true;
                    Moderators.SetAll = true;
                    Admins.SetAll = false;
                    break;
                case PermissionType.SuperAdmin:
                    Members.SetAll = true;
                    Forms.SetAll = true;
                    Trainers.SetAll = true;
                    Moderators.SetAll = true;
                    Admins.SetAll = true;
                    break;
                default:
                    SetDefault(PermissionType.None);
                    break;
            }
        }
        public static PermissionsClass SetTo(PermissionType permission)
        {
            return new PermissionsClass(permission);
        }
        public static PermissionsClass Parse(StringBuilder json)
        {
            PermissionsClass p = new PermissionsClass(PermissionType.None);

            // will Parse JSON File Here
            return p;
        }
    }
}
