namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class ctrlAssessments
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
            panel1 = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(26, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 1);
            panel1.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F);
            label2.ForeColor = Color.RoyalBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(26, 34);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 73;
            label2.Text = "Assessments";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // frmAdminAssessments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "frmAdminAssessments";
            Size = new Size(1003, 740);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
    }
}
