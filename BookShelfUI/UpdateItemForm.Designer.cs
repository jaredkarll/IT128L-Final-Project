namespace BookShelfUI
{
    partial class UpdateItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemForm));
            QuantityTextBox = new TextBox();
            QuantityLabel = new Label();
            PriceTextBox = new TextBox();
            BrandTextBox = new TextBox();
            CodeTextBox = new TextBox();
            BrandLabel = new Label();
            PriceLabel = new Label();
            CodeLabel = new Label();
            ItemNameLabel = new Label();
            ItemTextBox = new TextBox();
            CancelButton = new Button();
            SaveButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            StatusLabel = new Label();
            StatusMessage = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(130, 189);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(271, 23);
            QuantityTextBox.TabIndex = 23;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityLabel.ForeColor = Color.White;
            QuantityLabel.Location = new Point(30, 192);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(62, 18);
            QuantityLabel.TabIndex = 22;
            QuantityLabel.Text = "Quantity";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(130, 152);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(271, 23);
            PriceTextBox.TabIndex = 21;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(130, 111);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(271, 23);
            BrandTextBox.TabIndex = 20;
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(130, 71);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(271, 23);
            CodeTextBox.TabIndex = 19;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BrandLabel.ForeColor = Color.White;
            BrandLabel.Location = new Point(30, 114);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(44, 18);
            BrandLabel.TabIndex = 18;
            BrandLabel.Text = "Brand";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.ForeColor = Color.White;
            PriceLabel.Location = new Point(30, 155);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(39, 18);
            PriceLabel.TabIndex = 17;
            PriceLabel.Text = "Price";
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CodeLabel.ForeColor = Color.White;
            CodeLabel.Location = new Point(30, 72);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(44, 18);
            CodeLabel.TabIndex = 16;
            CodeLabel.Text = "Code:";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLabel.ForeColor = Color.White;
            ItemNameLabel.Location = new Point(30, 28);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(81, 18);
            ItemNameLabel.TabIndex = 15;
            ItemNameLabel.Text = "Item Name:";
            // 
            // ItemTextBox
            // 
            ItemTextBox.Location = new Point(130, 25);
            ItemTextBox.Name = "ItemTextBox";
            ItemTextBox.Size = new Size(271, 23);
            ItemTextBox.TabIndex = 14;
            ItemTextBox.TextChanged += TextChangedEvent;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Crimson;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(219, 0);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(220, 41);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Lime;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.Location = new Point(0, 0);
            SaveButton.Margin = new Padding(0);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(219, 41);
            SaveButton.TabIndex = 24;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SaveButton, 0, 0);
            tableLayoutPanel1.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 274);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(439, 41);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabel.ForeColor = Color.White;
            StatusLabel.Location = new Point(30, 232);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(50, 18);
            StatusLabel.TabIndex = 27;
            StatusLabel.Text = "Status:";
            // 
            // StatusMessage
            // 
            StatusMessage.AutoSize = true;
            StatusMessage.Location = new Point(130, 235);
            StatusMessage.Name = "StatusMessage";
            StatusMessage.Size = new Size(0, 15);
            StatusMessage.TabIndex = 28;
            // 
            // UpdateItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(439, 315);
            Controls.Add(StatusMessage);
            Controls.Add(StatusLabel);
            Controls.Add(QuantityTextBox);
            Controls.Add(QuantityLabel);
            Controls.Add(PriceTextBox);
            Controls.Add(BrandTextBox);
            Controls.Add(CodeTextBox);
            Controls.Add(BrandLabel);
            Controls.Add(PriceLabel);
            Controls.Add(CodeLabel);
            Controls.Add(ItemNameLabel);
            Controls.Add(ItemTextBox);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateItemForm";
            Text = "Update Item";
            Load += UpdateItemForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuantityTextBox;
        private Label QuantityLabel;
        private TextBox PriceTextBox;
        private TextBox BrandTextBox;
        private TextBox CodeTextBox;
        private Label BrandLabel;
        private Label PriceLabel;
        private Label CodeLabel;
        private Label ItemNameLabel;
        private TextBox ItemTextBox;
        private Button CancelButton;
        private Button SaveButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label StatusLabel;
        private Label StatusMessage;
    }
}