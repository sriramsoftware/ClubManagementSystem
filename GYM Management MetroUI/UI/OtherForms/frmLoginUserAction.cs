using GYMManagementMetroUI.Classes.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static GYMManagementMetroUI.Classes.DBAccess.DBResultClass;

namespace GYMManagementMetroUI.UI.OtherForms
{
    public partial class frmLoginUserAction : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region Singlton
        static frmUserLogin me = null;
        public static frmUserLogin Instance
        {
            get
            {
                if (me == null)
                {
                    me = new frmUserLogin();
                }
                return me;
            }
        }
        void me_FormClosing(object sender, FormClosingEventArgs e)
        {
            me = null;
        }
        #endregion


        public enum State
        {
            Attendance,
            Leaving
        }
      int Counter = 3;
        public frmLoginUserAction()
        {
            InitializeComponent();
            btnAutoHide.Text = string.Format(" Auto close in ({0}) seconds...", Counter);
        }
        /// <summary>
        /// Show this form when user register his attendance or leaving.
        /// </summary>
        /// <param name="state">State which refers to Attendance or Leaving.</param>
        /// <param name="UserID">Username to view it on the form.</param>

        public string UserID;

        public void ShowDialog(State state,string UserID)
        {
            string msg = "";
            this.UserID = UserID;
            string UserName = UserID; // Get username form db
            switch (state)
            {
                case State.Attendance:
                     msg =string.Format("<font color=\"#000000\">Welcome Back '{0}' , hope you enjoy</font><font color=\"#BA1419\"></font><b></b>",UserName);
                     lblAttendace.Text = msg;
                     lblAttendace.Show();
                     lblLeave.Hide();
                   
                    break;
                case State.Leaving:
                    //Get Time stayed in GYM from db here
                    DateTime time = DateTime.Now;
                    msg = string.Format("Hi '{0}', you stayed for <font color=\"#f00\">{1}</font>, see you again!", UserName,time.ToString("hh:mm"));
                    lblLeave.Text = msg;
                    lblLeave.Show();
                    lblAttendace.Hide();
                    break;
            }

            timer1.Start();
            base.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Counter == 0)
            {
                timer1.Stop();
                this.Close();
            }
            btnAutoHide.Text = string.Format(" Auto close in ({0}) seconds...",Counter);
            Counter--;
        }

        private void btnAutoHide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void btnfrmLoginUserActionPause_Click(object sender, EventArgs e)
        {

            //swap btn text && show details groupPnl
            btnfrmLoginUserActionPause.Text = (btnfrmLoginUserActionPause.Text == "Pause & Show Details" ? "Close" : "Pause & Show Details");
            if (!groupPnlfrmLoginUserActionDetails.Visible) groupPnlfrmLoginUserActionDetails.Visible = true;


            ///<summary>
            /// Equation : [will be here]
            /// http://www.freedieting.com/tools/calories_burned.htm
            /// </summary>

            
            //member details reqired here
            Member UserLeave = new Member();
            //UserLeave = DBResult.Q("return user info (age, gender, Weight, Height, [M + H*60] ) from DB");

            float cal;
            cal = eqCal(UserLeave.Age, UserLeave.Gender.ToString()[0], UserLeave.Weight, UserLeave.Height, UserLeave.Session);
               
            lblfrmLoginUserActionCal.Text = cal.ToString() + " Cal";

        }

        public float eqCal(float age, char gender, float height, float weight, float minutes)
        {
            float res = 0.0F;
            // res = 
            return res;
        }

        private void btnfrmUserLoginReportChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Pass username of member who will leave
            new frmLoginUserActionReport().ShowDialog(this.UserID);
            this.Show();
        }

        private void frmLoginUserAction_Load(object sender, EventArgs e)
        {

        }
    }
}
