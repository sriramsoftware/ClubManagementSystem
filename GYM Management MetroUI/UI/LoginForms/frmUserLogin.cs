using GYM_Management_MetroUI.UI.LoginForms;
using GYM_Management_MetroUI.UI.OtherForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GYM_Management_MetroUI
{
    public partial class frmUserLogin : DevComponents.DotNetBar.Metro.MetroForm
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
        public frmUserLogin()
        {
            InitializeComponent();
            me = this;
            me.FormClosing += me_FormClosing;
        }

        private void lnkInformations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FAQ().ShowDialog();
        }
        private void lnkAdminPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmAdminLogin().ShowDialog();
        }




        //we will need to pass (1 or 0) to frmLoginUserAction to set which label shows for Attendance || Leave
        //we will need to pass ( username in any case ) &&  ( section time in leave case )
        #region userLogin click buttons Attendance || Leave
       
        private void btnRegAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLoginUserAction().ShowDialog();
        }

        private void btnRegLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLoginUserAction().ShowDialog();
        }

        #endregion



    }
}
