namespace StudentAdministrationSystemRevive.Views.Administrator.TeachingStaff
{
    partial class frmAdminTeachingStaff
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            viewStaffToolStripMenuItem = new ToolStripMenuItem();
            editStaffToolStripMenuItem = new ToolStripMenuItem();
            addRemoveStaffToolStripMenuItem = new ToolStripMenuItem();
            addStaffToolStripMenuItem = new ToolStripMenuItem();
            removeStaffToolStripMenuItem = new ToolStripMenuItem();
            moduleAssignmentToolStripMenuItem = new ToolStripMenuItem();
            availabilityToolStripMenuItem = new ToolStripMenuItem();
            feedbackToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Semilight", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, addRemoveStaffToolStripMenuItem, moduleAssignmentToolStripMenuItem, availabilityToolStripMenuItem, feedbackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 27);
            menuStrip1.TabIndex = 35;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { viewStaffToolStripMenuItem, editStaffToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(119, 23);
            toolStripMenuItem1.Text = "View / Edit Staff ";
            // 
            // viewStaffToolStripMenuItem
            // 
            viewStaffToolStripMenuItem.Name = "viewStaffToolStripMenuItem";
            viewStaffToolStripMenuItem.Size = new Size(137, 24);
            viewStaffToolStripMenuItem.Text = "View Staff";
            // 
            // editStaffToolStripMenuItem
            // 
            editStaffToolStripMenuItem.Name = "editStaffToolStripMenuItem";
            editStaffToolStripMenuItem.Size = new Size(137, 24);
            editStaffToolStripMenuItem.Text = "Edit Staff";
            // 
            // addRemoveStaffToolStripMenuItem
            // 
            addRemoveStaffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStaffToolStripMenuItem, removeStaffToolStripMenuItem });
            addRemoveStaffToolStripMenuItem.Name = "addRemoveStaffToolStripMenuItem";
            addRemoveStaffToolStripMenuItem.Size = new Size(138, 23);
            addRemoveStaffToolStripMenuItem.Text = "Add / Remove Staff";
            // 
            // addStaffToolStripMenuItem
            // 
            addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            addStaffToolStripMenuItem.Size = new Size(157, 24);
            addStaffToolStripMenuItem.Text = "Add Staff";
            // 
            // removeStaffToolStripMenuItem
            // 
            removeStaffToolStripMenuItem.Name = "removeStaffToolStripMenuItem";
            removeStaffToolStripMenuItem.Size = new Size(157, 24);
            removeStaffToolStripMenuItem.Text = "Remove Staff";
            // 
            // moduleAssignmentToolStripMenuItem
            // 
            moduleAssignmentToolStripMenuItem.Name = "moduleAssignmentToolStripMenuItem";
            moduleAssignmentToolStripMenuItem.Size = new Size(142, 23);
            moduleAssignmentToolStripMenuItem.Text = "Module Assignment";
            // 
            // availabilityToolStripMenuItem
            // 
            availabilityToolStripMenuItem.Name = "availabilityToolStripMenuItem";
            availabilityToolStripMenuItem.Size = new Size(85, 23);
            availabilityToolStripMenuItem.Text = "Availability";
            // 
            // feedbackToolStripMenuItem
            // 
            feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            feedbackToolStripMenuItem.Size = new Size(78, 23);
            feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // frmAdminTeachingStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 769);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmAdminTeachingStaff";
            Text = "frmAdminTeachingStaff";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem viewStaffToolStripMenuItem;
        private ToolStripMenuItem editStaffToolStripMenuItem;
        private ToolStripMenuItem addRemoveStaffToolStripMenuItem;
        private ToolStripMenuItem addStaffToolStripMenuItem;
        private ToolStripMenuItem removeStaffToolStripMenuItem;
        private ToolStripMenuItem moduleAssignmentToolStripMenuItem;
        private ToolStripMenuItem availabilityToolStripMenuItem;
        private ToolStripMenuItem feedbackToolStripMenuItem;
    }
}