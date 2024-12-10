namespace StudentAdministrationSystemRevive
{
    partial class frmSignIn
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnStudentSignIn = new Button();
            lblForgotPassword = new Label();
            btnCreateAccount = new Button();
            btnStaffSignInPage = new Button();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label10 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_10_22_235827;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 43);
            label1.Name = "label1";
            label1.Size = new Size(118, 39);
            label1.TabIndex = 1;
            label1.Text = "Sign in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(234, 136);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(237, 174);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 28);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(237, 333);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(241, 28);
            txtPassword.TabIndex = 6;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(234, 298);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(237, 231);
            label5.Name = "label5";
            label5.Size = new Size(241, 59);
            label5.TabIndex = 7;
            label5.Text = "Your username is the email address you registered with";
            // 
            // btnStudentSignIn
            // 
            btnStudentSignIn.BackColor = Color.RoyalBlue;
            btnStudentSignIn.Cursor = Cursors.Hand;
            btnStudentSignIn.FlatAppearance.BorderSize = 0;
            btnStudentSignIn.FlatStyle = FlatStyle.Flat;
            btnStudentSignIn.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentSignIn.ForeColor = Color.White;
            btnStudentSignIn.Location = new Point(237, 397);
            btnStudentSignIn.Name = "btnStudentSignIn";
            btnStudentSignIn.Size = new Size(115, 45);
            btnStudentSignIn.TabIndex = 8;
            btnStudentSignIn.Text = "Sign in";
            btnStudentSignIn.UseVisualStyleBackColor = false;
            btnStudentSignIn.Click += btnStudentSignIn_Click;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.Black;
            lblForgotPassword.Location = new Point(237, 460);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(128, 19);
            lblForgotPassword.TabIndex = 9;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.RoyalBlue;
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(560, 214);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(190, 45);
            btnCreateAccount.TabIndex = 10;
            btnCreateAccount.Text = "Create account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnStaffSignInPage
            // 
            btnStaffSignInPage.BackColor = Color.RoyalBlue;
            btnStaffSignInPage.Cursor = Cursors.Hand;
            btnStaffSignInPage.FlatAppearance.BorderSize = 0;
            btnStaffSignInPage.FlatStyle = FlatStyle.Flat;
            btnStaffSignInPage.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffSignInPage.ForeColor = Color.White;
            btnStaffSignInPage.Location = new Point(560, 397);
            btnStaffSignInPage.Name = "btnStaffSignInPage";
            btnStaffSignInPage.Size = new Size(162, 45);
            btnStaffSignInPage.TabIndex = 11;
            btnStaffSignInPage.Text = "Staff sign in";
            btnStaffSignInPage.UseVisualStyleBackColor = false;
            btnStaffSignInPage.Click += btnStaffSignInPage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 21.75F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(555, 60);
            label7.Name = "label7";
            label7.Size = new Size(233, 38);
            label7.TabIndex = 12;
            label7.Text = "Not registered?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(512, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 463);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(560, 118);
            label8.Name = "label8";
            label8.Size = new Size(241, 84);
            label8.TabIndex = 14;
            label8.Text = "Whether you're planning to join us,\r\nor contacting us for information, \r\nmake it more convenient by creating\r\nan account.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(560, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 1);
            panel2.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 21.75F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(555, 342);
            label9.Name = "label9";
            label9.Size = new Size(183, 38);
            label9.TabIndex = 15;
            label9.Text = "Staff sign in";
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(560, 460);
            label10.Name = "label10";
            label10.Size = new Size(239, 47);
            label10.TabIndex = 16;
            label10.Text = "You will be redirected to the\r\nverification page.";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(823, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 17;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(861, 536);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(btnStaffSignInPage);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(lblForgotPassword);
            Controls.Add(btnStudentSignIn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmSignIn_Load;
            MouseDown += frmSignIn_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private Button btnStudentSignIn;
        private Label lblForgotPassword;
        private Button btnCreateAccount;
        private Button btnStaffSignInPage;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
        private Label label9;
        private Label label10;
        private Button btnExit;
    }
}
