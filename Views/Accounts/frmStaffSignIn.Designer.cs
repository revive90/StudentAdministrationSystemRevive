namespace StudentAdministrationSystemRevive.Views.Accounts
{
    partial class frmStaffSignIn
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
            label8 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblBack = new Label();
            btnStaffSignIn = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(85, 284);
            label8.Name = "label8";
            label8.Size = new Size(277, 116);
            label8.TabIndex = 27;
            label8.Text = "For demonstration purposes, the username and password are given:\r\n\r\nUsername : admin\r\nPassword : admin123";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(36, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 1);
            panel2.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft YaHei UI", 11F);
            txtPassword.Location = new Point(36, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(384, 26);
            txtPassword.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(36, 201);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 23;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft YaHei UI", 11F);
            txtUsername.Location = new Point(36, 153);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(384, 26);
            txtUsername.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 123);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 21;
            label2.Text = "Email Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 39);
            label1.TabIndex = 20;
            label1.Text = "Staff Sign In";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBack.ForeColor = Color.Black;
            lblBack.Location = new Point(139, 416);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(41, 19);
            lblBack.TabIndex = 31;
            lblBack.Text = "Back";
            lblBack.Click += lblForgotPassword_Click;
            // 
            // btnStaffSignIn
            // 
            btnStaffSignIn.BackColor = Color.RoyalBlue;
            btnStaffSignIn.Cursor = Cursors.Hand;
            btnStaffSignIn.FlatAppearance.BorderSize = 0;
            btnStaffSignIn.FlatStyle = FlatStyle.Flat;
            btnStaffSignIn.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffSignIn.ForeColor = Color.White;
            btnStaffSignIn.Location = new Point(230, 403);
            btnStaffSignIn.Name = "btnStaffSignIn";
            btnStaffSignIn.Size = new Size(115, 45);
            btnStaffSignIn.TabIndex = 30;
            btnStaffSignIn.Text = "Sign in";
            btnStaffSignIn.UseVisualStyleBackColor = false;
            btnStaffSignIn.Click += btnStaffSignIn_Click;
            // 
            // frmStaffSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 477);
            Controls.Add(lblBack);
            Controls.Add(btnStaffSignIn);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmStaffSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStaffSignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Panel panel2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label lblBack;
        private Button btnStaffSignIn;
    }
}