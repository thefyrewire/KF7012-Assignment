using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class JobsPresenter
    {
        private IJobsGUI screen;
        ModelRepository repository = new ModelRepository();

        public JobsPresenter(IJobsGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            updateView();
        }

        public void updateView()
        {
            List<Job> jobs = repository.getSortedJobs();
            foreach (Job job in jobs)
            {
                screen.populateJob(job);
            }
        }

        public void showJobDetailsForm(int index)
        {
            screen.showJobDetailsForm(index);
        }
    }
}
