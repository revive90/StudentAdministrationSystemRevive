using StudentAdministrationSystemRevive.Views.Student;
using StudentAdministrationSystemRevive.Views.Student.Assessments;
using StudentAdministrationSystemRevive.Views.Student.Modules_Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.StudentPages
{
    public partial class frmStudentModules : Form
    {
        public frmStudentModules()
        {
            InitializeComponent();
        }

        private void btnModuleOneExpand_Click(object sender, EventArgs e)
        {
            pnlModuleDetails.Visible = true;
            pnlModulePreviewAll.Visible = false;

        }

        private void btnMyModulesModuleClose_Click(object sender, EventArgs e)
        {
            pnlModuleDetails.Visible = false;
            pnlModulePreviewAll.Visible = true;
        }

        private void frmStudentModules_Load(object sender, EventArgs e)
        {
            pnlModuleDetails.Visible = false;
            pnlModulePreviewAll.Visible = true;

            rtModuleIntro.Text = "The course examines techniques and tools for the design of " +
                "Dependable Reactive and Real-Time Systems. First, we look at the design and " +
                "analysis of Dependable Systems and then we examine the design of Reactive and " +
                "Real-Time Systems with an emphasis on fault tolerance.\r\n\r\nThe first assignment is " +
                "coursework that will be released by start of week 5 and you will have at least 45 days to" +
                " return your individual report on it.\r\n\r\nThe second assignment is an online time-limited " +
                "assessment in Canvas that takes place in January together with your other exams \r\n\r\nThe material " +
                "referenced below for weeks 1-12 will be added gradually. Ideally, to optimise learning, read the slides and watch any videos for each week before the lectures that take place the same week   ";
        }

        private void btnMDAboutModule_Click(object sender, EventArgs e)
        {
            showAboutModule();
        }
        private void btnMDAnnouncements_Click(object sender, EventArgs e)
        {
            showModuleAnnouncements();
            addMoreToTheAnnouncements();
        }
        private void btnMDAssessments_Click(object sender, EventArgs e)
        {
            addThreeAssessments();
            showAssessments();
        }
        private void btnMDGrades_Click(object sender, EventArgs e)
        {
            addThreeGrades();
            showAssessmentGrades();
        }

        private void btnMDMyFeedback_Click(object sender, EventArgs e)
        {
            showAssessmentFeedback();
            addAssessmentFeedback();
        }

        private void btnMDEvaluation_Click(object sender, EventArgs e)
        {
            showModuleEvaluation();
        }









        // -- Navigation for the different sections within each module
        private void showAboutModule()
        {
            pnlMDAboutModule.Visible = true;
            pnlMDAnnouncements.Visible = false;
            pnlMDAssessments.Visible = false;
            pnlMDGrades.Visible = false;
            pnlMDMyFeedback.Visible = false;
            pnlMDEvaluation.Visible = false;
        }
        private void showModuleAnnouncements()
        {
            pnlMDAboutModule.Visible = false;
            pnlMDAnnouncements.Visible = true;
            pnlMDAssessments.Visible = false;
            pnlMDGrades.Visible = false;
            pnlMDMyFeedback.Visible = false;
            pnlMDEvaluation.Visible = false;
        }

        private void showAssessments()
        {
            pnlMDAboutModule.Visible = false;
            pnlMDAnnouncements.Visible = false;
            pnlMDAssessments.Visible = true;
            pnlMDGrades.Visible = false;
            pnlMDMyFeedback.Visible = false;
            pnlMDEvaluation.Visible = false;
        }

        private void showAssessmentGrades()
        {
            pnlMDAboutModule.Visible = false;
            pnlMDAnnouncements.Visible = false;
            pnlMDAssessments.Visible = false;
            pnlMDGrades.Visible = true;
            pnlMDMyFeedback.Visible = false;
            pnlMDEvaluation.Visible = false;
        }

        private void showAssessmentFeedback()
        {
            pnlMDAboutModule.Visible = false;
            pnlMDAnnouncements.Visible = false;
            pnlMDAssessments.Visible = false;
            pnlMDGrades.Visible = false;
            pnlMDMyFeedback.Visible = true;
            pnlMDEvaluation.Visible = false;
        }

        private void showModuleEvaluation()
        {
            pnlMDAboutModule.Visible = false;
            pnlMDAnnouncements.Visible = false;
            pnlMDAssessments.Visible = false;
            pnlMDGrades.Visible = false;
            pnlMDMyFeedback.Visible = false;
            pnlMDEvaluation.Visible = true;
        }


        private void addMoreToTheAnnouncements()
        {
            ctrlAnnouncement announcementView = new ctrlAnnouncement();
            flowAnnouncements.Controls.Add(announcementView);
        }



        private void addThreeAssessments()
        {

            ctrlAssessments ctrlAssessments = new ctrlAssessments();
            flowAssessments.Controls.Add(ctrlAssessments);
            flowAssessments.Controls.Add(ctrlAssessments);
            flowAssessments.Controls.Add(ctrlAssessments);
        }

        private void addThreeGrades()
        {
            ctrlAssessmentGrades ctrlAssessmentGrades = new ctrlAssessmentGrades();
            flowAssessmentGrades.Controls.Add(ctrlAssessmentGrades);
            flowAssessmentGrades.Controls.Add(ctrlAssessmentGrades);
            flowAssessmentGrades.Controls.Add(ctrlAssessmentGrades);
            flowAssessmentGrades.Controls.Add(ctrlAssessmentGrades);
        }

        private void addAssessmentFeedback()
        {
            ctrlAssessmentFeedback ctrlAssessmentFeedback = new ctrlAssessmentFeedback();
            flowAssessmentFeedback.Controls.Add(ctrlAssessmentFeedback);
        }

        

        private void btnViewModuleDetail_Click(object sender, EventArgs e)
        {
            pnlModulePreviewAll.Visible = false;
            pnlModuleDetails.Visible = true;
        }
    }
}
