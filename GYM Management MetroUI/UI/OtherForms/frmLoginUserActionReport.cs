using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace GYMManagementMetroUI.UI.OtherForms
{
    public partial class frmLoginUserActionReport : DevComponents.DotNetBar.Metro.MetroForm
    {
        public static object MemberUsername { get; set; }

        public frmLoginUserActionReport()
        {
            InitializeComponent();
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }


        public void ShowDialog(string MemberUsername)
        {
            ///<summary>
            ///get last month attendance detials and cal per each attend day in chart style
            ///each col will hold pair of values [minutues - cals] 
            ///height level depending on attendance minutes
            /// </summary>
            /// 

        }




        private void frmLoginUserActionReport_Load(object sender, EventArgs e)
        {

        }
    }
}