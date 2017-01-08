using System.Text;

namespace ClubManagement.Classes.Permissions
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

        #region Coaches
        public class TrainersPermissionsClass
        {
            private bool _setAll;
            public  bool CanAddCoaches { get; set; }
            public  bool CanViewCoaches { get; set; }
            public  bool CanEditCoaches { get; set; }
            public  bool CanDeleteCoaches { get; set; }
            public bool SetAll
            {
                get { return _setAll; }
                set
                {
                    CanAddCoaches = value;
                    CanViewCoaches = value;
                    CanEditCoaches = value;
                    CanDeleteCoaches = value;
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
            public bool IsSuperAdmin { get; internal set; }
            public bool SetAll
            {
                get { return _setAll; }
                set
                {
                    CanAddAdmin = value;
                    CanViewAdmin = value;
                    CanEditAdmin = value;
                    CanDeleteAdmin = value;
                    IsSuperAdmin = value;
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
                public bool CanViewAd { get; set; }
                public bool SetAll
                {
                    get { return _ssetAll; }
                    set
                    {
                        CanAddAd = value;
                        CanEditAd = value;
                        CanRemoveAd = value;
                        CanViewAd = value;
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
        public TrainersPermissionsClass Coaches { get; }
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
            Coaches = new TrainersPermissionsClass();
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
                    Coaches.SetAll = false;
                    Moderators.SetAll = false;
                    break;
                case PermissionType.Coach:
                    Members.SetAll = true;
                    Admins.SetAll = false;
                    Coaches.SetAll = false;
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
                    Coaches.SetAll = false;
                    Moderators.SetAll = false;
                    break;
                case PermissionType.Admin:
                    Members.SetAll = true;
                    Forms.SetAll = true;
                    Coaches.SetAll = true;
                    Moderators.SetAll = true;
                    Admins.SetAll = false;
                    break;
                case PermissionType.SuperAdmin:
                    Members.SetAll = true;
                    Forms.SetAll = true;
                    Coaches.SetAll = true;
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
        public static PermissionsClass Parse(StringBuilder _json)
        {
            PermissionsClass p = new PermissionsClass(PermissionType.None);
            dynamic JSON = Newtonsoft.Json.Linq.JObject.Parse(_json.ToString());
            //Members
            p.Members.CanAddMembers = JSON.Members.CanAdd;
            p.Members.CanViewMembers = JSON.Members.CanView;
            p.Members.CanDeleteMembers = JSON.Members.CanDelete;
            p.Members.CanEditMembers = JSON.Members.CanEdit;
            //Coaches
            p.Coaches.CanAddCoaches = JSON.Coaches.CanAdd;
            p.Coaches.CanViewCoaches = JSON.Coaches.CanView;
            p.Coaches.CanDeleteCoaches = JSON.Coaches.CanDelete;
            p.Coaches.CanEditCoaches = JSON.Coaches.CanEdit;
            //Moderators
            p.Moderators.CanAddModerator  = JSON.Moderators.CanAdd;
            p.Moderators.CanViewModerator  = JSON.Moderators.CanView;
            p.Moderators.CanDeleteModerator  = JSON.Moderators.CanDelete;
            p.Moderators.CanEditModerator = JSON.Moderators.CanEdit;
            //Admins
            p.Admins.CanAddAdmin = JSON.Admins.CanAdd;
            p.Admins.CanViewAdmin = JSON.Admins.CanView;
            p.Admins.CanDeleteAdmin = JSON.Admins.CanDelete;
            p.Admins.CanEditAdmin = JSON.Admins.CanEdit;
            p.Admins.IsSuperAdmin = JSON.Admins.IsSuper;
            /* Forms */
            //Attendance
            p.Forms.Attendance.ViewAdminsAttendance = JSON.Forms.Attendance.ViewAdmins;
            p.Forms.Attendance.ViewModeratorsAttendance = JSON.Forms.Attendance.ViewModerators;
            p.Forms.Attendance.ViewTrainersAttendance = JSON.Forms.Attendance.ViewCoaches;
            //Ads
            p.Forms.Ads.CanAddAd = JSON.Forms.Ads.CanAdd;
            p.Forms.Ads.CanEditAd = JSON.Forms.Ads.CanEdit;
            p.Forms.Ads.CanViewAd = JSON.Forms.Ads.CanView;
            p.Forms.Ads.CanRemoveAd = JSON.Forms.Ads.CanDelete;
            //Permissions
            p.Forms.Permissions.CanAddPermission = JSON.Forms.Permissions.CanAdd;
            p.Forms.Permissions.CanEditPermission = JSON.Forms.Permissions.CanEdit;
            p.Forms.Permissions.CanViewPermissionForm = JSON.Forms.Permissions.CanView;
            p.Forms.Permissions.CanDeletePermission = JSON.Forms.Permissions.CanDelete;
            //viewforms
            p.Forms.ViewForms.ViewAdsForm = JSON.Forms.ViewForms.ViewAds;
            p.Forms.ViewForms.ViewAttendanceForm = JSON.Forms.ViewForms.ViewAttendance;
            p.Forms.ViewForms.ViewPermissionsForm = JSON.Forms.ViewForms.ViewPermissions;
            return p;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Properties.Settings.Default.PermissionText);
            //Members
            sb.Replace("#CanAddMembers#", this.Members.CanAddMembers.ToString());
            sb.Replace("#CanViewMembers#", this.Members.CanViewMembers.ToString());
            sb.Replace("#CanEditMembers#", this.Members.CanEditMembers.ToString());
            sb.Replace("#CanDeleteMembers#", this.Members.CanDeleteMembers.ToString());
            //Coaches
            sb.Replace("#CanAddCoaches#", this.Coaches.CanAddCoaches.ToString());
            sb.Replace("#CanViewCoaches#", this.Coaches.CanViewCoaches.ToString());
            sb.Replace("#CanEditCoaches#", this.Coaches.CanEditCoaches.ToString());
            sb.Replace("#CanDeleteCoaches#", this.Coaches.CanDeleteCoaches.ToString());
            //Moderators
            sb.Replace("#CanAddModerators#", this.Moderators.CanAddModerator.ToString());
            sb.Replace("#CanViewModerators#", this.Moderators.CanViewModerator.ToString());
            sb.Replace("#CanEditModerators#", this.Moderators.CanEditModerator.ToString());
            sb.Replace("#CanDeleteModerators#", this.Moderators.CanDeleteModerator.ToString());
            //Admins
            sb.Replace("#CanAddAdmins#", this.Admins.CanAddAdmin.ToString());
            sb.Replace("#CanViewAdmins#", this.Admins.CanViewAdmin.ToString());
            sb.Replace("#CanEditAdmins#", this.Admins.CanEditAdmin.ToString());
            sb.Replace("#CanDeleteAdmins#", this.Admins.CanDeleteAdmin.ToString());
            sb.Replace("#IsSuperAdmin#", this.Admins.IsSuperAdmin.ToString());
            /*                  Forms                   */
            //Attendance
            sb.Replace("#ViewCoachesAttendance#", this.Forms.Attendance.ViewTrainersAttendance.ToString());
            sb.Replace("#ViewModeratorsAttendance#", this.Forms.Attendance.ViewModeratorsAttendance.ToString());
            sb.Replace("#ViewAdminsAttendance#", this.Forms.Attendance.ViewAdminsAttendance.ToString());
            //ADS5
            sb.Replace("#CanAddAds#", this.Forms.Ads.CanAddAd.ToString());
            sb.Replace("#CanEditAds#", this.Forms.Ads.CanEditAd.ToString());
            sb.Replace("#CanViewAds#", this.Forms.Ads.CanViewAd.ToString());
            sb.Replace("#CanDeleteAds#", this.Forms.Ads.CanRemoveAd.ToString());
            //Permissions
            sb.Replace("#CanAddPermissions#", this.Forms.Permissions.CanAddPermission.ToString());
            sb.Replace("#CanEditPermissions#", this.Forms.Permissions.CanEditPermission.ToString());
            sb.Replace("#CanDeletePermissions#", this.Forms.Permissions.CanDeletePermission.ToString());
            //ViewForms
            sb.Replace("#ViewAttendanceForm#", this.Forms.ViewForms.ViewAttendanceForm.ToString());
            sb.Replace("#ViewAdsForm#", this.Forms.ViewForms.ViewAdsForm.ToString());
            sb.Replace("#ViewPermissionsForm#", this.Forms.ViewForms.ViewPermissionsForm.ToString());
            return sb.ToString();
        }
    }
}
