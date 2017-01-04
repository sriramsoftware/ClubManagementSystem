namespace ClubManagement.UI.OtherForms
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
            this.btnfrmLoginUserActionPause = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblfrmLoginUserAds = new DevComponents.DotNetBar.LabelX();
            this.groupPnlfrmLoginUserActionDetails = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblfrmLoginUserActionCal = new DevComponents.DotNetBar.LabelX();
            this.btnfrmUserLoginReportChart = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel4.SuspendLayout();
            this.groupPnlfrmLoginUserActionDetails.SuspendLayout();
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
            this.lblAttendace.Location = new System.Drawing.Point(111, 131);
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
            this.lblLeave.Location = new System.Drawing.Point(53, 131);
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
            this.btnAutoHide.Location = new System.Drawing.Point(81, 175);
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
            // btnfrmLoginUserActionPause
            // 
            this.btnfrmLoginUserActionPause.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnfrmLoginUserActionPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnfrmLoginUserActionPause.Location = new System.Drawing.Point(347, 175);
            this.btnfrmLoginUserActionPause.Name = "btnfrmLoginUserActionPause";
            this.btnfrmLoginUserActionPause.Size = new System.Drawing.Size(132, 39);
            this.btnfrmLoginUserActionPause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnfrmLoginUserActionPause.TabIndex = 4;
            this.btnfrmLoginUserActionPause.Text = "Pause && Show Details";
            this.btnfrmLoginUserActionPause.Click += new System.EventHandler(this.btnfrmLoginUserActionPause_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPanel4.Controls.Add(this.lblfrmLoginUserAds);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(65, 12);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(426, 85);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 7;
            this.groupPanel4.Text = "Advertisments: ";
            // 
            // lblfrmLoginUserAds
            // 
            // 
            // 
            // 
            this.lblfrmLoginUserAds.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfrmLoginUserAds.Location = new System.Drawing.Point(4, 2);
            this.lblfrmLoginUserAds.Name = "lblfrmLoginUserAds";
            this.lblfrmLoginUserAds.Size = new System.Drawing.Size(407, 56);
            this.lblfrmLoginUserAds.TabIndex = 0;
            this.lblfrmLoginUserAds.Text = "<b>Ads Goes Here</b>";
            this.lblfrmLoginUserAds.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPnlfrmLoginUserActionDetails
            // 
            this.groupPnlfrmLoginUserActionDetails.BackColor = System.Drawing.Color.Transparent;
            this.groupPnlfrmLoginUserActionDetails.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPnlfrmLoginUserActionDetails.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.groupPnlfrmLoginUserActionDetails.Controls.Add(this.lblfrmLoginUserActionCal);
            this.groupPnlfrmLoginUserActionDetails.Controls.Add(this.btnfrmUserLoginReportChart);
            this.groupPnlfrmLoginUserActionDetails.Controls.Add(this.labelX1);
            this.groupPnlfrmLoginUserActionDetails.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPnlfrmLoginUserActionDetails.Location = new System.Drawing.Point(81, 239);
            this.groupPnlfrmLoginUserActionDetails.Name = "groupPnlfrmLoginUserActionDetails";
            this.groupPnlfrmLoginUserActionDetails.Size = new System.Drawing.Size(398, 101);
            // 
            // 
            // 
            this.groupPnlfrmLoginUserActionDetails.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPnlfrmLoginUserActionDetails.Style.BackColorGradientAngle = 90;
            this.groupPnlfrmLoginUserActionDetails.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderBottomWidth = 1;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderLeftWidth = 1;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderRightWidth = 1;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPnlfrmLoginUserActionDetails.Style.BorderTopWidth = 1;
            this.groupPnlfrmLoginUserActionDetails.Style.CornerDiameter = 4;
            this.groupPnlfrmLoginUserActionDetails.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPnlfrmLoginUserActionDetails.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPnlfrmLoginUserActionDetails.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPnlfrmLoginUserActionDetails.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPnlfrmLoginUserActionDetails.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPnlfrmLoginUserActionDetails.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPnlfrmLoginUserActionDetails.TabIndex = 8;
            this.groupPnlfrmLoginUserActionDetails.Text = "Details";
            this.groupPnlfrmLoginUserActionDetails.Visible = false;
            // 
            // lblfrmLoginUserActionCal
            // 
            // 
            // 
            // 
            this.lblfrmLoginUserActionCal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfrmLoginUserActionCal.Location = new System.Drawing.Point(69, 39);
            this.lblfrmLoginUserActionCal.Name = "lblfrmLoginUserActionCal";
            this.lblfrmLoginUserActionCal.Size = new System.Drawing.Size(75, 23);
            this.lblfrmLoginUserActionCal.TabIndex = 2;
            this.lblfrmLoginUserActionCal.Text = "... Cal";
            // 
            // btnfrmUserLoginReportChart
            // 
            this.btnfrmUserLoginReportChart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnfrmUserLoginReportChart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnfrmUserLoginReportChart.Location = new System.Drawing.Point(250, 15);
            this.btnfrmUserLoginReportChart.Name = "btnfrmUserLoginReportChart";
            this.btnfrmUserLoginReportChart.Size = new System.Drawing.Size(95, 47);
            this.btnfrmUserLoginReportChart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnfrmUserLoginReportChart.TabIndex = 1;
            this.btnfrmUserLoginReportChart.Text = "View My Report";
            this.btnfrmUserLoginReportChart.Click += new System.EventHandler(this.btnfrmUserLoginReportChart_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(38, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(127, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Calories Burned Today:";
            // 
            // frmLoginUserAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 380);
            this.Controls.Add(this.groupPnlfrmLoginUserActionDetails);
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.btnfrmLoginUserActionPause);
            this.Controls.Add(this.lblAttendace);
            this.Controls.Add(this.btnAutoHide);
            this.Controls.Add(this.lblLeave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginUserAction";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAction";
            this.Load += new System.EventHandler(this.frmLoginUserAction_Load);
            this.groupPanel4.ResumeLayout(false);
            this.groupPnlfrmLoginUserActionDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblAttendace;
        private DevComponents.DotNetBar.LabelX lblLeave;
        private DevComponents.DotNetBar.ButtonX btnAutoHide;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.ButtonX btnfrmLoginUserActionPause;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.LabelX lblfrmLoginUserAds;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPnlfrmLoginUserActionDetails;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnfrmUserLoginReportChart;
        private DevComponents.DotNetBar.LabelX lblfrmLoginUserActionCal;
    }
}