namespace WindowsFormsApp1
{
    partial class stockentry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockentry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brandlogo = new System.Windows.Forms.PictureBox();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.stockinlbl = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stockentryupperlable = new System.Windows.Forms.Panel();
            this.DGVstockin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.referencenolbl = new System.Windows.Forms.Label();
            this.labelstockinby = new System.Windows.Forms.Label();
            this.labelstockindate = new System.Windows.Forms.Label();
            this.textBoxreferenceno = new System.Windows.Forms.TextBox();
            this.textBoxstockinby = new System.Windows.Forms.TextBox();
            this.dateTimePickerstockindate = new System.Windows.Forms.DateTimePicker();
            this.linkLabelgenerate = new System.Windows.Forms.LinkLabel();
            this.linkLabelbrowse = new System.Windows.Forms.LinkLabel();
            this.labelsupplier = new System.Windows.Forms.Label();
            this.labelcontactperson = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.comboBoxsupplier = new System.Windows.Forms.ComboBox();
            this.textBoxcontactperson = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.entrybtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).BeginInit();
            this.productlowerpanel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.stockentryupperlable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstockin)).BeginInit();
            this.SuspendLayout();
            // 
            // brandlogo
            // 
            this.brandlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brandlogo.BackgroundImage")));
            this.brandlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brandlogo.Location = new System.Drawing.Point(5, 16);
            this.brandlogo.Margin = new System.Windows.Forms.Padding(2);
            this.brandlogo.Name = "brandlogo";
            this.brandlogo.Size = new System.Drawing.Size(44, 40);
            this.brandlogo.TabIndex = 1;
            this.brandlogo.TabStop = false;
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.entrybtn);
            this.productlowerpanel.Controls.Add(this.brandlogo);
            this.productlowerpanel.Controls.Add(this.stockinlbl);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 492);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(1093, 64);
            this.productlowerpanel.TabIndex = 4;
            // 
            // stockinlbl
            // 
            this.stockinlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockinlbl.Location = new System.Drawing.Point(54, 16);
            this.stockinlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockinlbl.Name = "stockinlbl";
            this.stockinlbl.Size = new System.Drawing.Size(200, 41);
            this.stockinlbl.TabIndex = 0;
            this.stockinlbl.Text = "Stock Module";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1093, 492);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVstockin);
            this.tabPage1.Controls.Add(this.stockentryupperlable);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1085, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock in";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1085, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock in Record";
            // 
            // stockentryupperlable
            // 
            this.stockentryupperlable.Controls.Add(this.textBoxaddress);
            this.stockentryupperlable.Controls.Add(this.textBoxcontactperson);
            this.stockentryupperlable.Controls.Add(this.comboBoxsupplier);
            this.stockentryupperlable.Controls.Add(this.labelid);
            this.stockentryupperlable.Controls.Add(this.labeladdress);
            this.stockentryupperlable.Controls.Add(this.labelcontactperson);
            this.stockentryupperlable.Controls.Add(this.labelsupplier);
            this.stockentryupperlable.Controls.Add(this.linkLabelbrowse);
            this.stockentryupperlable.Controls.Add(this.linkLabelgenerate);
            this.stockentryupperlable.Controls.Add(this.dateTimePickerstockindate);
            this.stockentryupperlable.Controls.Add(this.textBoxstockinby);
            this.stockentryupperlable.Controls.Add(this.textBoxreferenceno);
            this.stockentryupperlable.Controls.Add(this.labelstockindate);
            this.stockentryupperlable.Controls.Add(this.labelstockinby);
            this.stockentryupperlable.Controls.Add(this.referencenolbl);
            this.stockentryupperlable.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockentryupperlable.Location = new System.Drawing.Point(0, 0);
            this.stockentryupperlable.Name = "stockentryupperlable";
            this.stockentryupperlable.Size = new System.Drawing.Size(1085, 154);
            this.stockentryupperlable.TabIndex = 0;
            // 
            // DGVstockin
            // 
            this.DGVstockin.AllowUserToAddRows = false;
            this.DGVstockin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVstockin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVstockin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVstockin.ColumnHeadersHeight = 30;
            this.DGVstockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVstockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column6,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Edit,
            this.Delete});
            this.DGVstockin.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVstockin.EnableHeadersVisualStyles = false;
            this.DGVstockin.GridColor = System.Drawing.SystemColors.Control;
            this.DGVstockin.Location = new System.Drawing.Point(0, 154);
            this.DGVstockin.Margin = new System.Windows.Forms.Padding(2);
            this.DGVstockin.Name = "DGVstockin";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVstockin.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVstockin.RowHeadersVisible = false;
            this.DGVstockin.RowTemplate.Height = 24;
            this.DGVstockin.Size = new System.Drawing.Size(1085, 242);
            this.DGVstockin.TabIndex = 4;
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
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Reference #";
            this.Column9.Name = "Column9";
            this.Column9.Width = 103;
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
            this.Column8.HeaderText = "Qty";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Stock in Date";
            this.Column4.Name = "Column4";
            this.Column4.Width = 109;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "stock in by";
            this.Column5.Name = "Column5";
            this.Column5.Width = 93;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Supplier";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
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
            // referencenolbl
            // 
            this.referencenolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referencenolbl.Location = new System.Drawing.Point(8, 13);
            this.referencenolbl.Name = "referencenolbl";
            this.referencenolbl.Size = new System.Drawing.Size(136, 23);
            this.referencenolbl.TabIndex = 0;
            this.referencenolbl.Text = "Reference No : ";
            // 
            // labelstockinby
            // 
            this.labelstockinby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockinby.Location = new System.Drawing.Point(8, 57);
            this.labelstockinby.Name = "labelstockinby";
            this.labelstockinby.Size = new System.Drawing.Size(136, 23);
            this.labelstockinby.TabIndex = 1;
            this.labelstockinby.Text = "Stock in by : ";
            // 
            // labelstockindate
            // 
            this.labelstockindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockindate.Location = new System.Drawing.Point(8, 93);
            this.labelstockindate.Name = "labelstockindate";
            this.labelstockindate.Size = new System.Drawing.Size(136, 23);
            this.labelstockindate.TabIndex = 2;
            this.labelstockindate.Text = "Stock in Date  : ";
            // 
            // textBoxreferenceno
            // 
            this.textBoxreferenceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxreferenceno.Location = new System.Drawing.Point(189, 10);
            this.textBoxreferenceno.Name = "textBoxreferenceno";
            this.textBoxreferenceno.Size = new System.Drawing.Size(142, 26);
            this.textBoxreferenceno.TabIndex = 3;
            this.textBoxreferenceno.TextChanged += new System.EventHandler(this.textBoxreferenceno_TextChanged);
            // 
            // textBoxstockinby
            // 
            this.textBoxstockinby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstockinby.Location = new System.Drawing.Point(189, 57);
            this.textBoxstockinby.Name = "textBoxstockinby";
            this.textBoxstockinby.Size = new System.Drawing.Size(269, 26);
            this.textBoxstockinby.TabIndex = 4;
            // 
            // dateTimePickerstockindate
            // 
            this.dateTimePickerstockindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerstockindate.Location = new System.Drawing.Point(189, 93);
            this.dateTimePickerstockindate.Name = "dateTimePickerstockindate";
            this.dateTimePickerstockindate.Size = new System.Drawing.Size(269, 26);
            this.dateTimePickerstockindate.TabIndex = 5;
            // 
            // linkLabelgenerate
            // 
            this.linkLabelgenerate.AutoSize = true;
            this.linkLabelgenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelgenerate.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelgenerate.Location = new System.Drawing.Point(349, 16);
            this.linkLabelgenerate.Name = "linkLabelgenerate";
            this.linkLabelgenerate.Size = new System.Drawing.Size(93, 20);
            this.linkLabelgenerate.TabIndex = 6;
            this.linkLabelgenerate.TabStop = true;
            this.linkLabelgenerate.Text = "[ Generate ]";
            this.linkLabelgenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelgenerate_LinkClicked);
            // 
            // linkLabelbrowse
            // 
            this.linkLabelbrowse.AutoSize = true;
            this.linkLabelbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelbrowse.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelbrowse.Location = new System.Drawing.Point(185, 132);
            this.linkLabelbrowse.Name = "linkLabelbrowse";
            this.linkLabelbrowse.Size = new System.Drawing.Size(226, 20);
            this.linkLabelbrowse.TabIndex = 7;
            this.linkLabelbrowse.TabStop = true;
            this.linkLabelbrowse.Text = "[ Click here to browse Product ]";
            this.linkLabelbrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelbrowse_LinkClicked);
            // 
            // labelsupplier
            // 
            this.labelsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsupplier.Location = new System.Drawing.Point(605, 10);
            this.labelsupplier.Name = "labelsupplier";
            this.labelsupplier.Size = new System.Drawing.Size(136, 23);
            this.labelsupplier.TabIndex = 8;
            this.labelsupplier.Text = "Supplier : ";
            // 
            // labelcontactperson
            // 
            this.labelcontactperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontactperson.Location = new System.Drawing.Point(605, 46);
            this.labelcontactperson.Name = "labelcontactperson";
            this.labelcontactperson.Size = new System.Drawing.Size(136, 23);
            this.labelcontactperson.TabIndex = 9;
            this.labelcontactperson.Text = "Contact Person : ";
            // 
            // labeladdress
            // 
            this.labeladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(605, 81);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(136, 23);
            this.labeladdress.TabIndex = 10;
            this.labeladdress.Text = "Address : ";
            // 
            // labelid
            // 
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(605, 115);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(136, 23);
            this.labelid.TabIndex = 11;
            this.labelid.Text = "ID :";
            this.labelid.Visible = false;
            // 
            // comboBoxsupplier
            // 
            this.comboBoxsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxsupplier.FormattingEnabled = true;
            this.comboBoxsupplier.Location = new System.Drawing.Point(747, 3);
            this.comboBoxsupplier.Name = "comboBoxsupplier";
            this.comboBoxsupplier.Size = new System.Drawing.Size(318, 28);
            this.comboBoxsupplier.TabIndex = 12;
            // 
            // textBoxcontactperson
            // 
            this.textBoxcontactperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcontactperson.Location = new System.Drawing.Point(747, 43);
            this.textBoxcontactperson.Name = "textBoxcontactperson";
            this.textBoxcontactperson.Size = new System.Drawing.Size(318, 26);
            this.textBoxcontactperson.TabIndex = 13;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxaddress.Location = new System.Drawing.Point(747, 81);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(318, 26);
            this.textBoxaddress.TabIndex = 14;
            // 
            // entrybtn
            // 
            this.entrybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrybtn.Location = new System.Drawing.Point(979, 2);
            this.entrybtn.Margin = new System.Windows.Forms.Padding(2);
            this.entrybtn.Name = "entrybtn";
            this.entrybtn.Size = new System.Drawing.Size(112, 40);
            this.entrybtn.TabIndex = 15;
            this.entrybtn.Text = "Entey";
            this.entrybtn.UseVisualStyleBackColor = true;
            this.entrybtn.Click += new System.EventHandler(this.entrybtn_Click);
            // 
            // stockentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 556);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.productlowerpanel);
            this.Name = "stockentry";
            this.Text = "Stock Entry";
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.stockentryupperlable.ResumeLayout(false);
            this.stockentryupperlable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstockin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox brandlogo;
        private System.Windows.Forms.Panel productlowerpanel;
        private System.Windows.Forms.Label stockinlbl;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel stockentryupperlable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVstockin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox textBoxstockinby;
        private System.Windows.Forms.TextBox textBoxreferenceno;
        private System.Windows.Forms.Label labelstockindate;
        private System.Windows.Forms.Label labelstockinby;
        private System.Windows.Forms.Label referencenolbl;
        private System.Windows.Forms.LinkLabel linkLabelbrowse;
        private System.Windows.Forms.LinkLabel linkLabelgenerate;
        private System.Windows.Forms.DateTimePicker dateTimePickerstockindate;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxcontactperson;
        private System.Windows.Forms.ComboBox comboBoxsupplier;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelcontactperson;
        private System.Windows.Forms.Label labelsupplier;
        private System.Windows.Forms.Button entrybtn;
    }
}