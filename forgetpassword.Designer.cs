namespace WindowsFormsApp1
{
    partial class forgetpassword
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
            this.confrimpasswordlbl = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.textBoxnewpassword = new System.Windows.Forms.TextBox();
            this.textBoxconfrimpassword = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confrimpasswordlbl
            // 
            this.confrimpasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimpasswordlbl.Location = new System.Drawing.Point(11, 90);
            this.confrimpasswordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confrimpasswordlbl.Name = "confrimpasswordlbl";
            this.confrimpasswordlbl.Size = new System.Drawing.Size(174, 19);
            this.confrimpasswordlbl.TabIndex = 1;
            this.confrimpasswordlbl.Text = "Confrim  Password :";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(167, 147);
            this.savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(74, 25);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save ";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // textBoxnewpassword
            // 
            this.textBoxnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnewpassword.Location = new System.Drawing.Point(160, 50);
            this.textBoxnewpassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnewpassword.Name = "textBoxnewpassword";
            this.textBoxnewpassword.Size = new System.Drawing.Size(182, 26);
            this.textBoxnewpassword.TabIndex = 3;
            this.textBoxnewpassword.TextChanged += new System.EventHandler(this.textBoxnewpassword_TextChanged);
            // 
            // textBoxconfrimpassword
            // 
            this.textBoxconfrimpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxconfrimpassword.Location = new System.Drawing.Point(160, 87);
            this.textBoxconfrimpassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxconfrimpassword.Name = "textBoxconfrimpassword";
            this.textBoxconfrimpassword.Size = new System.Drawing.Size(182, 26);
            this.textBoxconfrimpassword.TabIndex = 4;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(267, 147);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(74, 25);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(18, 50);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(124, 19);
            this.usernamelbl.TabIndex = 0;
            this.usernamelbl.Text = "user Name : ";
            // 
            // forgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 209);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.textBoxconfrimpassword);
            this.Controls.Add(this.textBoxnewpassword);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.confrimpasswordlbl);
            this.Controls.Add(this.usernamelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "forgetpassword";
            this.Text = "forgetpasswordcs";
            this.Load += new System.EventHandler(this.forgetpassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label confrimpasswordlbl;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox textBoxnewpassword;
        private System.Windows.Forms.TextBox textBoxconfrimpassword;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label usernamelbl;
    }
}