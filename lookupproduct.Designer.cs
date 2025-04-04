namespace WindowsFormsApp1
{
    partial class lookupproduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lookupproduct));
            this.searchlogo = new System.Windows.Forms.PictureBox();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.buybtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.searchmetrobox = new MetroFramework.Controls.MetroTextBox();
            this.searchproductlbl = new System.Windows.Forms.Label();
            this.gridproduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchlogo)).BeginInit();
            this.productlowerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // searchlogo
            // 
            this.searchlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchlogo.BackgroundImage")));
            this.searchlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchlogo.Location = new System.Drawing.Point(5, 6);
            this.searchlogo.Margin = new System.Windows.Forms.Padding(2);
            this.searchlogo.Name = "searchlogo";
            this.searchlogo.Size = new System.Drawing.Size(52, 59);
            this.searchlogo.TabIndex = 1;
            this.searchlogo.TabStop = false;
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.searchbtn);
            this.productlowerpanel.Controls.Add(this.buybtn);
            this.productlowerpanel.Controls.Add(this.closebtn);
            this.productlowerpanel.Controls.Add(this.searchmetrobox);
            this.productlowerpanel.Controls.Add(this.searchlogo);
            this.productlowerpanel.Controls.Add(this.searchproductlbl);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 662);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(1207, 76);
            this.productlowerpanel.TabIndex = 4;
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(775, 15);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(116, 39);
            this.searchbtn.TabIndex = 17;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // buybtn
            // 
            this.buybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buybtn.BackColor = System.Drawing.Color.White;
            this.buybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buybtn.Location = new System.Drawing.Point(960, 27);
            this.buybtn.Margin = new System.Windows.Forms.Padding(2);
            this.buybtn.Name = "buybtn";
            this.buybtn.Size = new System.Drawing.Size(96, 33);
            this.buybtn.TabIndex = 18;
            this.buybtn.Text = "Buy";
            this.buybtn.UseVisualStyleBackColor = false;
            this.buybtn.Click += new System.EventHandler(this.buybtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.Red;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(1109, 20);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(96, 47);
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
            this.searchmetrobox.CustomButton.Location = new System.Drawing.Point(382, 1);
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
            this.searchmetrobox.Location = new System.Drawing.Point(287, 15);
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
            this.searchmetrobox.Size = new System.Drawing.Size(422, 41);
            this.searchmetrobox.TabIndex = 4;
            this.searchmetrobox.UseSelectable = true;
            this.searchmetrobox.WaterMark = "Search here";
            this.searchmetrobox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchmetrobox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchmetrobox.Click += new System.EventHandler(this.searchmetrobox_Click);
            // 
            // searchproductlbl
            // 
            this.searchproductlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchproductlbl.Location = new System.Drawing.Point(61, 10);
            this.searchproductlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchproductlbl.Name = "searchproductlbl";
            this.searchproductlbl.Size = new System.Drawing.Size(117, 57);
            this.searchproductlbl.TabIndex = 0;
            this.searchproductlbl.Text = "Search Product";
            this.searchproductlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridproduct
            // 
            this.gridproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridproduct.Location = new System.Drawing.Point(0, 0);
            this.gridproduct.Name = "gridproduct";
            this.gridproduct.Size = new System.Drawing.Size(1207, 662);
            this.gridproduct.TabIndex = 5;
            // 
            // lookupproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 738);
            this.Controls.Add(this.gridproduct);
            this.Controls.Add(this.productlowerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lookupproduct";
            this.Text = "lookupproduct";
            ((System.ComponentModel.ISupportInitialize)(this.searchlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox searchlogo;
        private System.Windows.Forms.Panel productlowerpanel;
        private MetroFramework.Controls.MetroTextBox searchmetrobox;
        private System.Windows.Forms.Label searchproductlbl;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button buybtn;
        private System.Windows.Forms.DataGridView gridproduct;
    }
}