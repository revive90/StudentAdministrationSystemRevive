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
    public partial class ctrlAD_AssessmentAdd : UserControl
    {
        public ctrlAD_AssessmentAdd()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }
    }
}
