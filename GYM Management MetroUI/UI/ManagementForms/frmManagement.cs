using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GYMManagementMetroUI
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmUserLogin.Instance.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set auto Resfresh for attendance
            // backcoloring cells depending on text inside dynamically ex:  {
            //      "still here" => (light green for current cell)  
            //      "leave" => (light red for whole row)
            //  ..
            // } 


        }

  
       
    }
}
