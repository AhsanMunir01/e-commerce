using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class feedback : Form
    {
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtProductId;

        private string connectionString = @"DATA SOURCE=localhost:1521/XE; USER ID=database; PASSWORD=database";
        private int currentUserId; // Assume this is set from the login process
        private int currentProductId;
        public feedback(int userId, int productId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.currentProductId = productId;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cloasepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();

                    int nextFeedbackId = GetNextFeedbackId(conn);

                    decimal rating = Convert.ToDecimal(comboBoxrating.SelectedItem); // Get selected rating
                    InsertFeedback(conn, nextFeedbackId, currentUserId, currentProductId, textBoxcomment.Text, rating);

                    MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxcomment.Clear();
                    comboBoxrating.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void feedback_Load(object sender, EventArgs e)
        {
            txtUserId.Text = currentUserId.ToString();
            txtProductId.Text = currentProductId.ToString();
        }

        private int GetNextFeedbackId(OracleConnection conn)
        {
            using (OracleCommand cmd = new OracleCommand("SELECT NVL(MAX(FEEDBACKID), 0) + 1 AS NextId FROM FEEDBACK", conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        private void InsertFeedback(OracleConnection conn, int feedbackId, int userId, int productId, string comment, decimal rating)
        {
            using (OracleCommand cmd = new OracleCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO FEEDBACK (FEEDBACKID, USERID, PRODUCTID, FEEDBACKCOMMENT, RATING, FEEDBACKDATE) VALUES (:feedbackId, :userId, :productId, :comment, :rating, SYSDATE)";
                cmd.Parameters.Add(":feedbackId", OracleDbType.Int32).Value = feedbackId;
                cmd.Parameters.Add(":userId", OracleDbType.Int32).Value = userId;
                cmd.Parameters.Add(":productId", OracleDbType.Int32).Value = productId;
                cmd.Parameters.Add(":comment", OracleDbType.Varchar2).Value = comment;
                cmd.Parameters.Add(":rating", OracleDbType.Decimal).Value = rating;


                cmd.ExecuteNonQuery();
            }
        }
    }
}
