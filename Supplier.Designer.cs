namespace WindowsFormsApp1
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brandlogo = new System.Windows.Forms.PictureBox();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.addproductbtn = new System.Windows.Forms.Button();
            this.managersupplierlable = new System.Windows.Forms.Label();
            this.DGVproduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.brandlogo.Location = new System.Drawing.Point(6, 12);
            this.brandlogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brandlogo.Name = "brandlogo";
            this.brandlogo.Size = new System.Drawing.Size(44, 41);
            this.brandlogo.TabIndex = 1;
            this.brandlogo.TabStop = false;
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.addproductbtn);
            this.productlowerpanel.Controls.Add(this.brandlogo);
            this.productlowerpanel.Controls.Add(this.managersupplierlable);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 523);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(1068, 64);
            this.productlowerpanel.TabIndex = 4;
            // 
            // addproductbtn
            // 
            this.addproductbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addproductbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addproductbtn.BackgroundImage")));
            this.addproductbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproductbtn.Location = new System.Drawing.Point(1007, 12);
            this.addproductbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(54, 52);
            this.addproductbtn.TabIndex = 3;
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproductbtn_Click_1);
            // 
            // managersupplierlable
            // 
            this.managersupplierlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managersupplierlable.Location = new System.Drawing.Point(54, 16);
            this.managersupplierlable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managersupplierlable.Name = "managersupplierlable";
            this.managersupplierlable.Size = new System.Drawing.Size(248, 41);
            this.managersupplierlable.TabIndex = 0;
            this.managersupplierlable.Text = "Manage Supplier";
            // 
            // DGVproduct
            // 
            this.DGVproduct.AllowUserToAddRows = false;
            this.DGVproduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVproduct.ColumnHeadersHeight = 30;
            this.DGVproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Edit,
            this.Delete});
            this.DGVproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVproduct.EnableHeadersVisualStyles = false;
            this.DGVproduct.GridColor = System.Drawing.SystemColors.Control;
            this.DGVproduct.Location = new System.Drawing.Point(0, 0);
            this.DGVproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVproduct.Name = "DGVproduct";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVproduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVproduct.RowHeadersVisible = false;
            this.DGVproduct.RowTemplate.Height = 24;
            this.DGVproduct.Size = new System.Drawing.Size(1068, 587);
            this.DGVproduct.TabIndex = 5;
            this.DGVproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVproduct_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 48;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 43;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Supplier";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Contact Person";
            this.Column8.Name = "Column8";
            this.Column8.Width = 121;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            this.Column4.Width = 69;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "E-mail";
            this.Column5.Name = "Column5";
            this.Column5.Width = 68;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Fax";
            this.Column7.Name = "Column7";
            this.Column7.Width = 52;
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
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 587);
            this.Controls.Add(this.productlowerpanel);
            this.Controls.Add(this.DGVproduct);
            this.Name = "Supplier";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox brandlogo;
        private System.Windows.Forms.Panel productlowerpanel;
        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Label managersupplierlable;
        private System.Windows.Forms.DataGridView DGVproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}