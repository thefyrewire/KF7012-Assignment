using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class ModelGateway
    {
        /* -------------- */
        /* --- GLOBAL --- */
        /* -------------- */

        public void deleteDatabase()
        {
            using (Model context = new Model()) { context.Database.Delete(); }
        }

        public void resetDatabase()
        {
            this.deleteDatabase();

            // ADD USERS
            this.addUser(0000, "admin", "admin", "admin");
            this.addUser(1701, "w1701", "pass", "user");
            this.addUser(1702, "w1702", "pass", "user");
            this.addUser(1703, "w1703", "pass", "user");
            this.addUser(1704, "w1704", "pass", "user");

            // ADD COMPANIES
            this.addCompany(1234, "ComTech Solutions", "Newcastle");
            this.addCompany(4567, "Blue Arm Robotics", "London");

            // ADD JOBS
            this.addJob(1, 1234, "Leaking pipe", new DateTime(2018, 1, 18), 2);
            this.addJob(2, 1234, "Broken screen", new DateTime(2018, 6, 20), 5);
            this.addJob(3, 1234, "Malfunctioning robot arm", new DateTime(2018, 10, 26), 1);
        }


        /* ------------- */
        /* --- USERS --- */
        /* ------------- */

        public void addUser(int userID, string username, string password, string profile)
        {
            using (var context = new Model())
            {
                context.Users.Add(new User()
                {
                    userID = userID,
                    username = username,
                    password = password,
                    profile = profile
                });

                context.SaveChanges();
            }
        }

        public List<User> getUsers()
        {
            using (Model context = new Model())
            {
                List<User> users = context.Users.ToList<User>();
                return users;
            }
        }

        public bool verifyUser(string username, string password)
        {
            using (Model context = new Model())
            {
                List<User> users = this.getUsers();
                User userToVerify = users.Where(user => user.username == username && user.password == password).FirstOrDefault<User>();
                if (userToVerify != null)
                    return true;

                return false;
            }
        }


        /* ----------------- */
        /* --- COMPANIES --- */
        /* ----------------- */

        public void addCompany(int companyID, string name, string location)
        {
            using (Model context = new Model())
            {
                context.Companies.Add(new Company()
                {
                    companyID = companyID,
                    name = name,
                    location = location
                });

                context.SaveChanges();
            }
        }

        public List<Company> getCompanies()
        {
            using (Model context = new Model())
            {
                List<Company> companies = context.Companies.ToList<Company>();
                return companies;
            }
        }

        public Company getCompany(int companyID)
        {
            using (Model context = new Model())
            {
                List<Company> companies = this.getCompanies();
                Company companyToGet = companies.Where(company => company.companyID == companyID).FirstOrDefault<Company>();
                return companyToGet;
            }
        }

        
        /* ------------ */
        /* --- JOBS --- */
        /* ------------ */

        public void addJob(int jobID, int companyID, /*Machine machineID,*/ string description, DateTime dateReported, int priority)
        {
            using (Model context = new Model())
            {
                Company company = this.getCompany(companyID);
                context.Jobs.Add(new Job()
                {
                    jobID = jobID,
                    Company = company,
                    /*machineID = machineID,*/
                    description = description,
                    dateReported = dateReported,
                    priority = priority
                });

                context.SaveChanges();
            }
        }

        public List<Job> getJobsForCompany(int companyID)
        {
            using (Model context = new Model())
            {
                Company company = this.getCompany(companyID);
                List<Job> jobsForCompany = context.Jobs.Where(job => job.Company == company).ToList<Job>();
                return jobsForCompany;
            }
        }
    }
}
