namespace StudentAdministrationSystemRevive.Views.Administrator
{
    partial class frmAdministratorPortal
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(150, 191);
            button1.Name = "button1";
            button1.Size = new Size(448, 230);
            button1.TabIndex = 0;
            button1.Text = "I have been changed";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAdministratorPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 582);
            Controls.Add(button1);
            Name = "frmAdministratorPortal";
            Text = "frmAdministratorPortal";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}