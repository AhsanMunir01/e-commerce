namespace WindowsFormsApp1
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brandlogo = new System.Windows.Forms.PictureBox();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.searchmetrobox = new MetroFramework.Controls.MetroTextBox();
            this.addproductbtn = new System.Windows.Forms.Button();
            this.managerbrandlable = new System.Windows.Forms.Label();
            this.DGVproduct = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).BeginInit();
            this.productlowerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // brandlogo
            // 
            this.brandlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brandlogo.BackgroundImage")));
            this.brandlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brandlogo.Location = new System.Drawing.Point(5, 15);
            this.brandlogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandlogo.Name = "brandlogo";
            this.brandlogo.Size = new System.Drawing.Size(44, 41);
            this.brandlogo.TabIndex = 1;
            this.brandlogo.TabStop = false;
            this.brandlogo.Click += new System.EventHandler(this.brandlogo_Click);
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.searchmetrobox);
            this.productlowerpanel.Controls.Add(this.addproductbtn);
            this.productlowerpanel.Controls.Add(this.brandlogo);
            this.productlowerpanel.Controls.Add(this.managerbrandlable);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 476);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(995, 64);
            this.productlowerpanel.TabIndex = 2;
            this.productlowerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productlowerpanel_Paint);
            // 
            // searchmetrobox
            // 
            this.searchmetrobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.searchmetrobox.CustomButton.Image = null;
            this.searchmetrobox.CustomButton.Location = new System.Drawing.Point(357, 1);
            this.searchmetrobox.CustomButton.Name = "";
            this.searchmetrobox.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.searchmetrobox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchmetrobox.CustomButton.TabIndex = 1;
            this.searchmetrobox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchmetrobox.CustomButton.UseSelectable = true;
            this.searchmetrobox.CustomButton.Visible = false;
            this.searchmetrobox.DisplayIcon = true;
            this.searchmetrobox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchmetrobox.Icon = ((System.Drawing.Image)(resources.GetObject("searchmetrobox.Icon")));
            this.searchmetrobox.Lines = new string[0];
            this.searchmetrobox.Location = new System.Drawing.Point(317, 5);
            this.searchmetrobox.MaxLength = 32767;
            this.searchmetrobox.Multiline = true;
            this.searchmetrobox.Name = "searchmetrobox";
            this.searchmetrobox.PasswordChar = '\0';
            this.searchmetrobox.PromptText = "Search here";
            this.searchmetrobox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchmetrobox.SelectedText = "";
            this.searchmetrobox.SelectionLength = 0;
            this.searchmetrobox.SelectionStart = 0;
            this.searchmetrobox.ShortcutsEnabled = true;
            this.searchmetrobox.Size = new System.Drawing.Size(397, 41);
            this.searchmetrobox.TabIndex = 4;
            this.searchmetrobox.UseSelectable = true;
            this.searchmetrobox.WaterMark = "Search here";
            this.searchmetrobox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchmetrobox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchmetrobox.Click += new System.EventHandler(this.searchmetrobox_Click);
            // 
            // addproductbtn
            // 
            this.addproductbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addproductbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addproductbtn.BackgroundImage")));
            this.addproductbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproductbtn.Location = new System.Drawing.Point(934, 12);
            this.addproductbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(54, 52);
            this.addproductbtn.TabIndex = 3;
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproductbtn_Click);
            // 
            // managerbrandlable
            // 
            this.managerbrandlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerbrandlable.Location = new System.Drawing.Point(54, 16);
            this.managerbrandlable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managerbrandlable.Name = "managerbrandlable";
            this.managerbrandlable.Size = new System.Drawing.Size(187, 41);
            this.managerbrandlable.TabIndex = 0;
            this.managerbrandlable.Text = "Manage Product";
            this.managerbrandlable.Click += new System.EventHandler(this.managerbrandlable_Click);
            // 
            // DGVproduct
            // 
            this.DGVproduct.AllowUserToAddRows = false;
            this.DGVproduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVproduct.ColumnHeadersHeight = 30;
            this.DGVproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Edit,
            this.Delete});
            this.DGVproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVproduct.EnableHeadersVisualStyles = false;
            this.DGVproduct.GridColor = System.Drawing.SystemColors.Control;
            this.DGVproduct.Location = new System.Drawing.Point(0, 0);
            this.DGVproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVproduct.Name = "DGVproduct";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVproduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVproduct.RowHeadersVisible = false;
            this.DGVproduct.RowTemplate.Height = 24;
            this.DGVproduct.Size = new System.Drawing.Size(995, 476);
            this.DGVproduct.TabIndex = 3;
            this.DGVproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproduct_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Width = 43;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Category";
            this.Column4.Name = "Column4";
            this.Column4.Width = 85;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 61;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Qty";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Brand";
            this.Column8.Name = "Column8";
            this.Column8.Width = 66;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 540);
            this.Controls.Add(this.DGVproduct);
            this.Controls.Add(this.productlowerpanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Product";
            this.Text = "PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox brandlogo;
        private System.Windows.Forms.Panel productlowerpanel;
        private MetroFramework.Controls.MetroTextBox searchmetrobox;
        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Label managerbrandlable;
        private System.Windows.Forms.DataGridView DGVproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}