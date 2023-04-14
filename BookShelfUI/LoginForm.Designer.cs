namespace BookShelfUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            panel1 = new Panel();
            ShowPassCheckBox = new CheckBox();
            QuitButton = new Button();
            LoginButton = new Button();
            ForgotPassLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.MidnightBlue;
            LoginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(81, 158);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(57, 21);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Login:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.MidnightBlue;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(18, 86);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(86, 21);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(84, 182);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(319, 23);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(22, 110);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(319, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(ForgotPassLabel);
            panel1.Controls.Add(ShowPassCheckBox);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(QuitButton);
            panel1.Controls.Add(PasswordLabel);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(62, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 278);
            panel1.TabIndex = 5;
            // 
            // ShowPassCheckBox
            // 
            ShowPassCheckBox.AutoSize = true;
            ShowPassCheckBox.ForeColor = Color.White;
            ShowPassCheckBox.Location = new Point(22, 139);
            ShowPassCheckBox.Name = "ShowPassCheckBox";
            ShowPassCheckBox.Size = new Size(108, 19);
            ShowPassCheckBox.TabIndex = 5;
            ShowPassCheckBox.Text = "Show Password";
            ShowPassCheckBox.UseVisualStyleBackColor = true;
            ShowPassCheckBox.CheckedChanged += ShowPassCheckBox_CheckedChanged;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Crimson;
            QuitButton.FlatAppearance.BorderSize = 0;
            QuitButton.FlatStyle = FlatStyle.Flat;
            QuitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            QuitButton.ForeColor = Color.White;
            QuitButton.Location = new Point(78, 224);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(205, 34);
            QuitButton.TabIndex = 1;
            QuitButton.Text = "QUIT";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Aquamarine;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(78, 184);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(205, 34);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOG IN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // ForgotPassLabel
            // 
            ForgotPassLabel.AutoSize = true;
            ForgotPassLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ForgotPassLabel.ForeColor = Color.White;
            ForgotPassLabel.Location = new Point(240, 143);
            ForgotPassLabel.Name = "ForgotPassLabel";
            ForgotPassLabel.Size = new Size(104, 15);
            ForgotPassLabel.TabIndex = 6;
            ForgotPassLabel.Text = "Forgot Password?";
            ForgotPassLabel.Click += ForgotPassLabel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 450);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Panel panel1;
        private Button QuitButton;
        private Button LoginButton;
        private CheckBox ShowPassCheckBox;
        private Label ForgotPassLabel;
    }
}