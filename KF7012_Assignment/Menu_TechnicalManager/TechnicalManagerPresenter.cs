/*
 Patricia Fernandes
 Bogdana Grigore
 Michael Hay

 https://gitlab.com/thefyrewire/kf7012-assignment
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class TechnicalManagerPresenter
    {
        private ITechnicalManagerGUI screen;
        private ModelRepository repository = new ModelRepository();

        public TechnicalManagerPresenter(ITechnicalManagerGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.setReadOnlyFields();
            refreshJobs();
            updateView();
        }

        private void refreshJobs()
        {
            screen.clearProblemJobs();
            screen.clearRequestJobs();
            populateRequestJobs();
            populateProblemJobs();
        }

        private void updateView()
        {
            if (screen.jobID.ToString() != null)
            {
                populateEngineers();
                screen.estimatedDays = 0;
                screen.clearSkills();
                screen.hideError();
            }
        }

        private void populateRequestJobs()
        {
            List<Job> jobs = repository.getRequestJobs();
            foreach (Job job in jobs)
            {
                Machine machine = repository.getMachineByID(job.machineID);
                screen.populateRequestJob(job, machine);
            }
        }

        private void populateProblemJobs()
        {
            List<Job> jobs = repository.getProblemJobs();
            foreach (Job job in jobs)
            {
                Machine machine = repository.getMachineByID(job.machineID);
                screen.populateProblemJob(job, machine);
            }
        }

        private void populateEngineers()
        {
            screen.clearEngineers();

            List<Engineer> engineers = repository.getEngineers();
            if (engineers.Count > 0)
            {
                foreach (Engineer engineer in engineers)
                {
                    screen.populateEngineer(engineer.engineerID.ToString() + " - " + engineer.name);
                }
            }
        }

        public void dgv_RequestJobs_CellClick(int jobID)
        {
            Job job = repository.getJobByID(jobID);
            if (job != null)
            {
                screen.jobID = job.jobID;
                updateView();
            } 
        }

        private int getSelectedEngineerID()
        {
            string[] split = screen.getSelectedEngineer().Split(new Char[] { ' ', '-', ' ' });
            int engineerID;
            int.TryParse(split[0], out engineerID);
            return engineerID;
        }

        public void txt_Skills_Leave()
        {
            int engineerID = getSelectedEngineerID();
            Engineer engineer = repository.getEngineerByID(engineerID);
            if (engineer != null)
            {
                screen.skills = engineer.skills;
            }
            
        }

        public void dgv_CellDoubleClick(int jobID)
        {
            Job job = repository.getJobByID(jobID);
            if (job != null)
                screen.showJobDetailsForm(job);
        }

        public void btn_ScheduleJob_Click()
        {
            if (screen.jobID != 0)
            {
                if (!string.IsNullOrEmpty(screen.getSelectedEngineer()))
                {
                    screen.hideError();

                    repository.addScheduledJob(screen.jobID, getSelectedEngineerID(), screen.estimatedDays);
                    repository.updateJobStateByID(screen.jobID, "PENDING");

                    screen.clearJobID();
                    refreshJobs();
                    updateView();
                }
                else screen.showError("Select an engineer to assign!");
            }
            else screen.showError("Select a job to schedule!");
        }

        public void showRegisterCompanyForm()
        {
            screen.showRegisterCompanyForm();
        }

        public void showRegisterJobForm()
        {
            screen.showRegisterJobForm();
        }

        public void showJobsForm()
        {
            screen.showJobsForm();
        }
    }
}
