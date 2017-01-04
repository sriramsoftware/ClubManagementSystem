using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClubManagement.UI.LoginForms;
using ClubManagement.UI.ManagementForms;

namespace ClubManagement.UI.LoginForms
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

        public bool ShowMainForm1 { get; set; } = false;

        public frmAdminLogin()
        {
            InitializeComponent();
            me = this;
            me.FormClosing += me_FormClosing;
        }

        private void frmAdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ShowMainForm1) frmUserLogin.Instance.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.ShowMainForm1 = true;
            this.Close();
        }

    }
}
