﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class LoginPresenter
    {
        private ILoginGUI screen;

        ModelGateway model = new ModelGateway(); 

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
            model.resetDatabase();
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

            List<Job> jobs = model.getJobsForCompany(1234);
            foreach (Job job in jobs)
            {
                Company company = model.getCompanyByID(job.companyID);
                Machine machine = model.getMachine(job.machineID);
                Console.WriteLine("Job: " + job.description + " at " + company.name + " for " + machine.assetTag + " which has a complexity of " + machine.sizeComplexity);
            }

            if (!string.IsNullOrEmpty(screen.getAttemptUsername()) && !string.IsNullOrEmpty(screen.getAttemptPassword()))
            {
                // PasswordHelper passwordHelper = new PasswordHelper();
                // string hashed = passwordHelper.hashPassword(screen.getAttemptPassword());
                bool verified = model.verifyUser(screen.getAttemptUsername(), screen.getAttemptPassword());
                
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
