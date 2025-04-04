namespace WindowsFormsApp1
{
    partial class properties
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
            this.fullnamelbl = new System.Windows.Forms.Label();
            this.rolelbl = new System.Windows.Forms.Label();
            this.activatelbl = new System.Windows.Forms.Label();
            this.fullnametxt = new MetroFramework.Controls.MetroTextBox();
            this.activatestatus = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.cancalbtn = new System.Windows.Forms.Button();
            this.applybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullnamelbl
            // 
            this.fullnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnamelbl.Location = new System.Drawing.Point(12, 19);
            this.fullnamelbl.Name = "fullnamelbl";
            this.fullnamelbl.Size = new System.Drawing.Size(122, 23);
            this.fullnamelbl.TabIndex = 0;
            this.fullnamelbl.Text = "Full Name : ";
            // 
            // rolelbl
            // 
            this.rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolelbl.Location = new System.Drawing.Point(12, 72);
            this.rolelbl.Name = "rolelbl";
            this.rolelbl.Size = new System.Drawing.Size(122, 23);
            this.rolelbl.TabIndex = 1;
            this.rolelbl.Text = "Role : ";
            // 
            // activatelbl
            // 
            this.activatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activatelbl.Location = new System.Drawing.Point(12, 127);
            this.activatelbl.Name = "activatelbl";
            this.activatelbl.Size = new System.Drawing.Size(122, 23);
            this.activatelbl.TabIndex = 2;
            this.activatelbl.Text = "Activate :";
            // 
            // fullnametxt
            // 
            // 
            // 
            // 
            this.fullnametxt.CustomButton.Image = null;
            this.fullnametxt.CustomButton.Location = new System.Drawing.Point(314, 1);
            this.fullnametxt.CustomButton.Name = "";
            this.fullnametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fullnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fullnametxt.CustomButton.TabIndex = 1;
            this.fullnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fullnametxt.CustomButton.UseSelectable = true;
            this.fullnametxt.CustomButton.Visible = false;
            this.fullnametxt.Lines = new string[0];
            this.fullnametxt.Location = new System.Drawing.Point(140, 19);
            this.fullnametxt.MaxLength = 32767;
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.PasswordChar = '\0';
            this.fullnametxt.PromptText = "Full Name";
            this.fullnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnametxt.SelectedText = "";
            this.fullnametxt.SelectionLength = 0;
            this.fullnametxt.SelectionStart = 0;
            this.fullnametxt.ShortcutsEnabled = true;
            this.fullnametxt.Size = new System.Drawing.Size(336, 23);
            this.fullnametxt.TabIndex = 3;
            this.fullnametxt.UseSelectable = true;
            this.fullnametxt.WaterMark = "Full Name";
            this.fullnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fullnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // activatestatus
            // 
            this.activatestatus.FormattingEnabled = true;
            this.activatestatus.Items.AddRange(new object[] {
            "True ",
            "False"});
            this.activatestatus.Location = new System.Drawing.Point(140, 136);
            this.activatestatus.Name = "activatestatus";
            this.activatestatus.Size = new System.Drawing.Size(336, 24);
            this.activatestatus.TabIndex = 5;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Cashier",
            "User ",
            "Manager"});
            this.comboBoxRole.Location = new System.Drawing.Point(140, 83);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(336, 24);
            this.comboBoxRole.TabIndex = 6;
            // 
            // cancalbtn
            // 
            this.cancalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancalbtn.Location = new System.Drawing.Point(409, 315);
            this.cancalbtn.Name = "cancalbtn";
            this.cancalbtn.Size = new System.Drawing.Size(101, 33);
            this.cancalbtn.TabIndex = 10;
            this.cancalbtn.Text = "cancel ";
            this.cancalbtn.UseVisualStyleBackColor = true;
            this.cancalbtn.Click += new System.EventHandler(this.cancalbtn_Click);
            // 
            // applybtn
            // 
            this.applybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applybtn.Location = new System.Drawing.Point(291, 315);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(101, 33);
            this.applybtn.TabIndex = 9;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = true;
            // 
            // properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 360);
            this.Controls.Add(this.cancalbtn);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.activatestatus);
            this.Controls.Add(this.fullnametxt);
            this.Controls.Add(this.activatelbl);
            this.Controls.Add(this.rolelbl);
            this.Controls.Add(this.fullnamelbl);
            this.Name = "properties";
            this.Text = "properties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fullnamelbl;
        private System.Windows.Forms.Label rolelbl;
        private System.Windows.Forms.Label activatelbl;
        private MetroFramework.Controls.MetroTextBox fullnametxt;
        private System.Windows.Forms.ComboBox activatestatus;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button cancalbtn;
        private System.Windows.Forms.Button applybtn;
    }
}