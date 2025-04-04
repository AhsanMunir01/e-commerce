namespace WindowsFormsApp1
{
    partial class ProductStockin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStockin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVproduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.brandlogo = new System.Windows.Forms.PictureBox();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.searchmetrobox = new MetroFramework.Controls.MetroTextBox();
            this.managerbrandlable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).BeginInit();
            this.productlowerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(495, 276);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(11, 10);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.Column3,
            this.Column6,
            this.Column7,
            this.Select});
            this.DGVproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVproduct.EnableHeadersVisualStyles = false;
            this.DGVproduct.GridColor = System.Drawing.SystemColors.Control;
            this.DGVproduct.Location = new System.Drawing.Point(0, 0);
            this.DGVproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.DGVproduct.Size = new System.Drawing.Size(1303, 732);
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
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 67;
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
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.Name = "Select";
            this.Select.Width = 5;
            // 
            // brandlogo
            // 
            this.brandlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brandlogo.BackgroundImage")));
            this.brandlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brandlogo.Location = new System.Drawing.Point(0, 7);
            this.brandlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandlogo.Name = "brandlogo";
            this.brandlogo.Size = new System.Drawing.Size(79, 58);
            this.brandlogo.TabIndex = 1;
            this.brandlogo.TabStop = false;
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.closebtn);
            this.productlowerpanel.Controls.Add(this.searchmetrobox);
            this.productlowerpanel.Controls.Add(this.brandlogo);
            this.productlowerpanel.Controls.Add(this.managerbrandlable);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 732);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(1303, 79);
            this.productlowerpanel.TabIndex = 4;
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(1139, 16);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(149, 49);
            this.closebtn.TabIndex = 16;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // searchmetrobox
            // 
            this.searchmetrobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.searchmetrobox.CustomButton.Image = null;
            this.searchmetrobox.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.searchmetrobox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchmetrobox.CustomButton.Name = "";
            this.searchmetrobox.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.searchmetrobox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchmetrobox.CustomButton.TabIndex = 1;
            this.searchmetrobox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchmetrobox.CustomButton.UseSelectable = true;
            this.searchmetrobox.CustomButton.Visible = false;
            this.searchmetrobox.DisplayIcon = true;
            this.searchmetrobox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchmetrobox.Icon = ((System.Drawing.Image)(resources.GetObject("searchmetrobox.Icon")));
            this.searchmetrobox.Lines = new string[0];
            this.searchmetrobox.Location = new System.Drawing.Point(449, 15);
            this.searchmetrobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.searchmetrobox.Size = new System.Drawing.Size(529, 50);
            this.searchmetrobox.TabIndex = 4;
            this.searchmetrobox.UseSelectable = true;
            this.searchmetrobox.WaterMark = "Search here";
            this.searchmetrobox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchmetrobox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // managerbrandlable
            // 
            this.managerbrandlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerbrandlable.Location = new System.Drawing.Point(72, 20);
            this.managerbrandlable.Name = "managerbrandlable";
            this.managerbrandlable.Size = new System.Drawing.Size(249, 50);
            this.managerbrandlable.TabIndex = 0;
            this.managerbrandlable.Text = "Product Stock in ";
            // 
            // ProductStockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 811);
            this.Controls.Add(this.DGVproduct);
            this.Controls.Add(this.productlowerpanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductStockin";
            this.Text = "ProductStockin";
            ((System.ComponentModel.ISupportInitialize)(this.DGVproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVproduct;
        private System.Windows.Forms.PictureBox brandlogo;
        private System.Windows.Forms.Panel productlowerpanel;
        private MetroFramework.Controls.MetroTextBox searchmetrobox;
        private System.Windows.Forms.Label managerbrandlable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.Button closebtn;
    }
}