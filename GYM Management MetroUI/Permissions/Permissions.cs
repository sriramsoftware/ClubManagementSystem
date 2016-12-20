﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYM_Management_MetroUI.Permissions
{
    public static class Permissions
    {
        #region Members
        public static bool CanAddMembers { get; set; }
        public static bool CanViewMembers { get; set; }
        public static bool CanEditMembers { get; set; }
        public static bool CanDeleteMembers { get; set; }
        #endregion

        #region Trainers
        public static bool CanAddTrainer { get; set; }
        public static bool CanViewTrainer { get; set; }
        public static bool CanEditTrainer { get; set; }
        public static bool CanDeleteTrainer { get; set; }
        #endregion

        #region Moderators
        public static bool CanAddModerator { get; set; }
        public static bool CanViewModerator { get; set; }
        public static bool CanEditModerator { get; set; }
        public static bool CanDeleteModerator { get; set; }
        #endregion

        #region Admins
        public static bool CanAddAdmin { get; set; }
        public static bool CanViewAdmin { get; set; }
        public static bool CanEditAdmin { get; set; }
        public static bool CanDeleteAdmin { get; set; }
        #endregion




    }
}
