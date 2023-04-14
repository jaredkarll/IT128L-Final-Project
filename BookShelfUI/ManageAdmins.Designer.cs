namespace BookShelfUI
{
    partial class ManageAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdmins));
            panel1 = new Panel();
            ManageAdminsDGV = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            EditButton = new Button();
            AddButton = new Button();
            DeleteButton = new Button();
            LNTextBox = new TextBox();
            FNTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageAdminsDGV).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ManageAdminsDGV);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 214);
            panel1.TabIndex = 0;
            // 
            // ManageAdminsDGV
            // 
            ManageAdminsDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ManageAdminsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ManageAdminsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ManageAdminsDGV.Location = new Point(12, 13);
            ManageAdminsDGV.Name = "ManageAdminsDGV";
            ManageAdminsDGV.RowTemplate.Height = 25;
            ManageAdminsDGV.Size = new Size(506, 190);
            ManageAdminsDGV.TabIndex = 0;
            ManageAdminsDGV.CellDoubleClick += ManageAdminsDGV_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 40);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(40, 8);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Admins";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(LNTextBox);
            panel3.Controls.Add(FNTextBox);
            panel3.Controls.Add(PasswordTextBox);
            panel3.Controls.Add(UsernameTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 197);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(EditButton, 0, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 1, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 2, 0);
            tableLayoutPanel1.Location = new Point(30, 154);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(474, 36);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Orange;
            EditButton.Dock = DockStyle.Fill;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.Location = new Point(0, 0);
            EditButton.Margin = new Padding(0);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(157, 36);
            EditButton.TabIndex = 0;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkSeaGreen;
            AddButton.Dock = DockStyle.Fill;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(157, 0);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(157, 36);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.IndianRed;
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.Location = new Point(314, 0);
            DeleteButton.Margin = new Padding(0);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(160, 36);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // LNTextBox
            // 
            LNTextBox.Location = new Point(193, 118);
            LNTextBox.Name = "LNTextBox";
            LNTextBox.Size = new Size(270, 23);
            LNTextBox.TabIndex = 7;
            // 
            // FNTextBox
            // 
            FNTextBox.Location = new Point(193, 84);
            FNTextBox.Name = "FNTextBox";
            FNTextBox.Size = new Size(270, 23);
            FNTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(193, 50);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(270, 23);
            PasswordTextBox.TabIndex = 5;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(193, 16);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(270, 23);
            UsernameTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 53);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 3;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 19);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 2;
            label4.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 121);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 1;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 87);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ManageAdmins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageAdmins";
            Text = "ManageAdmins";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageAdminsDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView ManageAdminsDGV;
        private Label label1;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox LNTextBox;
        private TextBox FNTextBox;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button EditButton;
        private Button AddButton;
        private Button DeleteButton;
        private PictureBox pictureBox1;
    }
}