namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    partial class frmAdminAssessments
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
            menuStrip1 = new MenuStrip();
            newAssessmentToolStripMenuItem = new ToolStripMenuItem();
            editExistingAssessmentToolStripMenuItem = new ToolStripMenuItem();
            gradeAnAssessmentToolStripMenuItem = new ToolStripMenuItem();
            removeAnAssessmentToolStripMenuItem = new ToolStripMenuItem();
            pnlAdminAssessmentsContentPane = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { newAssessmentToolStripMenuItem, editExistingAssessmentToolStripMenuItem, gradeAnAssessmentToolStripMenuItem, removeAnAssessmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newAssessmentToolStripMenuItem
            // 
            newAssessmentToolStripMenuItem.Name = "newAssessmentToolStripMenuItem";
            newAssessmentToolStripMenuItem.Size = new Size(108, 20);
            newAssessmentToolStripMenuItem.Text = "New Assessment";
            newAssessmentToolStripMenuItem.Click += newAssessmentToolStripMenuItem_Click;
            // 
            // editExistingAssessmentToolStripMenuItem
            // 
            editExistingAssessmentToolStripMenuItem.Name = "editExistingAssessmentToolStripMenuItem";
            editExistingAssessmentToolStripMenuItem.Size = new Size(148, 20);
            editExistingAssessmentToolStripMenuItem.Text = "Edit Existing Assessment";
            editExistingAssessmentToolStripMenuItem.Click += editExistingAssessmentToolStripMenuItem_Click;
            // 
            // gradeAnAssessmentToolStripMenuItem
            // 
            gradeAnAssessmentToolStripMenuItem.Name = "gradeAnAssessmentToolStripMenuItem";
            gradeAnAssessmentToolStripMenuItem.Size = new Size(131, 20);
            gradeAnAssessmentToolStripMenuItem.Text = "Grade an Assessment";
            gradeAnAssessmentToolStripMenuItem.Click += gradeAnAssessmentToolStripMenuItem_Click;
            // 
            // removeAnAssessmentToolStripMenuItem
            // 
            removeAnAssessmentToolStripMenuItem.Name = "removeAnAssessmentToolStripMenuItem";
            removeAnAssessmentToolStripMenuItem.Size = new Size(143, 20);
            removeAnAssessmentToolStripMenuItem.Text = "Remove an Assessment";
            removeAnAssessmentToolStripMenuItem.Click += removeAnAssessmentToolStripMenuItem_Click;
            // 
            // pnlAdminAssessmentsContentPane
            // 
            pnlAdminAssessmentsContentPane.Location = new Point(0, 27);
            pnlAdminAssessmentsContentPane.Name = "pnlAdminAssessmentsContentPane";
            pnlAdminAssessmentsContentPane.Size = new Size(1003, 712);
            pnlAdminAssessmentsContentPane.TabIndex = 1;
            // 
            // frmAdminAssessments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 740);
            Controls.Add(pnlAdminAssessmentsContentPane);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmAdminAssessments";
            Text = "frmAssessments";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newAssessmentToolStripMenuItem;
        private ToolStripMenuItem editExistingAssessmentToolStripMenuItem;
        private ToolStripMenuItem gradeAnAssessmentToolStripMenuItem;
        private ToolStripMenuItem removeAnAssessmentToolStripMenuItem;
        private Panel pnlAdminAssessmentsContentPane;
    }
}