/*
 Patricia Fernandes
 Bogdana Grigore
 Michael Hay

 https://gitlab.com/thefyrewire/kf7012-assignment
*/

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
        private ModelRepository repository = new ModelRepository();

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

        private void dgv_Jobs_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            presenter.dgv_Jobs_CellDoubleClick(Convert.ToInt32(dgv_Jobs.Rows[e.RowIndex].Cells["JobID"].Value));
        }

        public void showJobDetailsForm(Job job)
        {
            Form_JobDetails f1 = new Form_JobDetails();
            JobDetailsPresenter FM = new JobDetailsPresenter(f1);
            FM.populateDetails(job);
            f1.ShowDialog();
        }
    }
}
