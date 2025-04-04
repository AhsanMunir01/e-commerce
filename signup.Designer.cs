namespace WindowsFormsApp1
{
    partial class signuppage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signuppage));
            this.logopicbox = new System.Windows.Forms.PictureBox();
            this.panellogo = new System.Windows.Forms.Panel();
            this.labelshopname = new System.Windows.Forms.Label();
            this.createaccountlbl = new System.Windows.Forms.LinkLabel();
            this.copyrighttxt = new System.Windows.Forms.Label();
            this.loginpicbox = new System.Windows.Forms.PictureBox();
            this.passwordtxt = new MetroFramework.Controls.MetroTextBox();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.msglogin = new System.Windows.Forms.Label();
            this.usernametxt = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emailtxt = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rolecobobox = new MetroFramework.Controls.MetroComboBox();
            this.signupbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).BeginInit();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logopicbox
            // 
            this.logopicbox.Image = ((System.Drawing.Image)(resources.GetObject("logopicbox.Image")));
            this.logopicbox.Location = new System.Drawing.Point(2, 3);
            this.logopicbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logopicbox.Name = "logopicbox";
            this.logopicbox.Size = new System.Drawing.Size(85, 79);
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
            this.panellogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(1186, 99);
            this.panellogo.TabIndex = 20;
            this.panellogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panellogo_Paint);
            // 
            // labelshopname
            // 
            this.labelshopname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelshopname.Location = new System.Drawing.Point(91, 19);
            this.labelshopname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelshopname.Name = "labelshopname";
            this.labelshopname.Size = new System.Drawing.Size(400, 63);
            this.labelshopname.TabIndex = 11;
            this.labelshopname.Text = "Cheema Online Store";
            this.labelshopname.Click += new System.EventHandler(this.labelshopname_Click);
            // 
            // createaccountlbl
            // 
            this.createaccountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccountlbl.LinkColor = System.Drawing.Color.Black;
            this.createaccountlbl.Location = new System.Drawing.Point(907, 679);
            this.createaccountlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createaccountlbl.Name = "createaccountlbl";
            this.createaccountlbl.Size = new System.Drawing.Size(252, 24);
            this.createaccountlbl.TabIndex = 12;
            this.createaccountlbl.TabStop = true;
            this.createaccountlbl.Text = "Already have an account";
            this.createaccountlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createaccountlbl_LinkClicked_1);
            // 
            // copyrighttxt
            // 
            this.copyrighttxt.AutoSize = true;
            this.copyrighttxt.Location = new System.Drawing.Point(-1, 702);
            this.copyrighttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyrighttxt.Name = "copyrighttxt";
            this.copyrighttxt.Size = new System.Drawing.Size(103, 13);
            this.copyrighttxt.TabIndex = 29;
            this.copyrighttxt.Text = "@Copy Right Ahsan";
            // 
            // loginpicbox
            // 
            this.loginpicbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginpicbox.BackgroundImage")));
            this.loginpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginpicbox.Location = new System.Drawing.Point(36, 176);
            this.loginpicbox.Margin = new System.Windows.Forms.Padding(2);
            this.loginpicbox.Name = "loginpicbox";
            this.loginpicbox.Size = new System.Drawing.Size(605, 481);
            this.loginpicbox.TabIndex = 28;
            this.loginpicbox.TabStop = false;
            // 
            // passwordtxt
            // 
            // 
            // 
            // 
            this.passwordtxt.CustomButton.Image = null;
            this.passwordtxt.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.passwordtxt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtxt.CustomButton.Name = "";
            this.passwordtxt.CustomButton.Size = new System.Drawing.Size(27, 27);
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
            this.passwordtxt.Location = new System.Drawing.Point(774, 392);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2);
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
            this.passwordtxt.Size = new System.Drawing.Size(224, 32);
            this.passwordtxt.TabIndex = 27;
            this.passwordtxt.UseSelectable = true;
            this.passwordtxt.WaterMark = "Password";
            this.passwordtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Click += new System.EventHandler(this.passwordtxt_Click);
            // 
            // labelcopyright
            // 
            this.labelcopyright.AutoSize = true;
            this.labelcopyright.Location = new System.Drawing.Point(1126, 562);
            this.labelcopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(0, 13);
            this.labelcopyright.TabIndex = 26;
            // 
            // msglogin
            // 
            this.msglogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msglogin.Location = new System.Drawing.Point(839, 176);
            this.msglogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msglogin.Name = "msglogin";
            this.msglogin.Size = new System.Drawing.Size(252, 67);
            this.msglogin.TabIndex = 24;
            this.msglogin.Text = "Sign Up";
            // 
            // usernametxt
            // 
            // 
            // 
            // 
            this.usernametxt.CustomButton.Image = null;
            this.usernametxt.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.usernametxt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.usernametxt.CustomButton.Name = "";
            this.usernametxt.CustomButton.Size = new System.Drawing.Size(27, 27);
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
            this.usernametxt.Location = new System.Drawing.Point(776, 284);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2);
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
            this.usernametxt.Size = new System.Drawing.Size(224, 32);
            this.usernametxt.TabIndex = 23;
            this.usernametxt.UseSelectable = true;
            this.usernametxt.WaterMark = "Username";
            this.usernametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Click += new System.EventHandler(this.usernametxt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(747, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 84);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Emailtxt
            // 
            // 
            // 
            // 
            this.Emailtxt.CustomButton.Image = null;
            this.Emailtxt.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.Emailtxt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.Emailtxt.CustomButton.Name = "";
            this.Emailtxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Emailtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Emailtxt.CustomButton.TabIndex = 1;
            this.Emailtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Emailtxt.CustomButton.UseSelectable = true;
            this.Emailtxt.CustomButton.Visible = false;
            this.Emailtxt.DisplayIcon = true;
            this.Emailtxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Emailtxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.Emailtxt.Icon = ((System.Drawing.Image)(resources.GetObject("Emailtxt.Icon")));
            this.Emailtxt.Lines = new string[0];
            this.Emailtxt.Location = new System.Drawing.Point(776, 341);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Emailtxt.MaxLength = 32767;
            this.Emailtxt.Multiline = true;
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.PasswordChar = '\0';
            this.Emailtxt.PromptText = "E-mail";
            this.Emailtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Emailtxt.SelectedText = "";
            this.Emailtxt.SelectionLength = 0;
            this.Emailtxt.SelectionStart = 0;
            this.Emailtxt.ShortcutsEnabled = true;
            this.Emailtxt.Size = new System.Drawing.Size(224, 32);
            this.Emailtxt.TabIndex = 30;
            this.Emailtxt.UseSelectable = true;
            this.Emailtxt.WaterMark = "E-mail";
            this.Emailtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Emailtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 502);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // rolecobobox
            // 
            this.rolecobobox.FormattingEnabled = true;
            this.rolecobobox.ItemHeight = 23;
            this.rolecobobox.Items.AddRange(new object[] {
            "customer",
            "admin",
            "manager",
            "cashier",
            "inventory staff"});
            this.rolecobobox.Location = new System.Drawing.Point(775, 446);
            this.rolecobobox.Name = "rolecobobox";
            this.rolecobobox.Size = new System.Drawing.Size(224, 29);
            this.rolecobobox.TabIndex = 35;
            this.rolecobobox.UseSelectable = true;
            this.rolecobobox.SelectedIndexChanged += new System.EventHandler(this.rolecobobox_SelectedIndexChanged);
            // 
            // signupbtn
            // 
            this.signupbtn.AutoSize = true;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.Location = new System.Drawing.Point(803, 572);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(2);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(122, 36);
            this.signupbtn.TabIndex = 36;
            this.signupbtn.Text = "Signup";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click_1);
            // 
            // signuppage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1186, 724);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.rolecobobox);
            this.Controls.Add(this.createaccountlbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.panellogo);
            this.Controls.Add(this.copyrighttxt);
            this.Controls.Add(this.loginpicbox);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.labelcopyright);
            this.Controls.Add(this.msglogin);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signuppage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sign up";
            this.Load += new System.EventHandler(this.signuppage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logopicbox)).EndInit();
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logopicbox;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Label labelshopname;
        private System.Windows.Forms.Label copyrighttxt;
        private System.Windows.Forms.PictureBox loginpicbox;
        private MetroFramework.Controls.MetroTextBox passwordtxt;
        private System.Windows.Forms.Label labelcopyright;
        private System.Windows.Forms.Label msglogin;
        private MetroFramework.Controls.MetroTextBox usernametxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel createaccountlbl;
        private MetroFramework.Controls.MetroTextBox Emailtxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroComboBox rolecobobox;
        private System.Windows.Forms.Button signupbtn;
    }
}