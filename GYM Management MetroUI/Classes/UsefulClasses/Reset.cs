using DevComponents.DotNetBar.Controls;
using System;
using System.Windows.Forms;


namespace GYMManagementMetroUI.Classes.UsefulClasses
{

    /// <summary>
    /// This Reset class for clear all controls values
    /// </summary>
    public  class Reset
    {
        /// <summary>
        /// Set all controls to its default value in container control
        /// </summary>
        /// <param name="con">Control which will be cleared</param>
        public static void Clear(Control con)
        {
            foreach (Control control in con.Controls)
            {
                ResetCtrl(control);

                if (control.HasChildren){
                    foreach (Control child in control.Controls)
                        Clear(child);
                }
            }
        }

        /// <summary>
        /// Set all controls to its default value in single control
        /// </summary>
        /// <param name="control">Control which will be cleared</param>
        public static void ResetCtrl(Control control)
        {
            if (control is TextBox) { ((TextBox)control).Clear();}
            else if (control is ComboBox) { ((ComboBox)control).SelectedIndex = 0;}
            else if (control is CheckBox) { ((CheckBox)control).Checked = false; }
            else if (control is ListBox) { ((ListBox)control).ClearSelected();}
            else if (control is RadioButton) { ((RadioButton)control).Checked = false;}
            else if (control is DateTimePicker) { ((DateTimePicker)control).Value = DateTime.Now;}
            else if (control is PictureBox) { ((PictureBox)control).Image = null;}
            else if (control is Label && control.Tag.ToString().ToLower().Contains("edit")) { ((Label)control).Text = @"..."; }
            else if (control is SwitchButton) { ((SwitchButton)control).Value = false;}
            //other controls types...
        }



    }
}
