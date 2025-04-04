namespace WindowsFormsApp1
{
    partial class userprofile
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
            this.namelbl = new System.Windows.Forms.Label();
            this.personalinfollb = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.emaillbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.phonenolbl = new System.Windows.Forms.Label();
            this.accountsecurritylbl = new System.Windows.Forms.Label();
            this.forgetpasswordlinllbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.Location = new System.Drawing.Point(2, 63);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(128, 30);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Full Name :";
            // 
            // personalinfollb
            // 
            this.personalinfollb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalinfollb.Location = new System.Drawing.Point(1, 9);
            this.personalinfollb.Name = "personalinfollb";
            this.personalinfollb.Size = new System.Drawing.Size(293, 30);
            this.personalinfollb.TabIndex = 1;
            this.personalinfollb.Text = "Personal Information ";
            // 
            // usernamelbl
            // 
            this.usernamelbl.Location = new System.Drawing.Point(2, 102);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(128, 30);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "User Name : ";
            // 
            // emaillbl
            // 
            this.emaillbl.Location = new System.Drawing.Point(2, 144);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(128, 30);
            this.emaillbl.TabIndex = 3;
            this.emaillbl.Text = "E-mail : ";
            // 
            // Addresslbl
            // 
            this.Addresslbl.Location = new System.Drawing.Point(2, 185);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(128, 30);
            this.Addresslbl.TabIndex = 4;
            this.Addresslbl.Text = "Address : ";
            // 
            // phonenolbl
            // 
            this.phonenolbl.Location = new System.Drawing.Point(2, 228);
            this.phonenolbl.Name = "phonenolbl";
            this.phonenolbl.Size = new System.Drawing.Size(128, 30);
            this.phonenolbl.TabIndex = 5;
            this.phonenolbl.Text = "Phone #";
            // 
            // accountsecurritylbl
            // 
            this.accountsecurritylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsecurritylbl.Location = new System.Drawing.Point(1, 293);
            this.accountsecurritylbl.Name = "accountsecurritylbl";
            this.accountsecurritylbl.Size = new System.Drawing.Size(293, 30);
            this.accountsecurritylbl.TabIndex = 6;
            this.accountsecurritylbl.Text = "Account Security  ";
            // 
            // forgetpasswordlinllbl
            // 
            this.forgetpasswordlinllbl.AutoSize = true;
            this.forgetpasswordlinllbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.forgetpasswordlinllbl.Location = new System.Drawing.Point(12, 343);
            this.forgetpasswordlinllbl.Name = "forgetpasswordlinllbl";
            this.forgetpasswordlinllbl.Size = new System.Drawing.Size(137, 20);
            this.forgetpasswordlinllbl.TabIndex = 7;
            this.forgetpasswordlinllbl.TabStop = true;
            this.forgetpasswordlinllbl.Text = "Forget Passowrd :";
            this.forgetpasswordlinllbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetpasswordlinllbl_LinkClicked);
            // 
            // userprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.forgetpasswordlinllbl);
            this.Controls.Add(this.accountsecurritylbl);
            this.Controls.Add(this.phonenolbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.personalinfollb);
            this.Controls.Add(this.namelbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userprofile";
            this.Text = "userprofile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label personalinfollb;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label phonenolbl;
        private System.Windows.Forms.Label accountsecurritylbl;
        private System.Windows.Forms.LinkLabel forgetpasswordlinllbl;
    }
}