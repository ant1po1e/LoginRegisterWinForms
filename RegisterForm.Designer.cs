namespace LoginRegisterApp
{
    partial class RegisterForm
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
            panel1 = new Panel();
            registerPassword = new TextBox();
            label4 = new Label();
            goToLogin = new Label();
            label5 = new Label();
            registerShowPassword = new CheckBox();
            registerButton = new Button();
            registerClose = new Label();
            registerUsername = new TextBox();
            registerEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(registerPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(goToLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(registerShowPassword);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(registerClose);
            panel1.Controls.Add(registerUsername);
            panel1.Controls.Add(registerEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 454);
            panel1.TabIndex = 1;
            // 
            // registerPassword
            // 
            registerPassword.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold);
            registerPassword.Location = new Point(292, 280);
            registerPassword.Name = "registerPassword";
            registerPassword.PasswordChar = '*';
            registerPassword.Size = new Size(328, 25);
            registerPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(292, 259);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // goToLogin
            // 
            goToLogin.AutoSize = true;
            goToLogin.BackColor = Color.White;
            goToLogin.Cursor = Cursors.Hand;
            goToLogin.Font = new Font("MS PGothic", 9.818182F, FontStyle.Bold);
            goToLogin.ForeColor = Color.MidnightBlue;
            goToLogin.Location = new Point(531, 408);
            goToLogin.Name = "goToLogin";
            goToLogin.Size = new Size(46, 15);
            goToLogin.TabIndex = 6;
            goToLogin.Text = "Login";
            goToLogin.Click += goToLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS PGothic", 9.818182F, FontStyle.Bold);
            label5.Location = new Point(329, 408);
            label5.Name = "label5";
            label5.Size = new Size(196, 15);
            label5.TabIndex = 0;
            label5.Text = "Already have an account?";
            // 
            // registerShowPassword
            // 
            registerShowPassword.AutoSize = true;
            registerShowPassword.Cursor = Cursors.Hand;
            registerShowPassword.ForeColor = Color.Gray;
            registerShowPassword.Location = new Point(497, 327);
            registerShowPassword.Name = "registerShowPassword";
            registerShowPassword.Size = new Size(123, 23);
            registerShowPassword.TabIndex = 5;
            registerShowPassword.Text = "Show Password";
            registerShowPassword.UseVisualStyleBackColor = true;
            registerShowPassword.CheckedChanged += registerShowPassword_CheckedChanged;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.MidnightBlue;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("MS PGothic", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(292, 327);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(125, 50);
            registerButton.TabIndex = 4;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // registerClose
            // 
            registerClose.AutoSize = true;
            registerClose.Cursor = Cursors.Hand;
            registerClose.Font = new Font("MS PGothic", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerClose.Location = new Point(613, 11);
            registerClose.Name = "registerClose";
            registerClose.Size = new Size(25, 24);
            registerClose.TabIndex = 7;
            registerClose.Text = "X";
            registerClose.Click += registerClose_Click;
            // 
            // registerUsername
            // 
            registerUsername.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold);
            registerUsername.Location = new Point(292, 216);
            registerUsername.Name = "registerUsername";
            registerUsername.Size = new Size(328, 25);
            registerUsername.TabIndex = 2;
            // 
            // registerEmail
            // 
            registerEmail.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold);
            registerEmail.Location = new Point(292, 150);
            registerEmail.Name = "registerEmail";
            registerEmail.Size = new Size(328, 25);
            registerEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 195);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 129);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 67);
            label1.Name = "label1";
            label1.Size = new Size(183, 24);
            label1.TabIndex = 0;
            label1.Text = "Getting Started!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 454);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rsz_1a_11;
            pictureBox1.Location = new Point(73, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS PGothic", 24.2181816F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(8, 229);
            label8.Name = "label8";
            label8.Size = new Size(155, 37);
            label8.TabIndex = 0;
            label8.Text = "Antipole ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS PGothic", 24.2181816F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(61, 268);
            label7.Name = "label7";
            label7.Size = new Size(187, 37);
            label7.TabIndex = 0;
            label7.Text = "Battlefront";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label goToLogin;
        private Label label5;
        private CheckBox registerShowPassword;
        private Button registerButton;
        private Label registerClose;
        private TextBox registerUsername;
        private TextBox registerEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private TextBox registerPassword;
        private Label label4;
    }
}