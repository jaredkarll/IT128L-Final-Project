namespace BookShelfUI
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            ItemTextBox = new TextBox();
            ItemNameLabel = new Label();
            CodeLabel = new Label();
            PriceLabel = new Label();
            BrandLabel = new Label();
            CodeTextBox = new TextBox();
            BrandTextBox = new TextBox();
            PriceTextBox = new TextBox();
            AddButton = new Button();
            CancelButton = new Button();
            StatusLabel = new Label();
            StatusMessage = new Label();
            QuantityTextBox = new TextBox();
            QuantityLabel = new Label();
            LabelStatus = new Label();
            SuspendLayout();
            // 
            // ItemTextBox
            // 
            ItemTextBox.Location = new Point(150, 42);
            ItemTextBox.Name = "ItemTextBox";
            ItemTextBox.Size = new Size(271, 23);
            ItemTextBox.TabIndex = 0;
            ItemTextBox.TextChanged += TextChangedEvent;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLabel.ForeColor = Color.White;
            ItemNameLabel.Location = new Point(50, 45);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(81, 18);
            ItemNameLabel.TabIndex = 1;
            ItemNameLabel.Text = "Item Name:";
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CodeLabel.ForeColor = Color.White;
            CodeLabel.Location = new Point(50, 89);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(44, 18);
            CodeLabel.TabIndex = 2;
            CodeLabel.Text = "Code:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.ForeColor = Color.White;
            PriceLabel.Location = new Point(50, 172);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(39, 18);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "Price";
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BrandLabel.ForeColor = Color.White;
            BrandLabel.Location = new Point(50, 131);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(44, 18);
            BrandLabel.TabIndex = 4;
            BrandLabel.Text = "Brand";
            // 
            // CodeTextBox
            // 
            CodeTextBox.Location = new Point(150, 88);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(271, 23);
            CodeTextBox.TabIndex = 5;
            CodeTextBox.TextChanged += TextChangedEvent;
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(150, 128);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(271, 23);
            BrandTextBox.TabIndex = 6;
            BrandTextBox.TextChanged += TextChangedEvent;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(150, 169);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(271, 23);
            PriceTextBox.TabIndex = 7;
            PriceTextBox.TextChanged += TextChangedEvent;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Lime;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.Location = new Point(0, 322);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(242, 47);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Crimson;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(237, 322);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(244, 47);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLabel.ForeColor = Color.White;
            StatusLabel.Location = new Point(50, 252);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(50, 18);
            StatusLabel.TabIndex = 10;
            StatusLabel.Text = "Status:";
            // 
            // StatusMessage
            // 
            StatusMessage.AutoSize = true;
            StatusMessage.Location = new Point(150, 206);
            StatusMessage.Name = "StatusMessage";
            StatusMessage.Size = new Size(0, 15);
            StatusMessage.TabIndex = 11;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(150, 206);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(271, 23);
            QuantityTextBox.TabIndex = 13;
            QuantityTextBox.TextChanged += TextChangedEvent;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityLabel.ForeColor = Color.White;
            QuantityLabel.Location = new Point(50, 209);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(62, 18);
            QuantityLabel.TabIndex = 12;
            QuantityLabel.Text = "Quantity";
            // 
            // LabelStatus
            // 
            LabelStatus.AutoSize = true;
            LabelStatus.Location = new Point(150, 255);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(0, 15);
            LabelStatus.TabIndex = 14;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(480, 366);
            Controls.Add(LabelStatus);
            Controls.Add(QuantityTextBox);
            Controls.Add(QuantityLabel);
            Controls.Add(StatusMessage);
            Controls.Add(StatusLabel);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(PriceTextBox);
            Controls.Add(BrandTextBox);
            Controls.Add(CodeTextBox);
            Controls.Add(BrandLabel);
            Controls.Add(PriceLabel);
            Controls.Add(CodeLabel);
            Controls.Add(ItemNameLabel);
            Controls.Add(ItemTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItemForm";
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemTextBox;
        private Label ItemNameLabel;
        private Label CodeLabel;
        private Label PriceLabel;
        private Label BrandLabel;
        private TextBox CodeTextBox;
        private TextBox BrandTextBox;
        private TextBox PriceTextBox;
        private Button AddButton;
        private Button CancelButton;
        private Label StatusLabel;
        private Label StatusMessage;
        private TextBox QuantityTextBox;
        private Label QuantityLabel;
        private Label LabelStatus;
    }
}