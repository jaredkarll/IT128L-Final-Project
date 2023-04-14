namespace BookShelfUI
{
    partial class ForgotPasswordForm
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
            UsernameTextBox = new TextBox();
            UserNameLabel = new Label();
            panel1 = new Panel();
            NewPassTextBox = new TextBox();
            NewPassLabel = new Label();
            ReEnterPassTextBox = new TextBox();
            ReEnterPassLabel = new Label();
            QuitButton = new Button();
            SubmitButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(17, 87);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(319, 23);
            UsernameTextBox.TabIndex = 7;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.BackColor = Color.MidnightBlue;
            UserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(14, 63);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(91, 21);
            UserNameLabel.TabIndex = 6;
            UserNameLabel.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(NewPassTextBox);
            panel1.Controls.Add(NewPassLabel);
            panel1.Controls.Add(ReEnterPassTextBox);
            panel1.Controls.Add(ReEnterPassLabel);
            panel1.Controls.Add(UsernameTextBox);
            panel1.Controls.Add(UserNameLabel);
            panel1.Controls.Add(QuitButton);
            panel1.Controls.Add(SubmitButton);
            panel1.Location = new Point(34, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 386);
            panel1.TabIndex = 8;
            // 
            // NewPassTextBox
            // 
            NewPassTextBox.Location = new Point(17, 155);
            NewPassTextBox.Name = "NewPassTextBox";
            NewPassTextBox.Size = new Size(319, 23);
            NewPassTextBox.TabIndex = 11;
            NewPassTextBox.UseSystemPasswordChar = true;
            // 
            // NewPassLabel
            // 
            NewPassLabel.AutoSize = true;
            NewPassLabel.BackColor = Color.MidnightBlue;
            NewPassLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NewPassLabel.ForeColor = Color.White;
            NewPassLabel.Location = new Point(13, 131);
            NewPassLabel.Name = "NewPassLabel";
            NewPassLabel.Size = new Size(125, 21);
            NewPassLabel.TabIndex = 10;
            NewPassLabel.Text = "New Password:";
            // 
            // ReEnterPassTextBox
            // 
            ReEnterPassTextBox.Location = new Point(17, 222);
            ReEnterPassTextBox.Name = "ReEnterPassTextBox";
            ReEnterPassTextBox.Size = new Size(319, 23);
            ReEnterPassTextBox.TabIndex = 9;
            ReEnterPassTextBox.UseSystemPasswordChar = true;
            // 
            // ReEnterPassLabel
            // 
            ReEnterPassLabel.AutoSize = true;
            ReEnterPassLabel.BackColor = Color.MidnightBlue;
            ReEnterPassLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReEnterPassLabel.ForeColor = Color.White;
            ReEnterPassLabel.Location = new Point(13, 198);
            ReEnterPassLabel.Name = "ReEnterPassLabel";
            ReEnterPassLabel.Size = new Size(155, 21);
            ReEnterPassLabel.TabIndex = 8;
            ReEnterPassLabel.Text = "Re-Enter Password:";
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Crimson;
            QuitButton.FlatAppearance.BorderSize = 0;
            QuitButton.FlatStyle = FlatStyle.Flat;
            QuitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            QuitButton.ForeColor = Color.White;
            QuitButton.Location = new Point(80, 320);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(205, 34);
            QuitButton.TabIndex = 1;
            QuitButton.Text = "QUIT";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.Aquamarine;
            SubmitButton.FlatAppearance.BorderSize = 0;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.Location = new Point(80, 280);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(205, 34);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 484);
            Controls.Add(panel1);
            Name = "ForgotPasswordForm";
            Text = "ForgotPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox UsernameTextBox;
        private Label UserNameLabel;
        private Panel panel1;
        private TextBox NewPassTextBox;
        private Label NewPassLabel;
        private TextBox ReEnterPassTextBox;
        private Label ReEnterPassLabel;
        private Button QuitButton;
        private Button SubmitButton;
    }
}