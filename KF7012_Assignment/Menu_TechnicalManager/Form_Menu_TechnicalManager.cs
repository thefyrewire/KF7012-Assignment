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
            dgv_RequestJobs.Rows.Add(job.jobID, job.companyID, machine.sizeComplexity, job.fault, job.urgency, job.dateReported);
        }

        public void populateProblemJob(Job job, Machine machine)
        {
            int index = dgv_ProblemJobs.Rows.Add(job.jobID, job.companyID, machine.sizeComplexity, job.fault, job.urgency, job.lastStartDate);
            dgv_ProblemJobs.Rows[index].DefaultCellStyle.BackColor = Color.Red;
        }

        public void clearRequestJobs()
        {
            dgv_RequestJobs.Rows.Clear();
        }

        public void clearProblemJobs()
        {
            dgv_ProblemJobs.Rows.Clear();
        }

        public void setReadOnlyFields()
        {
            txt_JobID.ReadOnly = true;
            txt_Skills.ReadOnly = true;
        }

        public int jobID
        {
            set { txt_JobID.Text = value.ToString(); }
            get
            {
                int ID;
                int.TryParse(txt_JobID.Text, out ID);
                return ID;
            }
        }

        public void populateEngineer(string name)
        {
            cmb_AssignedEngineer.Items.Add(name);
        }

        public void clearEngineers()
        {
            cmb_AssignedEngineer.Items.Clear();
        }

        public string getSelectedEngineer()
        {
            return cmb_AssignedEngineer.Text;
        }

        public string skills
        {
            set { txt_Skills.Text = value; }
            get { return txt_Skills.Text; }
        }

        public void clearSkills()
        {
            txt_Skills.Clear();
        }

        public int estimatedDays
        {
            set { nud_EstimatedDays.Value = value; }
            get { return Convert.ToInt32(nud_EstimatedDays.Value); }
        }

        private void dgv_RequestJobs_CellClick(Object sender, DataGridViewCellEventArgs e)
        {
            presenter.dgv_RequestJobs_CellClick(Convert.ToInt32(dgv_RequestJobs.Rows[e.RowIndex].Cells["estim_JobID"].Value));
        }

        private void txt_Skills_Leave(Object sender, EventArgs e)
        {
            presenter.txt_Skills_Leave();
        }

        private void dgv_RequestJobs_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            presenter.dgv_CellDoubleClick(Convert.ToInt32(dgv_RequestJobs.Rows[e.RowIndex].Cells["estim_JobID"].Value));
        }

        private void dgv_ProblemJobs_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            presenter.dgv_CellDoubleClick(Convert.ToInt32(dgv_ProblemJobs.Rows[e.RowIndex].Cells["prob_JobID"].Value));
        }

        public void showError(string error)
        {
            lbl_Error.Text = error;
            lbl_Error.Visible = true;
        }

        public void hideError()
        {
            lbl_Error.Visible = false;
        }

        private void btn_ScheduleJob_Click(Object sender, EventArgs e)
        {
            presenter.btn_ScheduleJob_Click();
        }

        private void btn_RegisterCompany_Click(Object sender, EventArgs e)
        {
            presenter.showRegisterCompanyForm();
        }

        private void btn_RegisterJob_Click(Object sender, EventArgs e)
        {
            presenter.showRegisterJobForm();
        }

        private void btn_Jobs_Click(Object sender, EventArgs e)
        {
            presenter.showJobsForm();
        }

        public void showJobDetailsForm(Job job)
        {
            Form_JobDetails f1 = new Form_JobDetails();
            JobDetailsPresenter FM = new JobDetailsPresenter(f1);
            FM.populateDetails(job);
            f1.ShowDialog();
        }

        public void showRegisterCompanyForm()
        {
            this.Hide();
            Form_RegisterCompany f1 = new Form_RegisterCompany();
            RegisterCompanyPresenter FM = new RegisterCompanyPresenter(f1);
            f1.ShowDialog();
            this.Show();
        }

        public void showRegisterJobForm()
        {
            this.Hide();
            Form_RegisterJob f1 = new Form_RegisterJob();
            RegisterJobPresenter FM = new RegisterJobPresenter(f1);
            f1.ShowDialog();
            this.Show();
        }

        public void showJobsForm()
        {
            this.Hide();
            Form_Jobs f1 = new Form_Jobs();
            JobsPresenter FM = new JobsPresenter(f1);
            f1.ShowDialog();
            this.Show();
        }
    }
}
