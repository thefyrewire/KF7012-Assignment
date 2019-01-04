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
    public partial class Form_Jobs : Form, IJobsGUI
    {
        private JobsPresenter presenter;

        public Form_Jobs()
        {
            this.InitializeComponent();
        }

        public void register(JobsPresenter FP)
        {
            presenter = FP;
        }

        public void populateJob(Job job)
        {
            dgv_Jobs.Rows.Add(job.jobID, job.companyID, job.machineID, job.fault, job.dateReported, job.urgency, job.lastStartDate, job.state);
        }
    }
}
