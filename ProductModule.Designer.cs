namespace WindowsFormsApp1
{
    partial class ProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            this.closepic = new System.Windows.Forms.PictureBox();
            this.categorymodulepanel = new System.Windows.Forms.Panel();
            this.productModulelable = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Descriptionlable = new System.Windows.Forms.Label();
            this.productnamelable = new System.Windows.Forms.Label();
            this.pricelable = new System.Windows.Forms.Label();
            this.categorylable = new System.Windows.Forms.Label();
            this.productnametxtbox = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.categorycombobox = new System.Windows.Forms.ComboBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.Qtylable = new System.Windows.Forms.Label();
            this.Qtybox = new System.Windows.Forms.NumericUpDown();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.updatedatelbl = new System.Windows.Forms.Label();
            this.createdatelbl = new System.Windows.Forms.Label();
            this.createbydatepicler = new System.Windows.Forms.DateTimePicker();
            this.updatedatepicker = new System.Windows.Forms.DateTimePicker();
            this.brandlbl = new System.Windows.Forms.Label();
            this.brandcombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.categorymodulepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Qtybox)).BeginInit();
            this.SuspendLayout();
            // 
            // closepic
            // 
            this.closepic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closepic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closepic.BackgroundImage")));
            this.closepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closepic.Location = new System.Drawing.Point(742, 0);
            this.closepic.Margin = new System.Windows.Forms.Padding(2);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(50, 57);
            this.closepic.TabIndex = 1;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // categorymodulepanel
            // 
            this.categorymodulepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categorymodulepanel.Controls.Add(this.closepic);
            this.categorymodulepanel.Controls.Add(this.productModulelable);
            this.categorymodulepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorymodulepanel.Location = new System.Drawing.Point(0, 0);
            this.categorymodulepanel.Margin = new System.Windows.Forms.Padding(2);
            this.categorymodulepanel.Name = "categorymodulepanel";
            this.categorymodulepanel.Size = new System.Drawing.Size(794, 61);
            this.categorymodulepanel.TabIndex = 12;
            // 
            // productModulelable
            // 
            this.productModulelable.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModulelable.Location = new System.Drawing.Point(9, 7);
            this.productModulelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productModulelable.Name = "productModulelable";
            this.productModulelable.Size = new System.Drawing.Size(250, 37);
            this.productModulelable.TabIndex = 0;
            this.productModulelable.Text = "Product Module";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(656, 399);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 27);
            this.cancelbtn.TabIndex = 17;
            this.cancelbtn.Text = " Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(545, 399);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(86, 27);
            this.Updatebtn.TabIndex = 16;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(429, 399);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 27);
            this.Savebtn.TabIndex = 15;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Descriptionlable
            // 
            this.Descriptionlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlable.Location = new System.Drawing.Point(23, 145);
            this.Descriptionlable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Descriptionlable.Name = "Descriptionlable";
            this.Descriptionlable.Size = new System.Drawing.Size(123, 19);
            this.Descriptionlable.TabIndex = 18;
            this.Descriptionlable.Text = "Description : ";
            // 
            // productnamelable
            // 
            this.productnamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamelable.Location = new System.Drawing.Point(333, 88);
            this.productnamelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productnamelable.Name = "productnamelable";
            this.productnamelable.Size = new System.Drawing.Size(163, 31);
            this.productnamelable.TabIndex = 19;
            this.productnamelable.Text = "Product Name : ";
            // 
            // pricelable
            // 
            this.pricelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelable.Location = new System.Drawing.Point(23, 295);
            this.pricelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricelable.Name = "pricelable";
            this.pricelable.Size = new System.Drawing.Size(123, 31);
            this.pricelable.TabIndex = 21;
            this.pricelable.Text = "Price : ";
            // 
            // categorylable
            // 
            this.categorylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylable.Location = new System.Drawing.Point(23, 226);
            this.categorylable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categorylable.Name = "categorylable";
            this.categorylable.Size = new System.Drawing.Size(123, 33);
            this.categorylable.TabIndex = 21;
            this.categorylable.Text = "Category :";
            // 
            // productnametxtbox
            // 
            this.productnametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnametxtbox.Location = new System.Drawing.Point(522, 83);
            this.productnametxtbox.Margin = new System.Windows.Forms.Padding(2);
            this.productnametxtbox.Name = "productnametxtbox";
            this.productnametxtbox.Size = new System.Drawing.Size(223, 26);
            this.productnametxtbox.TabIndex = 22;
            this.productnametxtbox.TextChanged += new System.EventHandler(this.productnametxtbox_TextChanged);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(141, 145);
            this.description.Margin = new System.Windows.Forms.Padding(2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(604, 26);
            this.description.TabIndex = 23;
            // 
            // categorycombobox
            // 
            this.categorycombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombobox.FormattingEnabled = true;
            this.categorycombobox.Location = new System.Drawing.Point(132, 231);
            this.categorycombobox.Margin = new System.Windows.Forms.Padding(2);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.Size = new System.Drawing.Size(604, 28);
            this.categorycombobox.TabIndex = 28;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextbox.Location = new System.Drawing.Point(132, 300);
            this.pricetextbox.Margin = new System.Windows.Forms.Padding(2);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(158, 26);
            this.pricetextbox.TabIndex = 26;
            // 
            // Qtylable
            // 
            this.Qtylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtylable.Location = new System.Drawing.Point(487, 300);
            this.Qtylable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Qtylable.Name = "Qtylable";
            this.Qtylable.Size = new System.Drawing.Size(123, 26);
            this.Qtylable.TabIndex = 29;
            this.Qtylable.Text = "Qty : ";
            // 
            // Qtybox
            // 
            this.Qtybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtybox.Location = new System.Drawing.Point(626, 300);
            this.Qtybox.Margin = new System.Windows.Forms.Padding(2);
            this.Qtybox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Qtybox.Name = "Qtybox";
            this.Qtybox.Size = new System.Drawing.Size(110, 26);
            this.Qtybox.TabIndex = 30;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // updatedatelbl
            // 
            this.updatedatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedatelbl.Location = new System.Drawing.Point(409, 348);
            this.updatedatelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updatedatelbl.Name = "updatedatelbl";
            this.updatedatelbl.Size = new System.Drawing.Size(123, 31);
            this.updatedatelbl.TabIndex = 31;
            this.updatedatelbl.Text = "Update Date :";
            // 
            // createdatelbl
            // 
            this.createdatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdatelbl.Location = new System.Drawing.Point(32, 348);
            this.createdatelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createdatelbl.Name = "createdatelbl";
            this.createdatelbl.Size = new System.Drawing.Size(123, 31);
            this.createdatelbl.TabIndex = 32;
            this.createdatelbl.Text = "Create Date :";
            // 
            // createbydatepicler
            // 
            this.createbydatepicler.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbydatepicler.Location = new System.Drawing.Point(150, 350);
            this.createbydatepicler.Name = "createbydatepicler";
            this.createbydatepicler.Size = new System.Drawing.Size(200, 20);
            this.createbydatepicler.TabIndex = 33;
            // 
            // updatedatepicker
            // 
            this.updatedatepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedatepicker.Location = new System.Drawing.Point(537, 350);
            this.updatedatepicker.Name = "updatedatepicker";
            this.updatedatepicker.Size = new System.Drawing.Size(200, 20);
            this.updatedatepicker.TabIndex = 34;
            // 
            // brandlbl
            // 
            this.brandlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandlbl.Location = new System.Drawing.Point(23, 182);
            this.brandlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandlbl.Name = "brandlbl";
            this.brandlbl.Size = new System.Drawing.Size(123, 33);
            this.brandlbl.TabIndex = 35;
            this.brandlbl.Text = "Brand :";
            // 
            // brandcombobox
            // 
            this.brandcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandcombobox.FormattingEnabled = true;
            this.brandcombobox.Location = new System.Drawing.Point(132, 187);
            this.brandcombobox.Margin = new System.Windows.Forms.Padding(2);
            this.brandcombobox.Name = "brandcombobox";
            this.brandcombobox.Size = new System.Drawing.Size(604, 28);
            this.brandcombobox.TabIndex = 36;
            // 
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 456);
            this.Controls.Add(this.brandcombobox);
            this.Controls.Add(this.brandlbl);
            this.Controls.Add(this.updatedatepicker);
            this.Controls.Add(this.createbydatepicler);
            this.Controls.Add(this.createdatelbl);
            this.Controls.Add(this.updatedatelbl);
            this.Controls.Add(this.productnametxtbox);
            this.Controls.Add(this.Qtybox);
            this.Controls.Add(this.Qtylable);
            this.Controls.Add(this.categorycombobox);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.categorylable);
            this.Controls.Add(this.pricelable);
            this.Controls.Add(this.productnamelable);
            this.Controls.Add(this.Descriptionlable);
            this.Controls.Add(this.categorymodulepanel);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductModule";
            this.Text = "ProductModule";
            this.Load += new System.EventHandler(this.ProductModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.categorymodulepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Qtybox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox closepic;
        public System.Windows.Forms.Panel categorymodulepanel;
        public System.Windows.Forms.Label productModulelable;
        public System.Windows.Forms.Button cancelbtn;
        public System.Windows.Forms.Button Updatebtn;
        public System.Windows.Forms.Button Savebtn;
        public System.Windows.Forms.Label Descriptionlable;
        public System.Windows.Forms.Label productnamelable;
        public System.Windows.Forms.Label pricelable;
        public System.Windows.Forms.Label categorylable;
        public System.Windows.Forms.TextBox productnametxtbox;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.ComboBox categorycombobox;
        public System.Windows.Forms.TextBox pricetextbox;
        public System.Windows.Forms.Label Qtylable;
        public System.Windows.Forms.NumericUpDown Qtybox;
        public Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        public System.Windows.Forms.Label updatedatelbl;
        public System.Windows.Forms.Label createdatelbl;
        public System.Windows.Forms.DateTimePicker createbydatepicler;
        public System.Windows.Forms.DateTimePicker updatedatepicker;
        public System.Windows.Forms.Label brandlbl;
        public System.Windows.Forms.ComboBox brandcombobox;
    }
}