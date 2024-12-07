using StudentAdministrationSystemRevive.BusinessLogic;

namespace StudentAdministrationSystemRevive.Views.Administrator.DegreeProgrammes
{
    public partial class ctrlAdminCreateProgramme : UserControl
    {
        public ctrlAdminCreateProgramme()
        {
            InitializeComponent();
        }

        private void btnCreateProg_Click(object sender, EventArgs e)
        {

            createProgStringValues();

        }


        // Method to create a degree programme and ad
        private void createProgStringValues()
        {
            try
            {
                // Getting form inputs

                string programmeCode = txtProgCode.Text.Trim();
                string programmeTitle = txtProgTitle.Text.Trim();
                string progammeDuration = cmbProgLength.Text.ToString();
                string programmeDescription = txtProgDescription.Text.Trim();

                // Creating a new Gedree Programme Object
                var programme = new DegreeProgramme(programmeCode, programmeTitle, progammeDuration, programmeDescription);

                // Calling the DegreeProgrammeService to add the programme
                var programmeService = new DegreeProgrammeService();
                bool success = programmeService.AddProgramme(programme);

                if (success)
                {
                    MessageBox.Show("Programme created successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to create programme.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }



            //string progLength = cmbProgLength.Text.ToString();
            //string progTitle = txtProgTitle.Text.Trim();
            //string progCode = txtProgCode.Text.Trim();
            //string progDescrtiption = txtProgDescription.Text.Trim();

            //if (progLength.Length > 0 && progTitle.Length > 0 && progCode.Length > 0 && progDescrtiption.Length > 0)
            //{
            //    var sql = " INSERT INTO DegreeProgrammes (DegreeProgrammeID,ProgrammeTitle,ProgrammeDescription,DurationYears) " + " VALUES (@progCode, @progTitle, @progDescription, @ProgLength) ";

            //    try
            //    {
            //        var conn = new SQLiteConnection(ConnectSettingsDB.ConnectionString());
            //        conn.Open();
            //        using var command = new SQLiteCommand(sql, conn);

            //        command.Parameters.AddWithValue("@progCode", progCode);
            //        command.Parameters.AddWithValue("@progTitle", progTitle);
            //        command.Parameters.AddWithValue("@progDescription", progDescrtiption);
            //        command.Parameters.AddWithValue("@ProgLength", progLength);

            //        command.ExecuteNonQuery();
            //        conn.Close();
            //        MessageBox.Show("A new degree programme has been added successfully", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    }
            //    catch (SQLiteException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    }
            //else
            //{
            //    MessageBox.Show("One or more fields is empty", "Programme not created", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //}
        }

        private void btnGenerateProgCode_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randNum = r.Next(1000000);
            string sixDigitNumber = randNum.ToString("D6");
            txtProgCode.Text = sixDigitNumber;
        }
    }
}
