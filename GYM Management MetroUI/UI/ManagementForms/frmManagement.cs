using GYMManagementMetroUI.Classes.Useful_Classes;
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

  
        private void listViewEx5_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void txtSettingsPricesPlanPriceManualDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtSettingsPricesPlanPriceManualMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txtSettingsPricesPlanPriceManualQYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void txtSettingsPricesPlanPriceManualHYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void txtSettingsPricesPlanPriceManualYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtSettingsPricesPlanPriceManualDay_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSettingsPricesPlanPriceManualDay.Text.Trim()))
            {
                txtSettingsPricesPlanPriceManualDay.Text = 0.ToString();
                txtSettingsPricesPlanPriceManualDay.SelectionStart = 0;
                txtSettingsPricesPlanPriceManualDay.SelectionLength = txtSettingsPricesPlanPriceManualDay.TextLength;
                txtSettingsPricesPlanPriceManualDay.SelectAll();
            }
                txtSettingsPricesPlanPriceManualMonth.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualDay.Text) * 30d).ToString();

                txtSettingsPricesPlanPriceManualQYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualMonth.Text) * 3d).ToString();

                txtSettingsPricesPlanPriceManualHYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualQYear.Text) * 2d).ToString();
            
                txtSettingsPricesPlanPriceManualYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualHYear.Text) * 2d).ToString();

        }

        private void txtSettingsPricesPlanPriceManualMonth_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSettingsPricesPlanPriceManualMonth.Text.Trim()))
            {
                txtSettingsPricesPlanPriceManualMonth.Text = 0.ToString();
                txtSettingsPricesPlanPriceManualMonth.SelectionStart = 0;
                txtSettingsPricesPlanPriceManualMonth.SelectionLength = txtSettingsPricesPlanPriceManualMonth.TextLength;
                txtSettingsPricesPlanPriceManualMonth.SelectAll();
            }
                txtSettingsPricesPlanPriceManualQYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualMonth.Text) * 3d).ToString();

                txtSettingsPricesPlanPriceManualHYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualQYear.Text) * 2d).ToString();

                txtSettingsPricesPlanPriceManualYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualHYear.Text) * 2d).ToString();

        }

        private void txtSettingsPricesPlanPriceManualQYear_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSettingsPricesPlanPriceManualQYear.Text.Trim()))
            {
                txtSettingsPricesPlanPriceManualQYear.Text = 0.ToString();
                txtSettingsPricesPlanPriceManualQYear.SelectionStart = 0;
                txtSettingsPricesPlanPriceManualQYear.SelectionLength = txtSettingsPricesPlanPriceManualQYear.TextLength;
                txtSettingsPricesPlanPriceManualQYear.SelectAll();
            }
                txtSettingsPricesPlanPriceManualHYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualQYear.Text) * 2d).ToString();

                txtSettingsPricesPlanPriceManualYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualHYear.Text) * 2d).ToString();

        }

        private void txtSettingsPricesPlanPriceManualHYear_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSettingsPricesPlanPriceManualHYear.Text.Trim()))
            {
                txtSettingsPricesPlanPriceManualHYear.Text = 0.ToString();
                txtSettingsPricesPlanPriceManualHYear.SelectionStart = 0;
                txtSettingsPricesPlanPriceManualHYear.SelectionLength = txtSettingsPricesPlanPriceManualQYear.TextLength;
                txtSettingsPricesPlanPriceManualHYear.SelectAll();
            }
                txtSettingsPricesPlanPriceManualYear.Text = (Convert.ToDouble(txtSettingsPricesPlanPriceManualHYear.Text) * 2d).ToString();
        }

    

        private void sliderAdsDuration_ValueChanged(object sender, EventArgs e)
        {
            lblAdsSlideDuration.Text = sliderAdsDuration.Value.ToString("00") + " Minutes";
        }



        // Start Rest Zone {
        Reset R = new Reset();
        private void btnModeratorsAddModeratorReset_Click(object sender, EventArgs e)
        {
            R.Clear(groupPnlModeratorsAddModeratorGroup);
        }

        private void btnAdminAddAdminRest_Click(object sender, EventArgs e)
        {
            R.Clear(groupPnlAdminAddAdminGroup);
        }

        private void btnTrainersAddTrainerReset_Click(object sender, EventArgs e)
        {
            R.Clear(groupPnlCoachesAddCoachGroup);
        }

        private void btnMembersAddMemberReset_Click(object sender, EventArgs e)
        {
            R.Clear(groupPnlMembersAddMemberGroup);
        }


        // } End Rest Zone

      

     

  
       
    }
}
