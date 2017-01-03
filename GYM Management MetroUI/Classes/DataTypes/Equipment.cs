using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYMManagementMetroUI.Classes.DataTypes
{
    class Equipment
    {
        public static string className = "Equipment";
        #region Properties
        public string Name { get; set; }
        public DateTime purchaseDate { get; set; }
        public string Photo { get; set; }
        #endregion


        #region Methods
        public Equipment()
        {

        }
        #endregion
    }
}
