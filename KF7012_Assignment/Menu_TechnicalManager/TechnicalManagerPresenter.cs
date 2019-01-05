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
    }
}
