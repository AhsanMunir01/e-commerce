namespace WindowsFormsApp1
{
    partial class Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.storedetaillbl = new System.Windows.Forms.Label();
            this.storename = new System.Windows.Forms.Label();
            this.label1detail = new System.Windows.Forms.Label();
            this.referencenolbl = new System.Windows.Forms.Label();
            this.refnotxt = new MetroFramework.Controls.MetroTextBox();
            this.storenametxt = new MetroFramework.Controls.MetroTextBox();
            this.storedetailtxt = new MetroFramework.Controls.MetroTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancalbtn = new System.Windows.Forms.Button();
            this.oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.storedetaillbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // storedetaillbl
            // 
            this.storedetaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storedetaillbl.Location = new System.Drawing.Point(72, 2);
            this.storedetaillbl.Name = "storedetaillbl";
            this.storedetaillbl.Size = new System.Drawing.Size(110, 70);
            this.storedetaillbl.TabIndex = 10;
            this.storedetaillbl.Text = "Store Detail";
            this.storedetaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // storename
            // 
            this.storename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storename.Location = new System.Drawing.Point(12, 114);
            this.storename.Name = "storename";
            this.storename.Size = new System.Drawing.Size(177, 26);
            this.storename.TabIndex = 1;
            this.storename.Text = "Store Name :";
            // 
            // label1detail
            // 
            this.label1detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1detail.Location = new System.Drawing.Point(12, 173);
            this.label1detail.Name = "label1detail";
            this.label1detail.Size = new System.Drawing.Size(170, 26);
            this.label1detail.TabIndex = 2;
            this.label1detail.Text = "Store Detail :";
            // 
            // referencenolbl
            // 
            this.referencenolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referencenolbl.Location = new System.Drawing.Point(12, 62);
            this.referencenolbl.Name = "referencenolbl";
            this.referencenolbl.Size = new System.Drawing.Size(177, 26);
            this.referencenolbl.TabIndex = 3;
            this.referencenolbl.Text = "Reference No :";
            // 
            // refnotxt
            // 
            // 
            // 
            // 
            this.refnotxt.CustomButton.Image = null;
            this.refnotxt.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.refnotxt.CustomButton.Name = "";
            this.refnotxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.refnotxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.refnotxt.CustomButton.TabIndex = 1;
            this.refnotxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refnotxt.CustomButton.UseSelectable = true;
            this.refnotxt.CustomButton.Visible = false;
            this.refnotxt.Lines = new string[0];
            this.refnotxt.Location = new System.Drawing.Point(241, 62);
            this.refnotxt.MaxLength = 32767;
            this.refnotxt.Name = "refnotxt";
            this.refnotxt.PasswordChar = '\0';
            this.refnotxt.PromptText = "Reference No";
            this.refnotxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.refnotxt.SelectedText = "";
            this.refnotxt.SelectionLength = 0;
            this.refnotxt.SelectionStart = 0;
            this.refnotxt.ShortcutsEnabled = true;
            this.refnotxt.Size = new System.Drawing.Size(380, 23);
            this.refnotxt.TabIndex = 4;
            this.refnotxt.UseSelectable = true;
            this.refnotxt.WaterMark = "Reference No";
            this.refnotxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.refnotxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // storenametxt
            // 
            // 
            // 
            // 
            this.storenametxt.CustomButton.Image = null;
            this.storenametxt.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.storenametxt.CustomButton.Name = "";
            this.storenametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.storenametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.storenametxt.CustomButton.TabIndex = 1;
            this.storenametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.storenametxt.CustomButton.UseSelectable = true;
            this.storenametxt.CustomButton.Visible = false;
            this.storenametxt.Lines = new string[0];
            this.storenametxt.Location = new System.Drawing.Point(241, 114);
            this.storenametxt.MaxLength = 32767;
            this.storenametxt.Name = "storenametxt";
            this.storenametxt.PasswordChar = '\0';
            this.storenametxt.PromptText = "Store Name";
            this.storenametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.storenametxt.SelectedText = "";
            this.storenametxt.SelectionLength = 0;
            this.storenametxt.SelectionStart = 0;
            this.storenametxt.ShortcutsEnabled = true;
            this.storenametxt.Size = new System.Drawing.Size(380, 23);
            this.storenametxt.TabIndex = 5;
            this.storenametxt.UseSelectable = true;
            this.storenametxt.WaterMark = "Store Name";
            this.storenametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.storenametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // storedetailtxt
            // 
            // 
            // 
            // 
            this.storedetailtxt.CustomButton.Image = null;
            this.storedetailtxt.CustomButton.Location = new System.Drawing.Point(358, 1);
            this.storedetailtxt.CustomButton.Name = "";
            this.storedetailtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.storedetailtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.storedetailtxt.CustomButton.TabIndex = 1;
            this.storedetailtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.storedetailtxt.CustomButton.UseSelectable = true;
            this.storedetailtxt.CustomButton.Visible = false;
            this.storedetailtxt.Lines = new string[0];
            this.storedetailtxt.Location = new System.Drawing.Point(241, 173);
            this.storedetailtxt.MaxLength = 32767;
            this.storedetailtxt.Name = "storedetailtxt";
            this.storedetailtxt.PasswordChar = '\0';
            this.storedetailtxt.PromptText = "Store Detail";
            this.storedetailtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.storedetailtxt.SelectedText = "";
            this.storedetailtxt.SelectionLength = 0;
            this.storedetailtxt.SelectionStart = 0;
            this.storedetailtxt.ShortcutsEnabled = true;
            this.storedetailtxt.Size = new System.Drawing.Size(380, 23);
            this.storedetailtxt.TabIndex = 6;
            this.storedetailtxt.UseSelectable = true;
            this.storedetailtxt.WaterMark = "Store Detail";
            this.storedetailtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.storedetailtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // savebtn
            // 
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(402, 216);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(101, 33);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // cancalbtn
            // 
            this.cancalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancalbtn.Location = new System.Drawing.Point(520, 216);
            this.cancalbtn.Name = "cancalbtn";
            this.cancalbtn.Size = new System.Drawing.Size(101, 33);
            this.cancalbtn.TabIndex = 8;
            this.cancalbtn.Text = "cancel ";
            this.cancalbtn.UseVisualStyleBackColor = true;
            this.cancalbtn.Click += new System.EventHandler(this.cancalbtn_Click);
            // 
            // oracleCommandBuilder1
            // 
            this.oracleCommandBuilder1.CatalogLocation = System.Data.Common.CatalogLocation.End;
            this.oracleCommandBuilder1.CatalogSeparator = "@";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 367);
            this.Controls.Add(this.cancalbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.storedetailtxt);
            this.Controls.Add(this.storenametxt);
            this.Controls.Add(this.refnotxt);
            this.Controls.Add(this.referencenolbl);
            this.Controls.Add(this.label1detail);
            this.Controls.Add(this.storename);
            this.Controls.Add(this.panel1);
            this.Name = "Store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label storedetaillbl;
        private System.Windows.Forms.Label storename;
        private System.Windows.Forms.Label label1detail;
        private System.Windows.Forms.Label referencenolbl;
        private MetroFramework.Controls.MetroTextBox refnotxt;
        private MetroFramework.Controls.MetroTextBox storenametxt;
        private MetroFramework.Controls.MetroTextBox storedetailtxt;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancalbtn;
        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
    }
}