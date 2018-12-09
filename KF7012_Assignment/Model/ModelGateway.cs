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
            this.addJob(4, 4567, "Faulty chassis", new DateTime(2018, 3, 27), 1);
            this.addJob(5, 4567, "Electrical fault", new DateTime(2018, 8, 14), 5);

            // ADD MACHINES
            this.addMachine("mch500", 1234, "CT001", 4);
            this.addMachine("mch501", 1234, "CT002", 3);
            this.addMachine("mch502", 4567, "BLUE_Homer", 5);
            this.addMachine("mch503", 4567, "BLUE_Marge", 2);
            this.addMachine("mch504", 4567, "BLUE_Bart", 1);


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
                    companyID = companyID,
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
                List<Job> jobsForCompany = context.Jobs.Where(job => job.companyID == companyID).ToList<Job>();
                return jobsForCompany;
            }
        }


        /* ----------------- */
        /* --- ENGINEERS --- */
        /* ----------------- */

        public void addEngineer(string engineerID, string name, string profile, string skills)
        {
            using (Model context = new Model())
            {
                context.Engineers.Add(new Engineer()
                {
                    engineerID = engineerID,
                    name = name,
                    profile = profile,
                    skills = skills
                });
            }
        }


        /* ---------------- */
        /* --- MACHINES --- */
        /* ---------------- */

        public void addMachine(string machineID, int companyID, string assetTag, int sizeComplexity)
        {
            using (Model context = new Model())
            {
                Company company = this.getCompany(companyID);
                context.Machines.Add(new Machine()
                {
                    machineID = machineID,
                    companyID = companyID,
                    assetTag = assetTag,
                    sizeComplexity = sizeComplexity
                });

                context.SaveChanges();
            }
        }

        public List<Machine> getMachinesForCompany(int companyID)
        {
            using (Model context = new Model())
            {
                List<Machine> machinesForCompany = context.Machines.Where(machine => machine.companyID == companyID).ToList<Machine>();
                return machinesForCompany;
            }
        }


        /* ---------------------- */
        /* --- SCHEDULED JOBS --- */
        /* ---------------------- */


        /* ---------------------- */
        /* --- CLOSED JOBS --- */
        /* ---------------------- */


    }
}
