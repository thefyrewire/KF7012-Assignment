using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class LoginPresenter
    {
        private ILoginGUI screen;
        // private IModelRepository repository;
        ModelRepository repository = new ModelRepository();

        public LoginPresenter(ILoginGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.hideError();
            // updateView();

            // DB TEST
            repository.resetDatabase();
        }

        /*public void updateView()
        {
        }*/

        public void btn_Login_Click()
        {
            // DB TEST
            /* // List<User> users = model.getUsers();
            foreach (User user in model.getUsers())
            {
                Console.WriteLine(user.username);
            } */

            /*List<Machine> machines = model.getMachinesForCompany(4567);
            foreach (Machine machine in machines)
            {
                Company company = model.getCompany(machine.companyID);
                Console.WriteLine(machine.machineID + "/" + machine.assetTag + " @ " + model.getCompany(machine.companyID).name);
            }*/

            List<Job> jobs = repository.getJobsForCompany(1234);
            foreach (Job job in jobs)
            {
                Company company = repository.getCompanyByID(job.companyID);
                Machine machine = repository.getMachine(job.machineID);
                Console.WriteLine("Job: " + job.description + " at " + company.name + " for " + machine.assetTag + " which has a complexity of " + machine.sizeComplexity);
            }

            if (!string.IsNullOrEmpty(screen.getAttemptUsername()) && !string.IsNullOrEmpty(screen.getAttemptPassword()))
            {
                bool verified = repository.verifyUser(screen.getAttemptUsername(), screen.getAttemptPassword());
                
                if (verified) screen.showMainForm();
                else screen.showError("Incorrect username or password.");
            }
            else
            { 
                Console.WriteLine("Fill in a field, dummy!");
                screen.showError("Enter username and password.");
            } 
        }
    }
}
