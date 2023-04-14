using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelfUI
{
    public partial class LoginForm : Form
    {
        ProjectConnection SQLtoLoginForm = new ProjectConnection();
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public LoginForm()
        {
            InitializeComponent();
            sqlcon = SQLtoLoginForm.getConnection();

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show(" Please Complete Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set up the SQL command with parameters for the login credentials
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
            cmd = new SqlCommand(query, sqlcon);
            cmd.Parameters.AddWithValue("@username", LoginTextBox.Text);
            cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);

            try
            {
                sqlcon.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    //MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Redirect to main form or perform other actions

                    this.Hide();
                    Inventory IVOpen = new Inventory();
                    IVOpen.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid login credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlcon.Close();
            }

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        //Opens ForgotPasswordForm
        private void ForgotPassLabel_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm FPForm = new ForgotPasswordForm();
            FPForm.Show();
        }
    }

}
