using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookShelfUI
{
    public partial class ForgotPasswordForm : Form
    {

        ProjectConnection SQLtoForgotPassForm = new ProjectConnection();
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public ForgotPasswordForm()
        {
            InitializeComponent();
            sqlcon = SQLtoForgotPassForm.getConnection();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string newPassword = NewPassTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(ReEnterPassTextBox.Text))
            {
                MessageBox.Show("Please provide all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand cmdSelect = new SqlCommand(query, sqlcon);
                cmdSelect.Parameters.AddWithValue("@Username", username);
                sqlcon.Open();
                int count = (int)cmdSelect.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlcon.Close();
                    return;
                }
                sqlcon.Close();

                var updateQuery = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                SqlCommand cmdUpdate = new SqlCommand(updateQuery, sqlcon);
                cmdUpdate.Parameters.AddWithValue("@Username", username);
                cmdUpdate.Parameters.AddWithValue("@Password", newPassword);
                sqlcon.Open();
                int rowsAffected = cmdUpdate.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlcon.Close();
            }

            this.Close();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
