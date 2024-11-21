using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAdministrationSystemRevive.Views.UserAdministrator.Assessments
{
    public partial class ctrlAssessments : UserControl
    {
        public ctrlAssessments()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }
    }
}
