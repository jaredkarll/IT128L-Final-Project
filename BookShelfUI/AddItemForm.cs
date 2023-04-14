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
    public partial class AddItemForm : Form
    {
        ProjectConnection SQLtoAddItem = new ProjectConnection();
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private Inventory _inventoryForm;
        private bool changesMade = true;

        public AddItemForm(Inventory inventoryForm)
        {
            InitializeComponent();
            sqlcon = SQLtoAddItem.getConnection();
            _inventoryForm = inventoryForm;
        }



        private void AddButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(ItemTextBox.Text) || String.IsNullOrEmpty(CodeTextBox.Text) || String.IsNullOrEmpty(BrandTextBox.Text) || String.IsNullOrEmpty(ItemTextBox.Text) || String.IsNullOrEmpty(PriceTextBox.Text) || String.IsNullOrEmpty(QuantityTextBox.Text))
            {
                MessageBox.Show(" Please Complete Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sqlcon.Open();
                cmd = new SqlCommand(" INSERT INTO Items(Name, Code, Brand, Price, Quantity) VALUES ('" + ItemTextBox.Text + "' , '" + CodeTextBox.Text + "' , '" + BrandTextBox.Text + "' , '" + PriceTextBox.Text + "' , '" + QuantityTextBox.Text + "' )", sqlcon);
                cmd.ExecuteNonQuery();
                LabelStatus.Text = "Item Added to Database!";
                sqlcon.Close();
                _inventoryForm.LoadDataToGrid();

                //Clears all text in Text Boxes
                ClearAllTextBox();
            }

        }



        private void TextChangedEvent(object sender, EventArgs e)
        {
            changesMade = false;
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

                    //Checks if the there are TextBoxes that are empty
                    if (String.IsNullOrEmpty(ItemTextBox.Text) || String.IsNullOrEmpty(CodeTextBox.Text) || String.IsNullOrEmpty(BrandTextBox.Text) || String.IsNullOrEmpty(ItemTextBox.Text) || String.IsNullOrEmpty(PriceTextBox.Text) || String.IsNullOrEmpty(QuantityTextBox.Text))
                    {
                        MessageBox.Show(" Please Complete Fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Saves the data inputted to the Database
                    else
                    {
                        sqlcon.Open();
                        cmd = new SqlCommand(" INSERT INTO Items(Name, Code, Brand, Price, Quantity) VALUES ('" + ItemTextBox.Text + "' , '" + CodeTextBox.Text + "' , '" + BrandTextBox.Text + "' , '" + PriceTextBox.Text + "' , '" + QuantityTextBox.Text + "' )", sqlcon);
                        cmd.ExecuteNonQuery();
                        StatusMessage.Text = "Item Added to Database!";
                        sqlcon.Close();
                        _inventoryForm.LoadDataToGrid();
                    }

                    ClearAllTextBox();
                    //this.Close();
                }
                else
                {
                    this.Close();

                }
            }
            this.Close();
        }



        // function to clear all Text Box
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
