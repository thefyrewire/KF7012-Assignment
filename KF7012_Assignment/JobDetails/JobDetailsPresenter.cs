using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class JobDetailsPresenter
    {
        private IJobDetailsGUI screen;
        ModelRepository repository = new ModelRepository();

        public JobDetailsPresenter(IJobDetailsGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.setReadOnlyFields();
        }

        public void populateDetails(Job job)
        {
            Company company = repository.getCompanyByID(job.companyID);
            Machine machine = repository.getMachineByID(job.machineID);
            screen.jobID = job.jobID;
            screen.companyID = job.companyID;
            screen.companyName = company.name;
            screen.location = company.location;
            screen.machineID = job.machineID;
            screen.assetTag = machine.assetTag;
            screen.sizeComplexity = machine.sizeComplexity;
            screen.description = machine.description;
            screen.fault = job.fault;
            screen.urgency = job.urgency;
            screen.setDateReported(job.dateReported);
            screen.setLastStartDate(job.lastStartDate);
        }
    }
}
