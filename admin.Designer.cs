namespace WindowsFormsApp1
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panelMain = new System.Windows.Forms.Panel();
            this.titalnamelbl = new System.Windows.Forms.Panel();
            this.titlelable = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panelsubsetting = new System.Windows.Forms.Panel();
            this.adminlable = new System.Windows.Forms.Label();
            this.profilepicbox = new System.Windows.Forms.PictureBox();
            this.setting = new System.Windows.Forms.Button();
            this.usernamelable = new System.Windows.Forms.Label();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.storebtn = new System.Windows.Forms.Button();
            this.userbtn = new System.Windows.Forms.Button();
            this.titalnamelbl.SuspendLayout();
            this.panelsubsetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicbox)).BeginInit();
            this.dashboardpanel.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(297, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 610);
            this.panelMain.TabIndex = 5;
            // 
            // titalnamelbl
            // 
            this.titalnamelbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titalnamelbl.Controls.Add(this.titlelable);
            this.titalnamelbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titalnamelbl.Location = new System.Drawing.Point(297, 0);
            this.titalnamelbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titalnamelbl.Name = "titalnamelbl";
            this.titalnamelbl.Size = new System.Drawing.Size(934, 62);
            this.titalnamelbl.TabIndex = 4;
            // 
            // titlelable
            // 
            this.titlelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.Location = new System.Drawing.Point(329, 12);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(349, 34);
            this.titlelable.TabIndex = 0;
            this.titlelable.Text = "Title Name";
            this.titlelable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutbtn.Location = new System.Drawing.Point(0, 617);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.logoutbtn.Size = new System.Drawing.Size(297, 55);
            this.logoutbtn.TabIndex = 21;
            this.logoutbtn.Text = " Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // panelsubsetting
            // 
            this.panelsubsetting.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelsubsetting.Controls.Add(this.storebtn);
            this.panelsubsetting.Controls.Add(this.userbtn);
            this.panelsubsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubsetting.Location = new System.Drawing.Point(0, 307);
            this.panelsubsetting.Margin = new System.Windows.Forms.Padding(4);
            this.panelsubsetting.Name = "panelsubsetting";
            this.panelsubsetting.Size = new System.Drawing.Size(297, 142);
            this.panelsubsetting.TabIndex = 20;
            // 
            // adminlable
            // 
            this.adminlable.AutoSize = true;
            this.adminlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlable.Location = new System.Drawing.Point(51, 158);
            this.adminlable.Name = "adminlable";
            this.adminlable.Size = new System.Drawing.Size(103, 20);
            this.adminlable.TabIndex = 1;
            this.adminlable.Text = "Administrator";
            // 
            // profilepicbox
            // 
            this.profilepicbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilepicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profilepicbox.Image = ((System.Drawing.Image)(resources.GetObject("profilepicbox.Image")));
            this.profilepicbox.Location = new System.Drawing.Point(55, 12);
            this.profilepicbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilepicbox.Name = "profilepicbox";
            this.profilepicbox.Size = new System.Drawing.Size(89, 88);
            this.profilepicbox.TabIndex = 0;
            this.profilepicbox.TabStop = false;
            // 
            // setting
            // 
            this.setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setting.Location = new System.Drawing.Point(0, 234);
            this.setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.setting.Size = new System.Drawing.Size(297, 73);
            this.setting.TabIndex = 19;
            this.setting.Text = "Setting";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // usernamelable
            // 
            this.usernamelable.AutoSize = true;
            this.usernamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelable.Location = new System.Drawing.Point(51, 126);
            this.usernamelable.Name = "usernamelable";
            this.usernamelable.Size = new System.Drawing.Size(83, 20);
            this.usernamelable.TabIndex = 2;
            this.usernamelable.Text = "Username";
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 181);
            this.dashboardbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dashboardbtn.Size = new System.Drawing.Size(297, 53);
            this.dashboardbtn.TabIndex = 1;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbtn.UseVisualStyleBackColor = true;
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.AutoScroll = true;
            this.dashboardpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardpanel.Controls.Add(this.logoutbtn);
            this.dashboardpanel.Controls.Add(this.panelsubsetting);
            this.dashboardpanel.Controls.Add(this.setting);
            this.dashboardpanel.Controls.Add(this.dashboardbtn);
            this.dashboardpanel.Controls.Add(this.panellogo);
            this.dashboardpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardpanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(297, 672);
            this.dashboardpanel.TabIndex = 3;
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.usernamelable);
            this.panellogo.Controls.Add(this.adminlable);
            this.panellogo.Controls.Add(this.profilepicbox);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(297, 181);
            this.panellogo.TabIndex = 0;
            // 
            // storebtn
            // 
            this.storebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.storebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storebtn.Image = ((System.Drawing.Image)(resources.GetObject("storebtn.Image")));
            this.storebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.storebtn.Location = new System.Drawing.Point(0, 74);
            this.storebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storebtn.Name = "storebtn";
            this.storebtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.storebtn.Size = new System.Drawing.Size(297, 68);
            this.storebtn.TabIndex = 21;
            this.storebtn.Text = "Store";
            this.storebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storebtn.UseVisualStyleBackColor = true;
            this.storebtn.Click += new System.EventHandler(this.storebtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbtn.Image = ((System.Drawing.Image)(resources.GetObject("userbtn.Image")));
            this.userbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userbtn.Location = new System.Drawing.Point(0, 0);
            this.userbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userbtn.Name = "userbtn";
            this.userbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.userbtn.Size = new System.Drawing.Size(297, 74);
            this.userbtn.TabIndex = 20;
            this.userbtn.Text = "User";
            this.userbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userbtn.UseVisualStyleBackColor = true;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 672);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.titalnamelbl);
            this.Controls.Add(this.dashboardpanel);
            this.Name = "admin";
            this.Text = "admin";
            this.titalnamelbl.ResumeLayout(false);
            this.panelsubsetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilepicbox)).EndInit();
            this.dashboardpanel.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel titalnamelbl;
        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel panelsubsetting;
        private System.Windows.Forms.Label adminlable;
        private System.Windows.Forms.PictureBox profilepicbox;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Panel dashboardpanel;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button storebtn;
        private System.Windows.Forms.Button userbtn;
        public System.Windows.Forms.Label usernamelable;
    }
}