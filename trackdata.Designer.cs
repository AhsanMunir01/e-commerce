namespace WindowsFormsApp1
{
    partial class trackdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trackdata));
            this.closebtn = new System.Windows.Forms.Button();
            this.DGVtrackorder = new System.Windows.Forms.DataGridView();
            this.searchlogo = new System.Windows.Forms.PictureBox();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.searchmetrobox = new MetroFramework.Controls.MetroTextBox();
            this.shopppingcartlbl = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtrackorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogo)).BeginInit();
            this.productlowerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.Red;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(922, 21);
            this.closebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(102, 49);
            this.closebtn.TabIndex = 16;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = false;
            // 
            // DGVtrackorder
            // 
            this.DGVtrackorder.AllowUserToAddRows = false;
            this.DGVtrackorder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVtrackorder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVtrackorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVtrackorder.ColumnHeadersHeight = 30;
            this.DGVtrackorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVtrackorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGVtrackorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVtrackorder.EnableHeadersVisualStyles = false;
            this.DGVtrackorder.GridColor = System.Drawing.SystemColors.Control;
            this.DGVtrackorder.Location = new System.Drawing.Point(0, 0);
            this.DGVtrackorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVtrackorder.Name = "DGVtrackorder";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVtrackorder.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVtrackorder.RowHeadersVisible = false;
            this.DGVtrackorder.RowTemplate.Height = 24;
            this.DGVtrackorder.Size = new System.Drawing.Size(1039, 460);
            this.DGVtrackorder.TabIndex = 9;
            // 
            // searchlogo
            // 
            this.searchlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchlogo.BackgroundImage")));
            this.searchlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchlogo.Location = new System.Drawing.Point(7, 18);
            this.searchlogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchlogo.Name = "searchlogo";
            this.searchlogo.Size = new System.Drawing.Size(59, 50);
            this.searchlogo.TabIndex = 1;
            this.searchlogo.TabStop = false;
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.closebtn);
            this.productlowerpanel.Controls.Add(this.searchmetrobox);
            this.productlowerpanel.Controls.Add(this.searchlogo);
            this.productlowerpanel.Controls.Add(this.shopppingcartlbl);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 460);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(1039, 75);
            this.productlowerpanel.TabIndex = 8;
            // 
            // searchmetrobox
            // 
            this.searchmetrobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.searchmetrobox.CustomButton.Image = null;
            this.searchmetrobox.CustomButton.Location = new System.Drawing.Point(481, 2);
            this.searchmetrobox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.searchmetrobox.Location = new System.Drawing.Point(270, 21);
            this.searchmetrobox.Margin = new System.Windows.Forms.Padding(4);
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
            // shopppingcartlbl
            // 
            this.shopppingcartlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopppingcartlbl.Location = new System.Drawing.Point(72, 8);
            this.shopppingcartlbl.Name = "shopppingcartlbl";
            this.shopppingcartlbl.Size = new System.Drawing.Size(110, 70);
            this.shopppingcartlbl.TabIndex = 0;
            this.shopppingcartlbl.Text = "Track Order";
            this.shopppingcartlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 116;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 61;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.Width = 67;
            // 
            // trackdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 535);
            this.Controls.Add(this.DGVtrackorder);
            this.Controls.Add(this.productlowerpanel);
            this.Name = "trackdata";
            this.Text = "trackdata";
            ((System.ComponentModel.ISupportInitialize)(this.DGVtrackorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.DataGridView DGVtrackorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox searchlogo;
        private System.Windows.Forms.Panel productlowerpanel;
        private MetroFramework.Controls.MetroTextBox searchmetrobox;
        private System.Windows.Forms.Label shopppingcartlbl;
    }
}