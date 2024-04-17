namespace LoginRegisterApp
{
    partial class LoginForm
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
            panel1 = new Panel();
            goToRegister = new Label();
            label5 = new Label();
            loginShowPassword = new CheckBox();
            loginButton = new Button();
            loginClose = new Label();
            loginPassword = new TextBox();
            loginUsername = new TextBox();
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
            panel1.Controls.Add(goToRegister);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(loginShowPassword);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(loginClose);
            panel1.Controls.Add(loginPassword);
            panel1.Controls.Add(loginUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 454);
            panel1.TabIndex = 0;
            // 
            // goToRegister
            // 
            goToRegister.AutoSize = true;
            goToRegister.BackColor = Color.White;
            goToRegister.Cursor = Cursors.Hand;
            goToRegister.Font = new Font("MS PGothic", 9.818182F, FontStyle.Bold);
            goToRegister.ForeColor = Color.MidnightBlue;
            goToRegister.Location = new Point(516, 360);
            goToRegister.Name = "goToRegister";
            goToRegister.Size = new Size(67, 15);
            goToRegister.TabIndex = 5;
            goToRegister.Text = "Register";
            goToRegister.Click += goToRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS PGothic", 9.818182F, FontStyle.Bold);
            label5.Location = new Point(328, 360);
            label5.Name = "label5";
            label5.Size = new Size(182, 15);
            label5.TabIndex = 0;
            label5.Text = "Don't have an account?";
            // 
            // loginShowPassword
            // 
            loginShowPassword.AutoSize = true;
            loginShowPassword.Cursor = Cursors.Hand;
            loginShowPassword.ForeColor = Color.Gray;
            loginShowPassword.Location = new Point(497, 265);
            loginShowPassword.Name = "loginShowPassword";
            loginShowPassword.Size = new Size(123, 23);
            loginShowPassword.TabIndex = 4;
            loginShowPassword.Text = "Show Password";
            loginShowPassword.UseVisualStyleBackColor = true;
            loginShowPassword.CheckedChanged += loginShowPassword_CheckedChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.MidnightBlue;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("MS PGothic", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(292, 265);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(125, 50);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginClose
            // 
            loginClose.AutoSize = true;
            loginClose.Cursor = Cursors.Hand;
            loginClose.Font = new Font("MS PGothic", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginClose.Location = new Point(613, 11);
            loginClose.Name = "loginClose";
            loginClose.Size = new Size(25, 24);
            loginClose.TabIndex = 6;
            loginClose.Text = "X";
            loginClose.Click += loginClose_Click;
            // 
            // loginPassword
            // 
            loginPassword.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold);
            loginPassword.Location = new Point(292, 216);
            loginPassword.Name = "loginPassword";
            loginPassword.PasswordChar = '*';
            loginPassword.Size = new Size(328, 25);
            loginPassword.TabIndex = 2;
            // 
            // loginUsername
            // 
            loginUsername.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold);
            loginUsername.Location = new Point(292, 150);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(328, 25);
            loginUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(292, 195);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS PGothic", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(292, 129);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS PGothic", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 67);
            label1.Name = "label1";
            label1.Size = new Size(173, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
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
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox loginPassword;
        private TextBox loginUsername;
        private Label label3;
        private Button loginButton;
        private Label loginClose;
        private Label label5;
        private CheckBox loginShowPassword;
        private Label goToRegister;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
    }
}
