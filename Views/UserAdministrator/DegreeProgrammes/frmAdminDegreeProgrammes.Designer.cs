namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    partial class frmAdminDegreeProgrammes
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
            menuAdminDegreeProgrammes = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            viewProgrammesToolStripMenuItem = new ToolStripMenuItem();
            editProgrammesToolStripMenuItem = new ToolStripMenuItem();
            etrkyToolStripMenuItem = new ToolStripMenuItem();
            createProgrammesToolStripMenuItem = new ToolStripMenuItem();
            deleteProgrammeToolStripMenuItem = new ToolStripMenuItem();
            retjyToolStripMenuItem = new ToolStripMenuItem();
            addModulesToolStripMenuItem = new ToolStripMenuItem();
            removeModulesToolStripMenuItem = new ToolStripMenuItem();
            editModulesToolStripMenuItem = new ToolStripMenuItem();
            pnlAdminDegreeProgrammesContentPane = new Panel();
            menuAdminDegreeProgrammes.SuspendLayout();
            SuspendLayout();
            // 
            // menuAdminDegreeProgrammes
            // 
            menuAdminDegreeProgrammes.BackColor = SystemColors.ControlLight;
            menuAdminDegreeProgrammes.Font = new Font("Segoe UI Semilight", 10F);
            menuAdminDegreeProgrammes.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, etrkyToolStripMenuItem, retjyToolStripMenuItem });
            menuAdminDegreeProgrammes.Location = new Point(0, 0);
            menuAdminDegreeProgrammes.Name = "menuAdminDegreeProgrammes";
            menuAdminDegreeProgrammes.Size = new Size(1003, 27);
            menuAdminDegreeProgrammes.TabIndex = 26;
            menuAdminDegreeProgrammes.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { viewProgrammesToolStripMenuItem, editProgrammesToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(167, 23);
            toolStripMenuItem1.Text = "View / Edit Programmes";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // viewProgrammesToolStripMenuItem
            // 
            viewProgrammesToolStripMenuItem.Name = "viewProgrammesToolStripMenuItem";
            viewProgrammesToolStripMenuItem.Size = new Size(189, 24);
            viewProgrammesToolStripMenuItem.Text = "View Programmes";
            viewProgrammesToolStripMenuItem.Click += viewProgrammesToolStripMenuItem_Click;
            // 
            // editProgrammesToolStripMenuItem
            // 
            editProgrammesToolStripMenuItem.Name = "editProgrammesToolStripMenuItem";
            editProgrammesToolStripMenuItem.Size = new Size(189, 24);
            editProgrammesToolStripMenuItem.Text = "Edit Programmes";
            editProgrammesToolStripMenuItem.Click += editProgrammesToolStripMenuItem_Click;
            // 
            // etrkyToolStripMenuItem
            // 
            etrkyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createProgrammesToolStripMenuItem, deleteProgrammeToolStripMenuItem });
            etrkyToolStripMenuItem.Name = "etrkyToolStripMenuItem";
            etrkyToolStripMenuItem.Size = new Size(193, 23);
            etrkyToolStripMenuItem.Text = "Create / Delete Programmes";
            // 
            // createProgrammesToolStripMenuItem
            // 
            createProgrammesToolStripMenuItem.Name = "createProgrammesToolStripMenuItem";
            createProgrammesToolStripMenuItem.Size = new Size(193, 24);
            createProgrammesToolStripMenuItem.Text = "Create Programme";
            createProgrammesToolStripMenuItem.Click += createProgrammesToolStripMenuItem_Click;
            // 
            // deleteProgrammeToolStripMenuItem
            // 
            deleteProgrammeToolStripMenuItem.Name = "deleteProgrammeToolStripMenuItem";
            deleteProgrammeToolStripMenuItem.Size = new Size(193, 24);
            deleteProgrammeToolStripMenuItem.Text = "Delete Programme";
            deleteProgrammeToolStripMenuItem.Click += deleteProgrammeToolStripMenuItem_Click;
            // 
            // retjyToolStripMenuItem
            // 
            retjyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addModulesToolStripMenuItem, removeModulesToolStripMenuItem, editModulesToolStripMenuItem });
            retjyToolStripMenuItem.Name = "retjyToolStripMenuItem";
            retjyToolStripMenuItem.Size = new Size(73, 23);
            retjyToolStripMenuItem.Text = "Modules";
            // 
            // addModulesToolStripMenuItem
            // 
            addModulesToolStripMenuItem.Name = "addModulesToolStripMenuItem";
            addModulesToolStripMenuItem.Size = new Size(183, 24);
            addModulesToolStripMenuItem.Text = "Add Modules";
            addModulesToolStripMenuItem.Click += addModulesToolStripMenuItem_Click;
            // 
            // removeModulesToolStripMenuItem
            // 
            removeModulesToolStripMenuItem.Name = "removeModulesToolStripMenuItem";
            removeModulesToolStripMenuItem.Size = new Size(183, 24);
            removeModulesToolStripMenuItem.Text = "Remove Modules";
            removeModulesToolStripMenuItem.Click += removeModulesToolStripMenuItem_Click;
            // 
            // editModulesToolStripMenuItem
            // 
            editModulesToolStripMenuItem.Name = "editModulesToolStripMenuItem";
            editModulesToolStripMenuItem.Size = new Size(183, 24);
            editModulesToolStripMenuItem.Text = "Edit Modules";
            editModulesToolStripMenuItem.Click += editModulesToolStripMenuItem_Click;
            // 
            // pnlAdminDegreeProgrammesContentPane
            // 
            pnlAdminDegreeProgrammesContentPane.Location = new Point(0, 27);
            pnlAdminDegreeProgrammesContentPane.Name = "pnlAdminDegreeProgrammesContentPane";
            pnlAdminDegreeProgrammesContentPane.Size = new Size(1003, 740);
            pnlAdminDegreeProgrammesContentPane.TabIndex = 27;
            // 
            // frmAdminDegreeProgrammes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(pnlAdminDegreeProgrammesContentPane);
            Controls.Add(menuAdminDegreeProgrammes);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuAdminDegreeProgrammes;
            Name = "frmAdminDegreeProgrammes";
            Text = "frmAdminDegreeProgrammes";
            Load += frmAdminDegreeProgrammes_Load;
            menuAdminDegreeProgrammes.ResumeLayout(false);
            menuAdminDegreeProgrammes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuAdminDegreeProgrammes;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem etrkyToolStripMenuItem;
        private ToolStripMenuItem retjyToolStripMenuItem;
        private ToolStripMenuItem addModulesToolStripMenuItem;
        private ToolStripMenuItem removeModulesToolStripMenuItem;
        private ToolStripMenuItem editModulesToolStripMenuItem;
        private ToolStripMenuItem viewProgrammesToolStripMenuItem;
        private ToolStripMenuItem editProgrammesToolStripMenuItem;
        private ToolStripMenuItem createProgrammesToolStripMenuItem;
        private ToolStripMenuItem deleteProgrammeToolStripMenuItem;
        private Panel pnlAdminDegreeProgrammesContentPane;
    }
}