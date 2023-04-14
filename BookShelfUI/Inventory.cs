using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BookShelfUI
{
    public partial class Inventory : Form
    {
        public Inventory()
        {

            InitializeComponent();

            // Loading 'Items' database to GridView
            LoadDataToGrid();

        }

        ProjectConnection dbconnect = new ProjectConnection();
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;


        //Initializes and Populates the DataGridView with Data from ItemsDB
        public void LoadDataToGrid()
        {
            cmd = new SqlCommand("SELECT * FROM Items", dbconnect.getConnection());
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DataView ItemSearch = dt.DefaultView;
            ItemSearch.RowFilter = "Name Like '%" + SearchBox.Text + "%'";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            AddItemForm AIForm = new AddItemForm(this);
            AIForm.Show();


        }


        public static DataGridViewRow selectRow;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectRow = dataGridView1.Rows[e.RowIndex];

                UpdateItemForm UForm = new UpdateItemForm(this);
                UForm.ShowDialog();
            }
        }

        private void RemoveItemBttn_Click(object sender, EventArgs e)
        {
            sqlcon = dbconnect.getConnection();
            //cmd = new SqlCommand("DELETE FROM Items", sqlcon);
            //sqlcon.Open();
            //cmd.ExecuteNonQuery();
            //sqlcon.Close();
            //MessageBox.Show("Item is Deleted!");


            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex != -1)
            {
                int itemID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Delete from database
                    sqlcon.Open();
                    cmd = new SqlCommand("DELETE FROM Items WHERE ID=@ID", sqlcon);
                    cmd.Parameters.AddWithValue("@ID", itemID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item has been deleted.");
                        LoadDataToGrid(); //reload data to grid after deletion
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        // Button for ManageAdmins Form
        private void PrintButton_Click(object sender, EventArgs e)
        {
            ManageAdmins OpenMA = new ManageAdmins();
            OpenMA.Show();
        }
    }
}