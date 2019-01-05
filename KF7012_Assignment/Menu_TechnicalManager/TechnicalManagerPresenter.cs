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
            populateRequestJobs();
            populateProblemJobs();
            screen.setReadOnlyFields();
            updateView();
        }

        private void updateView()
        {
            if (screen.jobID.ToString() != null)
            {
                populateEngineers();
                screen.estimatedDays = 0;
                screen.clearSkills();
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

        public void txt_Skills_Leave()
        {
            string[] split = screen.getSelectedEngineer().Split(new Char[] { ' ', '-', ' '});
            int engineerID;
            int.TryParse(split[0], out engineerID);
            Engineer engineer = repository.getEngineerByID(engineerID);
            screen.skills = engineer.skills;
        }

        public void dgv_CellDoubleClick(int jobID)
        {
            Job job = repository.getJobByID(jobID);
            if (job != null)
                screen.showJobDetailsForm(job);
        }

        public void btn_ScheduleJob_Click()
        {

        }
    }
}
