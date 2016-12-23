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

        private void txtPlanPriceDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlanPriceMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlanPriceQYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlanPriceHYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlanPriceYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlanPriceDay_TextChanged(object sender, EventArgs e)
        {
            txtPlanPriceMonth.Text = (float.Parse(txtPlanPriceDay.Text) * 30f).ToString();
            txtPlanPriceQYear.Text = (float.Parse(txtPlanPriceDay.Text) * 90f).ToString();
            txtPlanPriceHYear.Text = (float.Parse(txtPlanPriceDay.Text) * 180f).ToString();
            txtPlanPriceYear.Text = (float.Parse(txtPlanPriceDay.Text) * 360f).ToString();
        }

        private void txtPlanPriceMonth_TextChanged(object sender, EventArgs e)
        {
            txtPlanPriceQYear.Text = (float.Parse(txtPlanPriceMonth.Text) * 3f).ToString();
            txtPlanPriceHYear.Text = (float.Parse(txtPlanPriceMonth.Text) * 6f).ToString();
            txtPlanPriceYear.Text = (float.Parse(txtPlanPriceMonth.Text) * 12f).ToString();
        }

        private void txtPlanPriceQYear_TextChanged(object sender, EventArgs e)
        {
            txtPlanPriceHYear.Text = (float.Parse(txtPlanPriceQYear.Text) * 2f).ToString();
            txtPlanPriceYear.Text = (float.Parse(txtPlanPriceQYear.Text) * 4f).ToString();
        }

        private void txtPlanPriceHYear_TextChanged(object sender, EventArgs e)
        {
            txtPlanPriceYear.Text = (float.Parse(txtPlanPriceHYear.Text) * 2f).ToString();
        }

       

  
       
    }
}
