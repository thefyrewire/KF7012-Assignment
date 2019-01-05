using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF7012_Assignment
{
    public partial class Form_Menu_TechnicalManager : Form, ITechnicalManagerGUI
    {
        private TechnicalManagerPresenter presenter;

        public Form_Menu_TechnicalManager()
        {
            this.InitializeComponent();
        }

        public void register(TechnicalManagerPresenter FP)
        {
            presenter = FP;
        }

        public void populateRequestJob(Job job, Machine machine)
        {
            dgv_RequestJobs.Rows.Add(job.jobID, job.companyID, machine.sizeComplexity, job.fault, job.dateReported);
        }

        public void populateProblemJob(Job job, Machine machine)
        {
            int index = dgv_ProblemJobs.Rows.Add(job.jobID, job.companyID, machine.sizeComplexity, job.fault, job.lastStartDate);
            dgv_ProblemJobs.Rows[index].DefaultCellStyle.BackColor = Color.Red;
        }
    }
}
