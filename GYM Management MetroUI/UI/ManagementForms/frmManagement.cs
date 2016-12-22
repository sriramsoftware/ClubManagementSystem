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

        private void listViewEx2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void tabFormPanel2_Click(object sender, EventArgs e)
        {

        }

        private void sideNavItem2_Click(object sender, EventArgs e)
        {

        }

        private void tabFormItem11_Click(object sender, EventArgs e)
        {

        }

        private void tabFormPanel10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX11_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl8_Click(object sender, EventArgs e)
        {

        }

        private void tabSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {

        }

        private void line1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX24_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
