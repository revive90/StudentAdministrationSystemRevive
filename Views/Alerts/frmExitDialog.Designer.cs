namespace StudentAdministrationSystemRevive.Views.Alerts
{
    partial class frmExitDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExitDialog));
            label8 = new Label();
            label3 = new Label();
            btnExitApplication = new Button();
            pictureBox1 = new PictureBox();
            btnDontExit = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(95, 99);
            label8.Name = "label8";
            label8.Size = new Size(169, 21);
            label8.TabIndex = 20;
            label8.Text = "Do you want to exit?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft YaHei UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(22, 23);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 18;
            label3.Text = "Confirm Exit";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExitApplication
            // 
            btnExitApplication.BackColor = Color.White;
            btnExitApplication.Cursor = Cursors.Hand;
            btnExitApplication.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            btnExitApplication.FlatStyle = FlatStyle.Flat;
            btnExitApplication.Font = new Font("Microsoft JhengHei", 11.25F);
            btnExitApplication.ForeColor = Color.RoyalBlue;
            btnExitApplication.Location = new Point(197, 156);
            btnExitApplication.Name = "btnExitApplication";
            btnExitApplication.Size = new Size(82, 36);
            btnExitApplication.TabIndex = 21;
            btnExitApplication.Text = "Yes";
            btnExitApplication.UseVisualStyleBackColor = false;
            btnExitApplication.Click += btnExitApplication_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnDontExit
            // 
            btnDontExit.BackColor = Color.White;
            btnDontExit.Cursor = Cursors.Hand;
            btnDontExit.FlatStyle = FlatStyle.Flat;
            btnDontExit.Font = new Font("Microsoft JhengHei", 11.25F);
            btnDontExit.ForeColor = Color.RoyalBlue;
            btnDontExit.Location = new Point(110, 156);
            btnDontExit.Name = "btnDontExit";
            btnDontExit.Size = new Size(82, 36);
            btnDontExit.TabIndex = 23;
            btnDontExit.Text = "No";
            btnDontExit.UseVisualStyleBackColor = false;
            btnDontExit.Click += btnDontExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(30, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 5);
            panel1.TabIndex = 25;
            // 
            // frmExitDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(310, 215);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnDontExit);
            Controls.Add(pictureBox1);
            Controls.Add(btnExitApplication);
            Controls.Add(label8);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmExitDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label3;
        private Button btnExitApplication;
        private PictureBox pictureBox1;
        private Button btnDontExit;
        private Panel panel2;
        private Panel panel1;
    }
}