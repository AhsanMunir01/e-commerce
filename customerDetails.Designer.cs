namespace WindowsFormsApp1
{
    partial class customerDetails
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
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.phonenolbl = new System.Windows.Forms.Label();
            this.phonenotxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(131, 64);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(341, 26);
            this.addresstxt.TabIndex = 0;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(28, 64);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(76, 20);
            this.addresslbl.TabIndex = 1;
            this.addresslbl.Text = "Address :";
            this.addresslbl.Click += new System.EventHandler(this.addresslbl_Click);
            // 
            // phonenolbl
            // 
            this.phonenolbl.AutoSize = true;
            this.phonenolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenolbl.Location = new System.Drawing.Point(28, 120);
            this.phonenolbl.Name = "phonenolbl";
            this.phonenolbl.Size = new System.Drawing.Size(68, 20);
            this.phonenolbl.TabIndex = 2;
            this.phonenolbl.Text = "Phone #";
            // 
            // phonenotxt
            // 
            this.phonenotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenotxt.Location = new System.Drawing.Point(131, 126);
            this.phonenotxt.Name = "phonenotxt";
            this.phonenotxt.Size = new System.Drawing.Size(341, 26);
            this.phonenotxt.TabIndex = 3;
            // 
            // savebtn
            // 
            this.savebtn.AutoSize = true;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(203, 180);
            this.savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(122, 36);
            this.savebtn.TabIndex = 37;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // customerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 251);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.phonenotxt);
            this.Controls.Add(this.phonenolbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.addresstxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerDetails";
            this.Text = "customerDetails";
            this.Load += new System.EventHandler(this.customerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label phonenolbl;
        private System.Windows.Forms.TextBox phonenotxt;
        private System.Windows.Forms.Button savebtn;
    }
}