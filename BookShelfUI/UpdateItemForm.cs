using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShelfUI
{

    public partial class UpdateItemForm : Form
    {

        ProjectConnection SQLtoAddItem = new ProjectConnection();
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        private bool changesMade = true;
        private Inventory _inventoryForm;
        private DataGridViewRow selectedRow;

        public UpdateItemForm(Inventory inventoryForm)
        {
            InitializeComponent();
            sqlcon = SQLtoAddItem.getConnection();
            _inventoryForm = inventoryForm;
        }


        // Loads selected row from Inventory From to TextBox of UpdateItemForm
        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            ItemTextBox.Text = Inventory.selectRow.Cells[1].Value.ToString();
            CodeTextBox.Text = Inventory.selectRow.Cells[2].Value.ToString();
            BrandTextBox.Text = Inventory.selectRow.Cells[3].Value.ToString();
            PriceTextBox.Text = Inventory.selectRow.Cells[4].Value.ToString();
            QuantityTextBox.Text = Inventory.selectRow.Cells[5].Value.ToString();
        }


        private void TextChangedEvent(object sender, EventArgs e)
        {
            changesMade = false;
        }

        // Saves the selected data

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Error statement if Text Box fields are empty
            if (String.IsNullOrEmpty(ItemTextBox.Text) || String.IsNullOrEmpty(CodeTextBox.Text) || String.IsNullOrEmpty(BrandTextBox.Text) || String.IsNullOrEmpty(ItemTextBox.Text) || String.IsNullOrEmpty(PriceTextBox.Text) || String.IsNullOrEmpty(QuantityTextBox.Text))
            {
                MessageBox.Show(" Please Complete Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Saves the updated item in the database
            else
            {
                sqlcon.Open();
                cmd = new SqlCommand(" UPDATE Items SET Name=@Name, Code=@Code, Brand=@Brand, Price=@Price, Quantity=@Quantity WHERE Id =@Id", sqlcon);

                cmd.Parameters.AddWithValue("@Name", ItemTextBox.Text);
                cmd.Parameters.AddWithValue("@Code", int.Parse(CodeTextBox.Text));
                cmd.Parameters.AddWithValue("@Brand", BrandTextBox.Text);
                cmd.Parameters.AddWithValue("@Price", double.Parse(PriceTextBox.Text));
                cmd.Parameters.AddWithValue("@Quantity", double.Parse(QuantityTextBox.Text));
                cmd.Parameters.AddWithValue("@ID", Inventory.selectRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                StatusMessage.Text = "Item Added to Database!";
                sqlcon.Close();
                this.Close();
                _inventoryForm.LoadDataToGrid();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (!changesMade)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Do you want to save your changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Save data
                    changesMade = true;
                    this.Close();
                }
                else
                {
                    this.Close();

                }
            }
        }
    }
}
