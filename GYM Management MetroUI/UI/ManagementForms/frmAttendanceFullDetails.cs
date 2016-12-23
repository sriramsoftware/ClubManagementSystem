using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GYMManagementMetroUI.UI.ManagementForms
{
    public partial class frmAttendanceFullDetails : DevComponents.DotNetBar.Metro.MetroForm
    {
        public enum ControlsState
        {
            Normal,
            Disabled,
            ReadOnly
        }
        public enum FormState
        {
            View,
            Edit
        }
        public int UserID { get; set; } 
        public frmAttendanceFullDetails():this(FormState.View)
        {
        }
        public frmAttendanceFullDetails(FormState state)
        {
            InitializeComponent();
            UserID = 0;
            ChangeFormState(state);
        }


        #region Important Methods
        private void SetControlEnabled(ControlsState State)
        {
            foreach (Control item in groupPanel1.Controls)
            {
                if (item.GetType() == typeof(TextBoxX))
                {
                    switch (State)
                    {
                        case ControlsState.Normal:
                             TextBoxX controll = item as TextBoxX;
                             controll.ReadOnly = false;
                             controll.Enabled = true;
                            break;
                        case ControlsState.Disabled:
                            item.Enabled = false;
                            break;
                        case ControlsState.ReadOnly:
                            TextBoxX c = item as TextBoxX;
                            c.ReadOnly = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private void ChangeFormState(FormState state)
        {
            switch (state)
            {
                case FormState.View:
                    this.Size = this.MinimumSize;
                    this.btnCancel.Hide();
                    this.btnSave.Hide();
                    lnkChangeImage.Hide();
                    SetControlEnabled(ControlsState.ReadOnly);
                    break;
                case FormState.Edit:
                    this.Size = this.MaximumSize;
                    this.btnCancel.Show();
                    this.btnSave.Show();
                    lnkChangeImage.Show();
                    SetControlEnabled(ControlsState.Normal);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
