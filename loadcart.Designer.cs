namespace WindowsFormsApp1
{
    partial class loadcart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadcart));
            this.DGVcartload = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchlogo = new System.Windows.Forms.PictureBox();
            this.cartlowerpanel = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.searchmetrobox = new MetroFramework.Controls.MetroTextBox();
            this.shopppingcartlbl = new System.Windows.Forms.Label();
            this.cardpaymentradio = new System.Windows.Forms.RadioButton();
            this.CODradio = new System.Windows.Forms.RadioButton();
            this.panelpayment = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcartload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogo)).BeginInit();
            this.cartlowerpanel.SuspendLayout();
            this.panelpayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVcartload
            // 
            this.DGVcartload.AllowUserToAddRows = false;
            this.DGVcartload.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVcartload.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVcartload.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVcartload.ColumnHeadersHeight = 30;
            this.DGVcartload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVcartload.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column7,
            this.edit,
            this.delete});
            this.DGVcartload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVcartload.EnableHeadersVisualStyles = false;
            this.DGVcartload.GridColor = System.Drawing.SystemColors.Control;
            this.DGVcartload.Location = new System.Drawing.Point(0, 0);
            this.DGVcartload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVcartload.Name = "DGVcartload";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVcartload.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVcartload.RowHeadersVisible = false;
            this.DGVcartload.RowTemplate.Height = 24;
            this.DGVcartload.Size = new System.Drawing.Size(855, 492);
            this.DGVcartload.TabIndex = 7;
            this.DGVcartload.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcartload_CellContentClick);
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
            this.Column2.Width = 45;
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
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Brand";
            this.Column8.Name = "Column8";
            this.Column8.Width = 66;
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
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Qty";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.Width = 5;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Width = 5;
            // 
            // searchlogo
            // 
            this.searchlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchlogo.BackgroundImage")));
            this.searchlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchlogo.Location = new System.Drawing.Point(2, 7);
            this.searchlogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchlogo.Name = "searchlogo";
            this.searchlogo.Size = new System.Drawing.Size(44, 45);
            this.searchlogo.TabIndex = 1;
            this.searchlogo.TabStop = false;
            // 
            // cartlowerpanel
            // 
            this.cartlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cartlowerpanel.Controls.Add(this.closebtn);
            this.cartlowerpanel.Controls.Add(this.searchmetrobox);
            this.cartlowerpanel.Controls.Add(this.searchlogo);
            this.cartlowerpanel.Controls.Add(this.shopppingcartlbl);
            this.cartlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cartlowerpanel.Location = new System.Drawing.Point(0, 492);
            this.cartlowerpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartlowerpanel.Name = "cartlowerpanel";
            this.cartlowerpanel.Size = new System.Drawing.Size(855, 58);
            this.cartlowerpanel.TabIndex = 6;
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.Red;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(776, 7);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(76, 45);
            this.closebtn.TabIndex = 16;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // searchmetrobox
            // 
            this.searchmetrobox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.searchmetrobox.CustomButton.Image = null;
            this.searchmetrobox.CustomButton.Location = new System.Drawing.Point(353, 1);
            this.searchmetrobox.CustomButton.Name = "";
            this.searchmetrobox.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.searchmetrobox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchmetrobox.CustomButton.TabIndex = 1;
            this.searchmetrobox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchmetrobox.CustomButton.UseSelectable = true;
            this.searchmetrobox.CustomButton.Visible = false;
            this.searchmetrobox.DisplayIcon = true;
            this.searchmetrobox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchmetrobox.Icon = ((System.Drawing.Image)(resources.GetObject("searchmetrobox.Icon")));
            this.searchmetrobox.Lines = new string[0];
            this.searchmetrobox.Location = new System.Drawing.Point(206, 7);
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
            this.searchmetrobox.Size = new System.Drawing.Size(397, 45);
            this.searchmetrobox.TabIndex = 4;
            this.searchmetrobox.UseSelectable = true;
            this.searchmetrobox.WaterMark = "Search here";
            this.searchmetrobox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchmetrobox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // shopppingcartlbl
            // 
            this.shopppingcartlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopppingcartlbl.Location = new System.Drawing.Point(51, -1);
            this.shopppingcartlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopppingcartlbl.Name = "shopppingcartlbl";
            this.shopppingcartlbl.Size = new System.Drawing.Size(136, 59);
            this.shopppingcartlbl.TabIndex = 0;
            this.shopppingcartlbl.Text = "Shopping Cart";
            this.shopppingcartlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardpaymentradio
            // 
            this.cardpaymentradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardpaymentradio.Image = ((System.Drawing.Image)(resources.GetObject("cardpaymentradio.Image")));
            this.cardpaymentradio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cardpaymentradio.Location = new System.Drawing.Point(9, 13);
            this.cardpaymentradio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardpaymentradio.Name = "cardpaymentradio";
            this.cardpaymentradio.Size = new System.Drawing.Size(194, 32);
            this.cardpaymentradio.TabIndex = 8;
            this.cardpaymentradio.TabStop = true;
            this.cardpaymentradio.Text = "Card Payment ";
            this.cardpaymentradio.UseVisualStyleBackColor = true;
            this.cardpaymentradio.CheckedChanged += new System.EventHandler(this.cardpaymentradio_CheckedChanged);
            // 
            // CODradio
            // 
            this.CODradio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CODradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODradio.Image = ((System.Drawing.Image)(resources.GetObject("CODradio.Image")));
            this.CODradio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CODradio.Location = new System.Drawing.Point(9, 61);
            this.CODradio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CODradio.Name = "CODradio";
            this.CODradio.Size = new System.Drawing.Size(190, 28);
            this.CODradio.TabIndex = 9;
            this.CODradio.TabStop = true;
            this.CODradio.Text = "Cash on Delivery";
            this.CODradio.UseVisualStyleBackColor = true;
            // 
            // panelpayment
            // 
            this.panelpayment.Controls.Add(this.cardpaymentradio);
            this.panelpayment.Controls.Add(this.CODradio);
            this.panelpayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelpayment.Location = new System.Drawing.Point(0, 399);
            this.panelpayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelpayment.Name = "panelpayment";
            this.panelpayment.Size = new System.Drawing.Size(855, 93);
            this.panelpayment.TabIndex = 10;
            // 
            // loadcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 550);
            this.Controls.Add(this.panelpayment);
            this.Controls.Add(this.DGVcartload);
            this.Controls.Add(this.cartlowerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loadcart";
            this.Text = "loadcart";
            ((System.ComponentModel.ISupportInitialize)(this.DGVcartload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogo)).EndInit();
            this.cartlowerpanel.ResumeLayout(false);
            this.panelpayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcartload;
        private System.Windows.Forms.PictureBox searchlogo;
        private System.Windows.Forms.Panel cartlowerpanel;
        private System.Windows.Forms.Button closebtn;
        private MetroFramework.Controls.MetroTextBox searchmetrobox;
        private System.Windows.Forms.Label shopppingcartlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.RadioButton cardpaymentradio;
        private System.Windows.Forms.RadioButton CODradio;
        private System.Windows.Forms.Panel panelpayment;
    }
}