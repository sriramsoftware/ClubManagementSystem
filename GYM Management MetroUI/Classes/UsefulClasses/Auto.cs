using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubManagement.Classes.UsefulClasses
{
    /// <summary>
    /// this Auto class for all auto events and methods
    /// ex: if boy run :D before close full details report form ==> Auto(this, 5*60);
    /// ex: moderator go to buy coffee and forex meet his gf in street :D late and stuff [avoid members watch his screen]
    /// \_==> Auto(this, 5*60, 1);
    /// </summary>
    class Auto
    {
        private float timeMinutes;
        public object targetObj;
        public bool pass = false;

        public Auto(object obj, float time)
        {
            timeMinutes = time;
            targetObj = obj;
        }

        public Auto(object obj, float time, bool pass)
        {
            timeMinutes = time;
            targetObj = obj;
            if (pass) this.pass = true;
        }


        ///<summary>
        ///if (pass == true) frmAdminLogin  apear...
        ///settings enable to set close with pass or not
        /// </summary>



    }
}
