using GYMManagementMetroUI.Classes.DBAccess;
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
    public partial class frmTest : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        

        private void btnfrmTestConnect_Click(object sender, EventArgs e)
        {

            if (Connection.isConnected())
            {
                switchfrmTestDbCon.Value = true;
                btnfrmTestPull.BackColor = Color.LightGreen;

                // foreach table in DB --> add table names into comboBox
                //foreach ()
                //{
                //    comboBoxfrmTestTable.Items.Add("Tables Names");
                //}

            }
            else
            {
                switchfrmTestDbCon.Value = false;
                btnfrmTestPull.BackColor = Color.Red;
                //  message ex here
            }
        }

        private void comboBoxfrmTestTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // foreach row in Table --> add row id into comboBoxfrmTestId
            //foreach ()
            //{
            //    comboBoxfrmTestId.Items.Add("Rows ids");
            //}
        }



        private void btnfrmTestTest_Click(object sender, EventArgs e)
        {

            //string str = DBResultClass.Query(
            //"Q here: select name from table = comboBoxfrmTestTable.SelectedItem where id = comboBoxfrmTestId.SelectedItem");

            //if(str == "~")
           // {
               // MessageBox.Show("Error");
            //}
            //lblfrmTestName.Text = "Name: " + str;
        }



    }
}
