using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface IJobsGUI
    {
        void register(JobsPresenter FM);
        void populateJob(Job job);
    }
}
