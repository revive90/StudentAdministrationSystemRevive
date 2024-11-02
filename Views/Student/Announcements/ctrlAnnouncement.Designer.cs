namespace StudentAdministrationSystemRevive.Views.Student
{
    partial class ctrlAnnouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAnnouncement));
            panel5 = new Panel();
            rtModuleIntro = new RichTextBox();
            panel6 = new Panel();
            label5 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label50 = new Label();
            label51 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.OldLace;
            panel5.Controls.Add(rtModuleIntro);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label50);
            panel5.Controls.Add(label51);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(813, 204);
            panel5.TabIndex = 56;
            // 
            // rtModuleIntro
            // 
            rtModuleIntro.BackColor = Color.OldLace;
            rtModuleIntro.BorderStyle = BorderStyle.None;
            rtModuleIntro.Font = new Font("Microsoft YaHei UI Light", 10F);
            rtModuleIntro.Location = new Point(204, 22);
            rtModuleIntro.Name = "rtModuleIntro";
            rtModuleIntro.ReadOnly = true;
            rtModuleIntro.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtModuleIntro.Size = new Size(593, 161);
            rtModuleIntro.TabIndex = 55;
            rtModuleIntro.Text = resources.GetString("rtModuleIntro.Text");
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Location = new Point(187, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 161);
            panel6.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(16, 134);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 41;
            label5.Text = "Module";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 12F);
            label16.ForeColor = Color.Black;
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(16, 154);
            label16.Name = "label16";
            label16.Size = new Size(106, 21);
            label16.TabIndex = 40;
            label16.Text = "Cyber Security";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ImeMode = ImeMode.NoControl;
            label17.Location = new Point(16, 78);
            label17.Name = "label17";
            label17.Size = new Size(81, 20);
            label17.TabIndex = 39;
            label17.Text = "Posted On";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semilight", 12F);
            label18.ForeColor = Color.Black;
            label18.ImeMode = ImeMode.NoControl;
            label18.Location = new Point(16, 101);
            label18.Name = "label18";
            label18.Size = new Size(91, 21);
            label18.TabIndex = 38;
            label18.Text = "23 Oct 2024";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label50.ImeMode = ImeMode.NoControl;
            label50.Location = new Point(16, 22);
            label50.Name = "label50";
            label50.Size = new Size(79, 20);
            label50.TabIndex = 37;
            label50.Text = "Posted By";
            label50.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI Semilight", 15F);
            label51.ForeColor = Color.Black;
            label51.ImeMode = ImeMode.NoControl;
            label51.Location = new Point(16, 42);
            label51.Name = "label51";
            label51.Size = new Size(114, 28);
            label51.TabIndex = 36;
            label51.Text = "Mr Kennedy";
            label51.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ctrlAnnouncement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel5);
            Name = "ctrlAnnouncement";
            Size = new Size(819, 210);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel6;
        private Label label5;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label50;
        private Label label51;
        private RichTextBox rtModuleIntro;
    }
}
