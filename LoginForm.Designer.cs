namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.panellogo = new System.Windows.Forms.Panel();
            this.labelshopname = new System.Windows.Forms.Label();
            this.createaccountlbl = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernametxt = new MetroFramework.Controls.MetroTextBox();
            this.msglogin = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.passwordtxt = new MetroFramework.Controls.MetroTextBox();
            this.loginpicbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rolecombobox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // logopicbox
            // 
            this.logopicbox.Image = ((System.Drawing.Image)(resources.GetObject("logopicbox.Image")));
            this.logopicbox.Location = new System.Drawing.Point(14, 15);
            this.logopicbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logopicbox.Name = "logopicbox";
            this.logopicbox.Size = new System.Drawing.Size(89, 105);
            this.logopicbox.TabIndex = 10;
            this.logopicbox.TabStop = false;
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panellogo.Controls.Add(this.labelshopname);
            this.panellogo.Controls.Add(this.logopicbox);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(1186, 126);
            this.panellogo.TabIndex = 0;
            // 
            // labelshopname
            // 
            this.labelshopname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshopname.Location = new System.Drawing.Point(109, 36);
            this.labelshopname.Name = "labelshopname";
            this.labelshopname.Size = new System.Drawing.Size(474, 84);
            this.labelshopname.TabIndex = 11;
            this.labelshopname.Text = "Cheema Online Store";
            // 
            // createaccountlbl
            // 
            this.createaccountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccountlbl.LinkColor = System.Drawing.Color.Black;
            this.createaccountlbl.Location = new System.Drawing.Point(957, 674);
            this.createaccountlbl.Name = "createaccountlbl";
            this.createaccountlbl.Size = new System.Drawing.Size(217, 29);
            this.createaccountlbl.TabIndex = 10;
            this.createaccountlbl.TabStop = true;
            this.createaccountlbl.Text = "Click here to create account";
            this.createaccountlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createaccountlbl_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 136);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // usernametxt
            // 
            // 
            // 
            // 
            this.usernametxt.CustomButton.Image = null;
            this.usernametxt.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.usernametxt.CustomButton.Name = "";
            this.usernametxt.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.usernametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernametxt.CustomButton.TabIndex = 1;
            this.usernametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernametxt.CustomButton.UseSelectable = true;
            this.usernametxt.CustomButton.Visible = false;
            this.usernametxt.DisplayIcon = true;
            this.usernametxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usernametxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.usernametxt.Icon = ((System.Drawing.Image)(resources.GetObject("usernametxt.Icon")));
            this.usernametxt.Lines = new string[0];
            this.usernametxt.Location = new System.Drawing.Point(756, 340);
            this.usernametxt.MaxLength = 32767;
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.PromptText = "Username";
            this.usernametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametxt.SelectedText = "";
            this.usernametxt.SelectionLength = 0;
            this.usernametxt.SelectionStart = 0;
            this.usernametxt.ShortcutsEnabled = true;
            this.usernametxt.Size = new System.Drawing.Size(299, 43);
            this.usernametxt.TabIndex = 12;
            this.usernametxt.UseSelectable = true;
            this.usernametxt.WaterMark = "Username";
            this.usernametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Click += new System.EventHandler(this.usernametxt_Click);
            // 
            // msglogin
            // 
            this.msglogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msglogin.Location = new System.Drawing.Point(903, 223);
            this.msglogin.Name = "msglogin";
            this.msglogin.Size = new System.Drawing.Size(162, 86);
            this.msglogin.TabIndex = 13;
            this.msglogin.Text = "Login";
            // 
            // loginbtn
            // 
            this.loginbtn.AutoSize = true;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(814, 547);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(163, 36);
            this.loginbtn.TabIndex = 15;
            this.loginbtn.Text = "Login ";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click_1);
            // 
            // labelcopyright
            // 
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Location = new System.Drawing.Point(1090, 694);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(0, 20);
            this.labelcopyright.TabIndex = 16;
            // 
            // passwordtxt
            // 
            // 
            // 
            // 
            this.passwordtxt.CustomButton.Image = null;
            this.passwordtxt.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.passwordtxt.CustomButton.Name = "";
            this.passwordtxt.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.passwordtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordtxt.CustomButton.TabIndex = 1;
            this.passwordtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordtxt.CustomButton.UseSelectable = true;
            this.passwordtxt.CustomButton.Visible = false;
            this.passwordtxt.DisplayIcon = true;
            this.passwordtxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwordtxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.passwordtxt.Icon = ((System.Drawing.Image)(resources.GetObject("passwordtxt.Icon")));
            this.passwordtxt.Lines = new string[0];
            this.passwordtxt.Location = new System.Drawing.Point(756, 401);
            this.passwordtxt.MaxLength = 32767;
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.PromptText = "Password";
            this.passwordtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.SelectionLength = 0;
            this.passwordtxt.SelectionStart = 0;
            this.passwordtxt.ShortcutsEnabled = true;
            this.passwordtxt.Size = new System.Drawing.Size(299, 43);
            this.passwordtxt.TabIndex = 17;
            this.passwordtxt.UseSelectable = true;
            this.passwordtxt.WaterMark = "Password";
            this.passwordtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Click += new System.EventHandler(this.passwordtxt_Click);
            // 
            // loginpicbox
            // 
            this.loginpicbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginpicbox.BackgroundImage")));
            this.loginpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginpicbox.Location = new System.Drawing.Point(27, 173);
            this.loginpicbox.Name = "loginpicbox";
            this.loginpicbox.Size = new System.Drawing.Size(600, 475);
            this.loginpicbox.TabIndex = 18;
            this.loginpicbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "@Copy Right Ahsan";
            // 
            // rolecombobox
            // 
            this.rolecombobox.FormattingEnabled = true;
            this.rolecombobox.ItemHeight = 23;
            this.rolecombobox.Items.AddRange(new object[] {
            "customer",
            "admin",
            "manager",
            "cashier",
            "inventory staff"});
            this.rolecombobox.Location = new System.Drawing.Point(756, 474);
            this.rolecombobox.Name = "rolecombobox";
            this.rolecombobox.Size = new System.Drawing.Size(299, 29);
            this.rolecombobox.TabIndex = 20;
            this.rolecombobox.UseSelectable = true;
            this.rolecombobox.SelectedIndexChanged += new System.EventHandler(this.rolecombobox_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1186, 724);
            this.Controls.Add(this.rolecombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginpicbox);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.labelcopyright);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.msglogin);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createaccountlbl);
            this.Controls.Add(this.panellogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logopicbox;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Label labelshopname;
        private System.Windows.Forms.LinkLabel createaccountlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox usernametxt;
        private System.Windows.Forms.Label msglogin;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label labelcopyright;
        private MetroFramework.Controls.MetroTextBox passwordtxt;
        private System.Windows.Forms.PictureBox loginpicbox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox rolecombobox;
    }
}

