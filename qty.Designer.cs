﻿namespace WindowsFormsApp1
{
    partial class qty
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
            this.textBoxqty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxqty
            // 
            this.textBoxqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxqty.Location = new System.Drawing.Point(12, 12);
            this.textBoxqty.Name = "textBoxqty";
            this.textBoxqty.Size = new System.Drawing.Size(177, 50);
            this.textBoxqty.TabIndex = 0;
            this.textBoxqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxqty_KeyPress);
            // 
            // qty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 77);
            this.Controls.Add(this.textBoxqty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "qty";
            this.Text = "Qty";
            this.Load += new System.EventHandler(this.qty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxqty;
    }
}