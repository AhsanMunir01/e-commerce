namespace WindowsFormsApp1
{
    partial class BrandModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandModule));
            this.brandmodulepanel = new System.Windows.Forms.Panel();
            this.closepic = new System.Windows.Forms.PictureBox();
            this.BrandModulelable = new System.Windows.Forms.Label();
            this.BrandName = new System.Windows.Forms.Label();
            this.textBoxbrandname = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.brandmodulepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.SuspendLayout();
            // 
            // brandmodulepanel
            // 
            this.brandmodulepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brandmodulepanel.Controls.Add(this.closepic);
            this.brandmodulepanel.Controls.Add(this.BrandModulelable);
            this.brandmodulepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandmodulepanel.Location = new System.Drawing.Point(0, 0);
            this.brandmodulepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandmodulepanel.Name = "brandmodulepanel";
            this.brandmodulepanel.Size = new System.Drawing.Size(656, 61);
            this.brandmodulepanel.TabIndex = 0;
            this.brandmodulepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.brandmodulepanel_Paint);
            // 
            // closepic
            // 
            this.closepic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closepic.BackgroundImage")));
            this.closepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closepic.Location = new System.Drawing.Point(609, 10);
            this.closepic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(38, 41);
            this.closepic.TabIndex = 1;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // BrandModulelable
            // 
            this.BrandModulelable.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandModulelable.Location = new System.Drawing.Point(9, 30);
            this.BrandModulelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BrandModulelable.Name = "BrandModulelable";
            this.BrandModulelable.Size = new System.Drawing.Size(120, 19);
            this.BrandModulelable.TabIndex = 0;
            this.BrandModulelable.Text = "Brand Module";
            this.BrandModulelable.Click += new System.EventHandler(this.BrandModulelable_Click);
            // 
            // BrandName
            // 
            this.BrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandName.Location = new System.Drawing.Point(11, 136);
            this.BrandName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(138, 33);
            this.BrandName.TabIndex = 1;
            this.BrandName.Text = "Brand Name :";
            this.BrandName.Click += new System.EventHandler(this.BrandName_Click);
            // 
            // textBoxbrandname
            // 
            this.textBoxbrandname.Location = new System.Drawing.Point(178, 141);
            this.textBoxbrandname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxbrandname.Name = "textBoxbrandname";
            this.textBoxbrandname.Size = new System.Drawing.Size(412, 20);
            this.textBoxbrandname.TabIndex = 2;
            this.textBoxbrandname.TextChanged += new System.EventHandler(this.textBoxbrandname_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(276, 183);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 27);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(392, 183);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(86, 27);
            this.Updatebtn.TabIndex = 4;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(503, 183);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 27);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // lblid
            // 
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(19, 213);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(71, 26);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // BrandModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 259);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBoxbrandname);
            this.Controls.Add(this.BrandName);
            this.Controls.Add(this.brandmodulepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BrandModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandModule";
            this.brandmodulepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel brandmodulepanel;
        public System.Windows.Forms.PictureBox closepic;
        public System.Windows.Forms.Label BrandModulelable;
        public System.Windows.Forms.Label BrandName;
        public System.Windows.Forms.TextBox textBoxbrandname;
        public System.Windows.Forms.Button Savebtn;
        public System.Windows.Forms.Button Updatebtn;
        public System.Windows.Forms.Button cancelbtn;
        public System.Windows.Forms.Label lblid;
    }
}