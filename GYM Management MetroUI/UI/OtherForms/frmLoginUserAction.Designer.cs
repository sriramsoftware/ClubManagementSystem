namespace GYMManagementMetroUI.UI.OtherForms
{
    partial class frmLoginUserAction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAttendace = new DevComponents.DotNetBar.LabelX();
            this.lblLeave = new DevComponents.DotNetBar.LabelX();
            this.btnAutoHide = new DevComponents.DotNetBar.ButtonX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAttendace
            // 
            this.lblAttendace.AutoSize = true;
            this.lblAttendace.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblAttendace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAttendace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblAttendace.ForeColor = System.Drawing.Color.Black;
            this.lblAttendace.Location = new System.Drawing.Point(98, 37);
            this.lblAttendace.Name = "lblAttendace";
            this.lblAttendace.SingleLineColor = System.Drawing.Color.Transparent;
            this.lblAttendace.Size = new System.Drawing.Size(370, 28);
            this.lblAttendace.TabIndex = 0;
            this.lblAttendace.Text = "<font color=\"#000000\">Welcome Back {{ user }}, hope you enjoy</font><font color=\"" +
    "#BA1419\"></font><b></b>";
            this.lblAttendace.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblLeave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblLeave.ForeColor = System.Drawing.Color.Black;
            this.lblLeave.Location = new System.Drawing.Point(40, 37);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(476, 30);
            this.lblLeave.TabIndex = 1;
            this.lblLeave.Text = "Hi {{ user }}, you stayed for {{H,M}}, see you again!";
            this.lblLeave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblLeave.WordWrap = true;
            // 
            // btnAutoHide
            // 
            this.btnAutoHide.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAutoHide.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAutoHide.Location = new System.Drawing.Point(165, 77);
            this.btnAutoHide.Name = "btnAutoHide";
            this.btnAutoHide.Size = new System.Drawing.Size(228, 39);
            this.btnAutoHide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAutoHide.TabIndex = 3;
            this.btnAutoHide.Text = " Auto close in ({COUNTER}) seconds...";
            this.btnAutoHide.Click += new System.EventHandler(this.btnAutoHide_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoginUserAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 153);
            this.Controls.Add(this.lblAttendace);
            this.Controls.Add(this.btnAutoHide);
            this.Controls.Add(this.lblLeave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginUserAction";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblAttendace;
        private DevComponents.DotNetBar.LabelX lblLeave;
        private DevComponents.DotNetBar.ButtonX btnAutoHide;
        private System.Windows.Forms.Timer timer1;
    }
}