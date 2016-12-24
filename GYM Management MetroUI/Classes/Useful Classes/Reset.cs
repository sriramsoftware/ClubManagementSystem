using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GYMManagementMetroUI.Classes.Useful_Classes
{

    //This Reset class for clear all controls values
    public  class Reset
    {
        private GroupPanel group = null;


        public Reset(){

        }

        public Reset(GroupPanel Con){
            this.group = Con;
        }



        public void Clear(GroupPanel Con)
        {
            this.group = Con;

            foreach (Control control in group.Controls)
            {
                ResetCtrl(control);

                if (control.HasChildren){
                    foreach (Control child in control.Controls) 
                        ResetCtrl(child);
                }
            }
        }


        public void ResetCtrl(Control control){
            if (control is TextBox){ ((TextBox)control).Clear(); return;}
            if (control is ComboBox){ ((ComboBox)control).SelectedIndex = 0; return;}
            if (control is CheckBox) {((CheckBox)control).Checked = false; return;}
            if (control is ListBox) { ((ListBox)control).ClearSelected(); return; }
            if (control is RadioButton) { ((RadioButton)control).Checked = false; return; }
            if (control is DateTimePicker) { ((DateTimePicker)control).Value = DateTime.Now; return; }
            if (control is PictureBox) { ((PictureBox)control).Image = null; return; }
            //other controls types...

            control = null;

        }



    }
}
