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

namespace BookShelfUI
{
    public partial class ManageAdmins : Form
    {
        public ManageAdmins()
        {
            InitializeComponent();
            LoadDataToGrid();
        }


        ProjectConnection dbconnect = new ProjectConnection();
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        private DataGridViewRow selectRow;


        //Initializes and Populates the DataGridView with Data from UsersDB
        public void LoadDataToGrid()
        {
            cmd = new SqlCommand("SELECT * FROM Users", dbconnect.getConnection());
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            ManageAdminsDGV.DataSource = dt;

        }


        //Edit or Update Function
        private void EditButton_Click(object sender, EventArgs e)
        {
            sqlcon = dbconnect.getConnection();


            if (String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text) || String.IsNullOrEmpty(FNTextBox.Text) || String.IsNullOrEmpty(LNTextBox.Text))
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    sqlcon.Open();
                    cmd = new SqlCommand("UPDATE Users SET UserName=@UserName, Password=@Password, FirstName=@FirstName, LastName=@LastName WHERE Id=@Id", sqlcon);

                    cmd.Parameters.AddWithValue("@UserName", UsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@FirstName", FNTextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", LNTextBox.Text);
                    cmd.Parameters.AddWithValue("@Id", ManageAdminsDGV.CurrentRow.Cells["Id"].Value);

                    ClearAllTextBox();          // Clears all Texbox
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    LoadDataToGrid();
                }
            }

        }


        //Add Function
        private void AddButton_Click(object sender, EventArgs e)
        {
            sqlcon = dbconnect.getConnection();

            if (String.IsNullOrEmpty(UsernameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text) || String.IsNullOrEmpty(FNTextBox.Text) || String.IsNullOrEmpty(LNTextBox.Text))
            {
                MessageBox.Show(" Please Complete Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sqlcon.Open();
                cmd = new SqlCommand(" INSERT INTO Users(Username, Password, FirstName, LastName) VALUES ('" + UsernameTextBox.Text + "' , '" + PasswordTextBox.Text + "' , '" + FNTextBox.Text + "' , '" + LNTextBox.Text + "')", sqlcon);
                cmd.ExecuteNonQuery();
                //LabelStatus.Text = "Item Added to Database!";
                sqlcon.Close();
                LoadDataToGrid();

                //Clears all text in Text Boxes
                ClearAllTextBox();
            }
        }


        // Delete Function
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            sqlcon = dbconnect.getConnection();


            int selectedIndex = ManageAdminsDGV.CurrentCell.RowIndex;
            if (selectedIndex != -1)
            {
                int UserID = Convert.ToInt32(ManageAdminsDGV.Rows[selectedIndex].Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Admin", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Delete from database
                    sqlcon.Open();
                    cmd = new SqlCommand("DELETE FROM Users WHERE ID=@ID", sqlcon);
                    cmd.Parameters.AddWithValue("@ID", UserID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin has been deleted.");
                        LoadDataToGrid(); //reload data to grid after deletion
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }


        //DataGridView Cell Double Click Event that allows the Admin to Edit/Update Admin Information
        //Double Click Event was used so that other users does not accidentally edit other Admin Information
        private void ManageAdminsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ManageAdminsDGV.Rows[e.RowIndex];
                UsernameTextBox.Text = row.Cells["Username"].Value.ToString();
                PasswordTextBox.Text = row.Cells["Password"].Value.ToString();
                FNTextBox.Text = row.Cells["FirstName"].Value.ToString();
                LNTextBox.Text = row.Cells["LastName"].Value.ToString();
            }
        }



        // Clears all Text Boxes Method
        private void ClearAllTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
    }
}
