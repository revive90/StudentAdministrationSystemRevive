namespace StudentAdministrationSystemRevive.Views.Administrator.CohortManagement
{
    partial class frmAdminCohortManagement
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
            viewCohortsToolStripMenuItem = new ToolStripMenuItem();
            createEditCohortsToolStripMenuItem = new ToolStripMenuItem();
            createCohortToolStripMenuItem = new ToolStripMenuItem();
            editCohortToolStripMenuItem = new ToolStripMenuItem();
            pnlAdminCohortContentPane = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewCohortsToolStripMenuItem, createEditCohortsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewCohortsToolStripMenuItem
            // 
            viewCohortsToolStripMenuItem.Name = "viewCohortsToolStripMenuItem";
            viewCohortsToolStripMenuItem.Size = new Size(89, 20);
            viewCohortsToolStripMenuItem.Text = "View Cohorts";
            viewCohortsToolStripMenuItem.Click += viewCohortsToolStripMenuItem_Click;
            // 
            // createEditCohortsToolStripMenuItem
            // 
            createEditCohortsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createCohortToolStripMenuItem, editCohortToolStripMenuItem });
            createEditCohortsToolStripMenuItem.Name = "createEditCohortsToolStripMenuItem";
            createEditCohortsToolStripMenuItem.Size = new Size(129, 20);
            createEditCohortsToolStripMenuItem.Text = "Create / Edit Cohorts";
            // 
            // createCohortToolStripMenuItem
            // 
            createCohortToolStripMenuItem.Name = "createCohortToolStripMenuItem";
            createCohortToolStripMenuItem.Size = new Size(148, 22);
            createCohortToolStripMenuItem.Text = "Create Cohort";
            createCohortToolStripMenuItem.Click += createCohortToolStripMenuItem_Click;
            // 
            // editCohortToolStripMenuItem
            // 
            editCohortToolStripMenuItem.Name = "editCohortToolStripMenuItem";
            editCohortToolStripMenuItem.Size = new Size(148, 22);
            editCohortToolStripMenuItem.Text = "Edit Cohort";
            editCohortToolStripMenuItem.Click += editCohortToolStripMenuItem_Click;
            // 
            // pnlAdminCohortContentPane
            // 
            pnlAdminCohortContentPane.Location = new Point(0, 27);
            pnlAdminCohortContentPane.Name = "pnlAdminCohortContentPane";
            pnlAdminCohortContentPane.Size = new Size(1003, 740);
            pnlAdminCohortContentPane.TabIndex = 28;
            // 
            // frmAdminCohortManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(pnlAdminCohortContentPane);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmAdminCohortManagement";
            Text = "frmAdminCohortManagement";
            Load += frmAdminCohortManagement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewCohortsToolStripMenuItem;
        private ToolStripMenuItem createEditCohortsToolStripMenuItem;
        private ToolStripMenuItem createCohortToolStripMenuItem;
        private ToolStripMenuItem editCohortToolStripMenuItem;
        private Panel pnlAdminCohortContentPane;
    }
}