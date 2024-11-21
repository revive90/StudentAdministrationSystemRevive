namespace StudentAdministrationSystemRevive.Views.Administrator.Overview
{
    partial class frmAdminOverview
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
            label1 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 25F);
            label1.ForeColor = Color.RoyalBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 46);
            label1.TabIndex = 21;
            label1.Text = "Admin Overview";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 12F);
            button2.ForeColor = Color.White;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(871, 12);
            button2.Name = "button2";
            button2.Size = new Size(120, 37);
            button2.TabIndex = 20;
            button2.Text = "Reload";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OldLace;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 314);
            panel1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(23, 175);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 25;
            label6.Text = "Duration:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Location = new Point(23, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 1);
            panel4.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(23, 144);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 21;
            label5.Text = "Duration:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(23, 111);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 20;
            label4.Text = "Programme: ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 21.75F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(23, 17);
            label2.Name = "label2";
            label2.Size = new Size(221, 40);
            label2.TabIndex = 19;
            label2.Text = "Admin Overview";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdminOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminOverview";
            Text = "frmAdminOverview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Panel panel1;
        private Label label6;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}