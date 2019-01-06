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

        public void dgv_Jobs_CellDoubleClick(int jobID)
        {
            Job job = repository.getJobByID(jobID);
            if (job != null)
                screen.showJobDetailsForm(job);
        }

        public void btn_Info_Click()
        {
            screen.message("Jobs are primarily sorted by urgency, unless the last permissible start date is within a week, in which case, those jobs will be pushed towards the top and sorted by proximity to the starting deadline.", "Scheduling information");
        }
    }
}
