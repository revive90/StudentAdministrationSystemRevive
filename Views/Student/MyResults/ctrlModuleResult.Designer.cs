namespace StudentAdministrationSystemRevive.Views.Student.MyResults
{
    partial class ctrlModuleResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultModuleName = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            lblResultsFinalMarkPercent = new Label();
            label4 = new Label();
            lblResultsFinalModuleGrade = new Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultModuleName
            // 
            lblResultModuleName.AutoSize = true;
            lblResultModuleName.Font = new Font("Segoe UI Light", 21.75F);
            lblResultModuleName.ForeColor = Color.RoyalBlue;
            lblResultModuleName.ImeMode = ImeMode.NoControl;
            lblResultModuleName.Location = new Point(49, 11);
            lblResultModuleName.Name = "lblResultModuleName";
            lblResultModuleName.Size = new Size(193, 40);
            lblResultModuleName.TabIndex = 20;
            lblResultModuleName.Text = "Cyber Security";
            lblResultModuleName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblResultsFinalMarkPercent);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblResultsFinalModuleGrade);
            panel3.Location = new Point(3, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 188);
            panel3.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(41, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(41, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 15F);
            label5.ForeColor = Color.Black;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(77, 152);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 28;
            label5.Text = "PASS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultsFinalMarkPercent
            // 
            lblResultsFinalMarkPercent.AutoSize = true;
            lblResultsFinalMarkPercent.Font = new Font("Segoe UI Light", 35F, FontStyle.Bold);
            lblResultsFinalMarkPercent.ForeColor = Color.Black;
            lblResultsFinalMarkPercent.ImeMode = ImeMode.NoControl;
            lblResultsFinalMarkPercent.Location = new Point(72, 70);
            lblResultsFinalMarkPercent.Name = "lblResultsFinalMarkPercent";
            lblResultsFinalMarkPercent.Size = new Size(115, 62);
            lblResultsFinalMarkPercent.TabIndex = 27;
            lblResultsFinalMarkPercent.Text = "68%";
            lblResultsFinalMarkPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 15F);
            label4.ForeColor = Color.Black;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(78, 19);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 26;
            label4.Text = "Final Score";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultsFinalModuleGrade
            // 
            lblResultsFinalModuleGrade.AutoSize = true;
            lblResultsFinalModuleGrade.Font = new Font("Segoe UI Light", 15F, FontStyle.Bold);
            lblResultsFinalModuleGrade.ForeColor = Color.Gray;
            lblResultsFinalModuleGrade.ImeMode = ImeMode.NoControl;
            lblResultsFinalModuleGrade.Location = new Point(137, 152);
            lblResultsFinalModuleGrade.Name = "lblResultsFinalModuleGrade";
            lblResultsFinalModuleGrade.Size = new Size(36, 28);
            lblResultsFinalModuleGrade.TabIndex = 25;
            lblResultsFinalModuleGrade.Text = "2.1";
            lblResultsFinalModuleGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(3, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 10);
            panel2.TabIndex = 22;
            // 
            // ctrlModuleResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(panel2);
            Controls.Add(lblResultModuleName);
            Controls.Add(panel3);
            Name = "ctrlModuleResult";
            Size = new Size(282, 271);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultModuleName;
        private Panel panel3;
        private Label lblResultsFinalMarkPercent;
        private Label label4;
        private Label lblResultsFinalModuleGrade;
        private Label label5;
        private Panel panel4;
        private Panel panel1;
        private Panel panel2;
    }
}
