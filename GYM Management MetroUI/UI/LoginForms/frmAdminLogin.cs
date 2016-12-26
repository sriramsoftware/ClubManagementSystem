using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GYMManagementMetroUI.UI.LoginForms;
using GYMManagementMetroUI.UI.ManagementForms;

namespace GYMManagementMetroUI.UI.LoginForms
{
    public partial class frmAdminLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region Singlton
        static frmAdminLogin me = null;
        public static frmAdminLogin Instance
        {
            get
            {
                if (me == null)
                {
                    me = new frmAdminLogin();
                }
                return me;
            }
        }
        void me_FormClosing(object sender, FormClosingEventArgs e)
        {
            me = null;
        }
        #endregion
        bool ShowMainForm = false;
        public bool ShowMainForm1
        {
            get { return ShowMainForm; }
            set { ShowMainForm = value; }
        }

        public frmAdminLogin()
        {
            InitializeComponent();
            me = this;
            me.FormClosing += me_FormClosing;
        }

        private void frmAdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ShowMainForm) frmUserLogin.Instance.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.ShowMainForm = true;
            this.Close();
        }
    }
}
