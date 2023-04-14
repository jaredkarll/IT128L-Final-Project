namespace BookShelfUI
{
    partial class Inventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            SearchBox = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            Login = new Button();
            panel1 = new Panel();
            PrintButton = new Button();
            RemoveItemBttn = new Button();
            AddItem = new Button();
            ExitButton = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(206, 52);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(533, 23);
            SearchBox.TabIndex = 5;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(144, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(595, 341);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button4
            // 
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            Login.Location = new Point(0, 32);
            Login.Name = "Login";
            Login.Size = new Size(126, 46);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(PrintButton);
            panel1.Controls.Add(RemoveItemBttn);
            panel1.Controls.Add(AddItem);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 435);
            panel1.TabIndex = 7;
            // 
            // PrintButton
            // 
            PrintButton.BackColor = Color.MidnightBlue;
            PrintButton.FlatAppearance.BorderSize = 0;
            PrintButton.FlatStyle = FlatStyle.Flat;
            PrintButton.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PrintButton.ForeColor = Color.White;
            PrintButton.ImageAlign = ContentAlignment.MiddleLeft;
            PrintButton.Location = new Point(3, 228);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(132, 45);
            PrintButton.TabIndex = 6;
            PrintButton.Text = "Manage Admins";
            PrintButton.UseVisualStyleBackColor = false;
            PrintButton.Click += PrintButton_Click;
            // 
            // RemoveItemBttn
            // 
            RemoveItemBttn.BackColor = Color.MidnightBlue;
            RemoveItemBttn.FlatAppearance.BorderSize = 0;
            RemoveItemBttn.FlatStyle = FlatStyle.Flat;
            RemoveItemBttn.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveItemBttn.ForeColor = Color.White;
            RemoveItemBttn.Image = (Image)resources.GetObject("RemoveItemBttn.Image");
            RemoveItemBttn.ImageAlign = ContentAlignment.MiddleLeft;
            RemoveItemBttn.Location = new Point(3, 189);
            RemoveItemBttn.Name = "RemoveItemBttn";
            RemoveItemBttn.Size = new Size(132, 45);
            RemoveItemBttn.TabIndex = 3;
            RemoveItemBttn.Text = "Remove Item";
            RemoveItemBttn.TextAlign = ContentAlignment.MiddleRight;
            RemoveItemBttn.UseVisualStyleBackColor = false;
            RemoveItemBttn.Click += RemoveItemBttn_Click;
            // 
            // AddItem
            // 
            AddItem.BackColor = Color.MidnightBlue;
            AddItem.FlatAppearance.BorderSize = 0;
            AddItem.FlatStyle = FlatStyle.Flat;
            AddItem.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddItem.ForeColor = Color.White;
            AddItem.Image = (Image)resources.GetObject("AddItem.Image");
            AddItem.ImageAlign = ContentAlignment.MiddleLeft;
            AddItem.Location = new Point(3, 147);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(132, 45);
            AddItem.TabIndex = 2;
            AddItem.Text = "Add Item";
            AddItem.UseVisualStyleBackColor = false;
            AddItem.Click += AddItem_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.IndianRed;
            ExitButton.Dock = DockStyle.Bottom;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(0, 390);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(138, 45);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(144, 52);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 9);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 10;
            label3.Text = "INVENTORY";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 435);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchBox;
        private Button Login;
        private Button button4;
        private Panel panel1;
        private Button ExitButton;
        private Label label2;
        private Label label3;
        private Button AddItem;
        public DataGridView dataGridView1;
        private Button RemoveItemBttn;
        private PictureBox pictureBox1;
        private Button PrintButton;

    }
}