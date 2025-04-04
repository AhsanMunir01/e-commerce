namespace WindowsFormsApp1
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.dashboardpanel = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.supllierbtn = new System.Windows.Forms.Button();
            this.panelsubstock = new System.Windows.Forms.Panel();
            this.stcokadjustmentbtn = new System.Windows.Forms.Button();
            this.stockentrybtn = new System.Windows.Forms.Button();
            this.instockbtn = new System.Windows.Forms.Button();
            this.panelsubpro = new System.Windows.Forms.Panel();
            this.brandbtn = new System.Windows.Forms.Button();
            this.categorybtn = new System.Windows.Forms.Button();
            this.productlistbtn = new System.Windows.Forms.Button();
            this.Productbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.usernamelable = new System.Windows.Forms.Label();
            this.adminlable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titalnamelbl = new System.Windows.Forms.Panel();
            this.titlelable = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dashboardpanel.SuspendLayout();
            this.panelsubstock.SuspendLayout();
            this.panelsubpro.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titalnamelbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardpanel
            // 
            this.dashboardpanel.AutoScroll = true;
            this.dashboardpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardpanel.Controls.Add(this.logoutbtn);
            this.dashboardpanel.Controls.Add(this.supllierbtn);
            this.dashboardpanel.Controls.Add(this.panelsubstock);
            this.dashboardpanel.Controls.Add(this.instockbtn);
            this.dashboardpanel.Controls.Add(this.panelsubpro);
            this.dashboardpanel.Controls.Add(this.Productbtn);
            this.dashboardpanel.Controls.Add(this.dashboardbtn);
            this.dashboardpanel.Controls.Add(this.panellogo);
            this.dashboardpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardpanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardpanel.Name = "dashboardpanel";
            this.dashboardpanel.Size = new System.Drawing.Size(297, 873);
            this.dashboardpanel.TabIndex = 0;
            this.dashboardpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardpanel_Paint);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Image")));
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutbtn.Location = new System.Drawing.Point(0, 818);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.logoutbtn.Size = new System.Drawing.Size(297, 55);
            this.logoutbtn.TabIndex = 21;
            this.logoutbtn.Text = " Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // supllierbtn
            // 
            this.supllierbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.supllierbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supllierbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supllierbtn.Image = ((System.Drawing.Image)(resources.GetObject("supllierbtn.Image")));
            this.supllierbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.supllierbtn.Location = new System.Drawing.Point(0, 618);
            this.supllierbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supllierbtn.Name = "supllierbtn";
            this.supllierbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.supllierbtn.Size = new System.Drawing.Size(297, 55);
            this.supllierbtn.TabIndex = 16;
            this.supllierbtn.Text = "Supplier";
            this.supllierbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supllierbtn.UseVisualStyleBackColor = true;
            this.supllierbtn.Click += new System.EventHandler(this.supllierbtn_Click);
            // 
            // panelsubstock
            // 
            this.panelsubstock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelsubstock.Controls.Add(this.stcokadjustmentbtn);
            this.panelsubstock.Controls.Add(this.stockentrybtn);
            this.panelsubstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubstock.Location = new System.Drawing.Point(0, 510);
            this.panelsubstock.Margin = new System.Windows.Forms.Padding(4);
            this.panelsubstock.Name = "panelsubstock";
            this.panelsubstock.Size = new System.Drawing.Size(297, 108);
            this.panelsubstock.TabIndex = 15;
            this.panelsubstock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsubstock_Paint);
            // 
            // stcokadjustmentbtn
            // 
            this.stcokadjustmentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stcokadjustmentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stcokadjustmentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stcokadjustmentbtn.Image = ((System.Drawing.Image)(resources.GetObject("stcokadjustmentbtn.Image")));
            this.stcokadjustmentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stcokadjustmentbtn.Location = new System.Drawing.Point(0, 55);
            this.stcokadjustmentbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stcokadjustmentbtn.Name = "stcokadjustmentbtn";
            this.stcokadjustmentbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.stcokadjustmentbtn.Size = new System.Drawing.Size(297, 52);
            this.stcokadjustmentbtn.TabIndex = 16;
            this.stcokadjustmentbtn.Text = " Adjustment";
            this.stcokadjustmentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stcokadjustmentbtn.UseVisualStyleBackColor = true;
            this.stcokadjustmentbtn.Click += new System.EventHandler(this.stcokadjustmentbtn_Click);
            // 
            // stockentrybtn
            // 
            this.stockentrybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockentrybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockentrybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockentrybtn.Image = ((System.Drawing.Image)(resources.GetObject("stockentrybtn.Image")));
            this.stockentrybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stockentrybtn.Location = new System.Drawing.Point(0, 0);
            this.stockentrybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockentrybtn.Name = "stockentrybtn";
            this.stockentrybtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.stockentrybtn.Size = new System.Drawing.Size(297, 55);
            this.stockentrybtn.TabIndex = 15;
            this.stockentrybtn.Text = "Stock Entry";
            this.stockentrybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockentrybtn.UseVisualStyleBackColor = true;
            this.stockentrybtn.Click += new System.EventHandler(this.stockentrybtn_Click);
            // 
            // instockbtn
            // 
            this.instockbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.instockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instockbtn.Image = ((System.Drawing.Image)(resources.GetObject("instockbtn.Image")));
            this.instockbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.instockbtn.Location = new System.Drawing.Point(0, 455);
            this.instockbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.instockbtn.Name = "instockbtn";
            this.instockbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.instockbtn.Size = new System.Drawing.Size(297, 55);
            this.instockbtn.TabIndex = 14;
            this.instockbtn.Text = "In Stock";
            this.instockbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instockbtn.UseVisualStyleBackColor = true;
            this.instockbtn.Click += new System.EventHandler(this.instockbtn_Click);
            // 
            // panelsubpro
            // 
            this.panelsubpro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelsubpro.Controls.Add(this.brandbtn);
            this.panelsubpro.Controls.Add(this.categorybtn);
            this.panelsubpro.Controls.Add(this.productlistbtn);
            this.panelsubpro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubpro.Location = new System.Drawing.Point(0, 297);
            this.panelsubpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelsubpro.Name = "panelsubpro";
            this.panelsubpro.Size = new System.Drawing.Size(297, 158);
            this.panelsubpro.TabIndex = 3;
            this.panelsubpro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsubpro_Paint);
            // 
            // brandbtn
            // 
            this.brandbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandbtn.Image = ((System.Drawing.Image)(resources.GetObject("brandbtn.Image")));
            this.brandbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brandbtn.Location = new System.Drawing.Point(0, 100);
            this.brandbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandbtn.Name = "brandbtn";
            this.brandbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.brandbtn.Size = new System.Drawing.Size(297, 58);
            this.brandbtn.TabIndex = 5;
            this.brandbtn.Text = "Brand";
            this.brandbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brandbtn.UseVisualStyleBackColor = true;
            this.brandbtn.Click += new System.EventHandler(this.brandbtn_Click);
            // 
            // categorybtn
            // 
            this.categorybtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybtn.Image = ((System.Drawing.Image)(resources.GetObject("categorybtn.Image")));
            this.categorybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categorybtn.Location = new System.Drawing.Point(0, 48);
            this.categorybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.categorybtn.Size = new System.Drawing.Size(297, 52);
            this.categorybtn.TabIndex = 4;
            this.categorybtn.Text = "Category";
            this.categorybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorybtn.UseVisualStyleBackColor = true;
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // productlistbtn
            // 
            this.productlistbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlistbtn.Image = ((System.Drawing.Image)(resources.GetObject("productlistbtn.Image")));
            this.productlistbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productlistbtn.Location = new System.Drawing.Point(0, 0);
            this.productlistbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productlistbtn.Name = "productlistbtn";
            this.productlistbtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.productlistbtn.Size = new System.Drawing.Size(297, 48);
            this.productlistbtn.TabIndex = 3;
            this.productlistbtn.Text = "Product List";
            this.productlistbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productlistbtn.UseVisualStyleBackColor = true;
            this.productlistbtn.Click += new System.EventHandler(this.productlistbtn_Click);
            // 
            // Productbtn
            // 
            this.Productbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Productbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productbtn.Image = ((System.Drawing.Image)(resources.GetObject("Productbtn.Image")));
            this.Productbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Productbtn.Location = new System.Drawing.Point(0, 234);
            this.Productbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Productbtn.Name = "Productbtn";
            this.Productbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Productbtn.Size = new System.Drawing.Size(297, 63);
            this.Productbtn.TabIndex = 2;
            this.Productbtn.Text = "Product";
            this.Productbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Productbtn.UseVisualStyleBackColor = true;
            this.Productbtn.Click += new System.EventHandler(this.Productbtn_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 181);
            this.dashboardbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dashboardbtn.Size = new System.Drawing.Size(297, 53);
            this.dashboardbtn.TabIndex = 1;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbtn.UseVisualStyleBackColor = true;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.usernamelable);
            this.panellogo.Controls.Add(this.adminlable);
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(297, 181);
            this.panellogo.TabIndex = 0;
            this.panellogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // usernamelable
            // 
            this.usernamelable.AutoSize = true;
            this.usernamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelable.Location = new System.Drawing.Point(51, 126);
            this.usernamelable.Name = "usernamelable";
            this.usernamelable.Size = new System.Drawing.Size(83, 20);
            this.usernamelable.TabIndex = 2;
            this.usernamelable.Text = "Username";
            this.usernamelable.Click += new System.EventHandler(this.usernamelable_Click);
            // 
            // adminlable
            // 
            this.adminlable.AutoSize = true;
            this.adminlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlable.Location = new System.Drawing.Point(51, 158);
            this.adminlable.Name = "adminlable";
            this.adminlable.Size = new System.Drawing.Size(72, 20);
            this.adminlable.TabIndex = 1;
            this.adminlable.Text = "Manager";
            this.adminlable.Click += new System.EventHandler(this.adminlable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titalnamelbl
            // 
            this.titalnamelbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titalnamelbl.Controls.Add(this.titlelable);
            this.titalnamelbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titalnamelbl.Location = new System.Drawing.Point(297, 0);
            this.titalnamelbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titalnamelbl.Name = "titalnamelbl";
            this.titalnamelbl.Size = new System.Drawing.Size(1032, 62);
            this.titalnamelbl.TabIndex = 1;
            this.titalnamelbl.Paint += new System.Windows.Forms.PaintEventHandler(this.titalnamelbl_Paint);
            // 
            // titlelable
            // 
            this.titlelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.Location = new System.Drawing.Point(329, 12);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(349, 34);
            this.titlelable.TabIndex = 0;
            this.titlelable.Text = "Title Name";
            this.titlelable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titlelable.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(297, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1032, 811);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 873);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.titalnamelbl);
            this.Controls.Add(this.dashboardpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Main_Load);
            this.dashboardpanel.ResumeLayout(false);
            this.panelsubstock.ResumeLayout(false);
            this.panelsubpro.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titalnamelbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboardpanel;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Panel panelsubpro;
        private System.Windows.Forms.Button brandbtn;
        private System.Windows.Forms.Button categorybtn;
        private System.Windows.Forms.Button productlistbtn;
        private System.Windows.Forms.Button Productbtn;
        private System.Windows.Forms.Label usernamelable;
        private System.Windows.Forms.Label adminlable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titalnamelbl;
        private System.Windows.Forms.Button instockbtn;
        private System.Windows.Forms.Panel panelsubstock;
        private System.Windows.Forms.Button stcokadjustmentbtn;
        private System.Windows.Forms.Button stockentrybtn;
        private System.Windows.Forms.Button supllierbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.Panel panelMain;
    }
}