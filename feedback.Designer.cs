namespace WindowsFormsApp1
{
    partial class feedback
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
            this.productnamelable = new System.Windows.Forms.Label();
            this.feedbackcommentlbl = new System.Windows.Forms.Label();
            this.ratinglbl = new System.Windows.Forms.Label();
            this.textBoxfeedpname = new System.Windows.Forms.TextBox();
            this.textBoxcomment = new System.Windows.Forms.TextBox();
            this.comboBoxrating = new System.Windows.Forms.ComboBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // productnamelable
            // 
            this.productnamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamelable.Location = new System.Drawing.Point(49, 47);
            this.productnamelable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productnamelable.Name = "productnamelable";
            this.productnamelable.Size = new System.Drawing.Size(101, 20);
            this.productnamelable.TabIndex = 1;
            this.productnamelable.Text = "Product Name : ";
            // 
            // feedbackcommentlbl
            // 
            this.feedbackcommentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackcommentlbl.Location = new System.Drawing.Point(49, 93);
            this.feedbackcommentlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feedbackcommentlbl.Name = "feedbackcommentlbl";
            this.feedbackcommentlbl.Size = new System.Drawing.Size(101, 20);
            this.feedbackcommentlbl.TabIndex = 2;
            this.feedbackcommentlbl.Text = "Comment : ";
            // 
            // ratinglbl
            // 
            this.ratinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratinglbl.Location = new System.Drawing.Point(49, 147);
            this.ratinglbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratinglbl.Name = "ratinglbl";
            this.ratinglbl.Size = new System.Drawing.Size(101, 20);
            this.ratinglbl.TabIndex = 3;
            this.ratinglbl.Text = "Rating :";
            // 
            // textBoxfeedpname
            // 
            this.textBoxfeedpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfeedpname.Location = new System.Drawing.Point(185, 45);
            this.textBoxfeedpname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxfeedpname.Name = "textBoxfeedpname";
            this.textBoxfeedpname.Size = new System.Drawing.Size(308, 26);
            this.textBoxfeedpname.TabIndex = 4;
            // 
            // textBoxcomment
            // 
            this.textBoxcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcomment.Location = new System.Drawing.Point(185, 90);
            this.textBoxcomment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxcomment.Name = "textBoxcomment";
            this.textBoxcomment.Size = new System.Drawing.Size(308, 26);
            this.textBoxcomment.TabIndex = 5;
            // 
            // comboBoxrating
            // 
            this.comboBoxrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxrating.FormattingEnabled = true;
            this.comboBoxrating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxrating.Location = new System.Drawing.Point(185, 147);
            this.comboBoxrating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxrating.Name = "comboBoxrating";
            this.comboBoxrating.Size = new System.Drawing.Size(114, 28);
            this.comboBoxrating.TabIndex = 6;
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(406, 211);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 27);
            this.Savebtn.TabIndex = 16;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(35, 217);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 17;
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 275);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.comboBoxrating);
            this.Controls.Add(this.textBoxcomment);
            this.Controls.Add(this.textBoxfeedpname);
            this.Controls.Add(this.ratinglbl);
            this.Controls.Add(this.feedbackcommentlbl);
            this.Controls.Add(this.productnamelable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "feedback";
            this.Text = "feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productnamelable;
        private System.Windows.Forms.Label feedbackcommentlbl;
        private System.Windows.Forms.Label ratinglbl;
        private System.Windows.Forms.TextBox textBoxfeedpname;
        private System.Windows.Forms.TextBox textBoxcomment;
        private System.Windows.Forms.ComboBox comboBoxrating;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}