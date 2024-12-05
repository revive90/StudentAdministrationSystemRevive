﻿using StudentAdministrationSystemRevive.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrationSystemRevive.BusinessLogic
{
    public class CohortServices
    {
        private readonly CohortRepository _repository;
        public CohortServices()
        {
            _repository = new CohortRepository();
        }

        // Adding a new Cohort
        public bool AddCohort(Cohort cohort)
        {
            if (cohort == null)
            {
                MessageBox.Show("Cohort is Null", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return _repository.InsertCohort(cohort);
            }

        }

        public List<Cohort> GetCohorts()
        {
            return _repository.GetAllCohorts();
        }
    }
}