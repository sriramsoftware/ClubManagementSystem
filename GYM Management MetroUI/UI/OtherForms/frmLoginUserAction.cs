using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GYMManagementMetroUI.UI.OtherForms
{
    public partial class frmLoginUserAction : DevComponents.DotNetBar.Metro.MetroForm
    {
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
        public void ShowDialog(State state,string UserID)
        {
            string msg = "";
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
    }
}
