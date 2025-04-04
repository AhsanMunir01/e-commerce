namespace WindowsFormsApp1
{
    partial class suppliermodule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliermodule));
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.textBoxsuppliername = new System.Windows.Forms.TextBox();
            this.supplierName = new System.Windows.Forms.Label();
            this.supplierModulelable = new System.Windows.Forms.Label();
            this.categorymodulepanel = new System.Windows.Forms.Panel();
            this.closepic = new System.Windows.Forms.PictureBox();
            this.Addresssupplier = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.faxlbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.supplieraddresstxt = new System.Windows.Forms.TextBox();
            this.contactpersontxt = new System.Windows.Forms.TextBox();
            this.phonenumbertxt = new System.Windows.Forms.TextBox();
            this.faxnumbertxt = new System.Windows.Forms.TextBox();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.Contactpersonlbl = new System.Windows.Forms.Label();
            this.categorymodulepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(665, 396);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 27);
            this.cancelbtn.TabIndex = 36;
            this.cancelbtn.Text = " Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(554, 396);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(86, 27);
            this.Updatebtn.TabIndex = 35;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(438, 396);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 27);
            this.Savebtn.TabIndex = 34;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // textBoxsuppliername
            // 
            this.textBoxsuppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsuppliername.Location = new System.Drawing.Point(191, 101);
            this.textBoxsuppliername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsuppliername.Name = "textBoxsuppliername";
            this.textBoxsuppliername.Size = new System.Drawing.Size(563, 26);
            this.textBoxsuppliername.TabIndex = 33;
            // 
            // supplierName
            // 
            this.supplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierName.Location = new System.Drawing.Point(10, 101);
            this.supplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(150, 26);
            this.supplierName.TabIndex = 32;
            this.supplierName.Text = "Supplier Name : ";
            // 
            // supplierModulelable
            // 
            this.supplierModulelable.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierModulelable.Location = new System.Drawing.Point(9, 7);
            this.supplierModulelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierModulelable.Name = "supplierModulelable";
            this.supplierModulelable.Size = new System.Drawing.Size(213, 37);
            this.supplierModulelable.TabIndex = 0;
            this.supplierModulelable.Text = "Supplier Module";
            // 
            // categorymodulepanel
            // 
            this.categorymodulepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categorymodulepanel.Controls.Add(this.closepic);
            this.categorymodulepanel.Controls.Add(this.supplierModulelable);
            this.categorymodulepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorymodulepanel.Location = new System.Drawing.Point(0, 0);
            this.categorymodulepanel.Margin = new System.Windows.Forms.Padding(2);
            this.categorymodulepanel.Name = "categorymodulepanel";
            this.categorymodulepanel.Size = new System.Drawing.Size(806, 61);
            this.categorymodulepanel.TabIndex = 31;
            // 
            // closepic
            // 
            this.closepic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closepic.BackgroundImage")));
            this.closepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closepic.Location = new System.Drawing.Point(755, 2);
            this.closepic.Margin = new System.Windows.Forms.Padding(2);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(49, 59);
            this.closepic.TabIndex = 1;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // Addresssupplier
            // 
            this.Addresssupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresssupplier.Location = new System.Drawing.Point(10, 152);
            this.Addresssupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addresssupplier.Name = "Addresssupplier";
            this.Addresssupplier.Size = new System.Drawing.Size(150, 26);
            this.Addresssupplier.TabIndex = 37;
            this.Addresssupplier.Text = "Address : ";
            // 
            // phonelbl
            // 
            this.phonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.Location = new System.Drawing.Point(11, 258);
            this.phonelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(150, 26);
            this.phonelbl.TabIndex = 39;
            this.phonelbl.Text = "Phhone No : ";
            // 
            // faxlbl
            // 
            this.faxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxlbl.Location = new System.Drawing.Point(455, 258);
            this.faxlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.faxlbl.Name = "faxlbl";
            this.faxlbl.Size = new System.Drawing.Size(91, 26);
            this.faxlbl.TabIndex = 40;
            this.faxlbl.Text = "Fax No : ";
            // 
            // emaillbl
            // 
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(10, 313);
            this.emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(150, 26);
            this.emaillbl.TabIndex = 41;
            this.emaillbl.Text = "E-mail";
            // 
            // supplieraddresstxt
            // 
            this.supplieraddresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplieraddresstxt.Location = new System.Drawing.Point(191, 152);
            this.supplieraddresstxt.Margin = new System.Windows.Forms.Padding(2);
            this.supplieraddresstxt.Name = "supplieraddresstxt";
            this.supplieraddresstxt.Size = new System.Drawing.Size(563, 26);
            this.supplieraddresstxt.TabIndex = 42;
            this.supplieraddresstxt.TextChanged += new System.EventHandler(this.supplieraddresstxt_TextChanged);
            // 
            // contactpersontxt
            // 
            this.contactpersontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactpersontxt.Location = new System.Drawing.Point(191, 211);
            this.contactpersontxt.Margin = new System.Windows.Forms.Padding(2);
            this.contactpersontxt.Name = "contactpersontxt";
            this.contactpersontxt.Size = new System.Drawing.Size(563, 26);
            this.contactpersontxt.TabIndex = 43;
            this.contactpersontxt.TextChanged += new System.EventHandler(this.contactpersontxt_TextChanged);
            // 
            // phonenumbertxt
            // 
            this.phonenumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumbertxt.Location = new System.Drawing.Point(191, 258);
            this.phonenumbertxt.Margin = new System.Windows.Forms.Padding(2);
            this.phonenumbertxt.Name = "phonenumbertxt";
            this.phonenumbertxt.Size = new System.Drawing.Size(192, 26);
            this.phonenumbertxt.TabIndex = 44;
            this.phonenumbertxt.TextChanged += new System.EventHandler(this.phonenumbertxt_TextChanged);
            // 
            // faxnumbertxt
            // 
            this.faxnumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxnumbertxt.Location = new System.Drawing.Point(583, 258);
            this.faxnumbertxt.Margin = new System.Windows.Forms.Padding(2);
            this.faxnumbertxt.Name = "faxnumbertxt";
            this.faxnumbertxt.Size = new System.Drawing.Size(171, 26);
            this.faxnumbertxt.TabIndex = 45;
            this.faxnumbertxt.TextChanged += new System.EventHandler(this.faxnumbertxt_TextChanged);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxtbox.Location = new System.Drawing.Point(191, 313);
            this.emailtxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(563, 26);
            this.emailtxtbox.TabIndex = 46;
            this.emailtxtbox.TextChanged += new System.EventHandler(this.emailtxtbox_TextChanged);
            // 
            // Contactpersonlbl
            // 
            this.Contactpersonlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactpersonlbl.Location = new System.Drawing.Point(10, 211);
            this.Contactpersonlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Contactpersonlbl.Name = "Contactpersonlbl";
            this.Contactpersonlbl.Size = new System.Drawing.Size(150, 26);
            this.Contactpersonlbl.TabIndex = 47;
            this.Contactpersonlbl.Text = "Contact Peson : ";
            // 
            // suppliermodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.Contactpersonlbl);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.faxnumbertxt);
            this.Controls.Add(this.phonenumbertxt);
            this.Controls.Add(this.contactpersontxt);
            this.Controls.Add(this.supplieraddresstxt);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.faxlbl);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.Addresssupplier);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBoxsuppliername);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.categorymodulepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "suppliermodule";
            this.Text = "suppliermodule";
            this.Load += new System.EventHandler(this.suppliermodule_Load);
            this.categorymodulepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label supplierName;
        private System.Windows.Forms.Label supplierModulelable;
        private System.Windows.Forms.Panel categorymodulepanel;
        private System.Windows.Forms.PictureBox closepic;
        private System.Windows.Forms.Label Addresssupplier;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label faxlbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label Contactpersonlbl;
        public System.Windows.Forms.TextBox textBoxsuppliername;
        public System.Windows.Forms.TextBox supplieraddresstxt;
        public System.Windows.Forms.TextBox contactpersontxt;
        public System.Windows.Forms.TextBox phonenumbertxt;
        public System.Windows.Forms.TextBox faxnumbertxt;
        public System.Windows.Forms.TextBox emailtxtbox;
        public System.Windows.Forms.Button cancelbtn;
        public System.Windows.Forms.Button Updatebtn;
        public System.Windows.Forms.Button Savebtn;
    }
}