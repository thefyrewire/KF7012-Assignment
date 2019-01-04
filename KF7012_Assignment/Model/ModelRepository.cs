using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class ModelRepository : IModelRepository
    {
        /* -------------- */
        /* --- GLOBAL --- */
        /* -------------- */

        /*private IModelRepository repo;

        public ModelRepository(IModelRepository repo)
        {
            this.repo = repo;
            repo.register(this);
        }*/

        public void deleteDatabase()
        {
            using (Model context = new Model()) { context.Database.Delete(); }
        }

        public void resetDatabase()
        {
            deleteDatabase();

            // ADD USERS
            addUser(0000, "admin", "hGTdTaRRFO8KkxXlaDMhO+G2Q0ZG++z58SnIeC27otrEPqNr", "admin"); // admin
            addUser(1701, "w1701", "w9vAcmhb2aKIIvChFld1g+pqeSxXTbFvJfZT8Z32fRXHumRK", "user"); // password123
            addUser(1702, "w1702", "YY7QFxa3L6YBeAOlym7LrjFfXdkqzSnZ71udnj8k3UpPvLMo", "user"); // th1s1sMYpa5sw0rD
            addUser(1703, "w1703", "u5Z1ko9IFcMaHmDUzR6eCYdf0IjOfuTROmnj3FsPhbxx0bR2", "user"); // secure111
            addUser(1704, "w1704", "/T5yjATcnLwLimMbODNhhpnbiaaIJE5o+1TFznXqvCCoqEFm", "user"); // ppaasswwoorrdd

            // ADD COMPANIES
            addCompany(1000, "ComTech Solutions", "Newcastle");
            addCompany(1001, "Blue Arm Robotics", "London");

            // ADD MACHINES
            addMachine("mch500", 1000, "CT001", 4);
            addMachine("mch501", 1000, "CT002", 3);
            addMachine("mch502", 1001, "BLUE_Homer", 5);
            addMachine("mch503", 1001, "BLUE_Marge", 2);
            addMachine("mch504", 1001, "BLUE_Bart", 1);

            // ADD JOBS
            addJob(1, 1000, "mch500", "Leaking pipe", new DateTime(2018, 12, 29), 2, new DateTime(2019, 1, 12), "ESTIMATE NEEDED");
            addJob(2, 1000, "mch501", "Broken screen", new DateTime(2018, 11, 20), 5, new DateTime(2018, 11, 21), "ESTIMATE NEEDED");
            addJob(3, 1000, "mch501", "Malfunctioning robot arm", new DateTime(2018, 12, 26), 1, new DateTime(2019, 2, 4), "ESTIMATE NEEDED");
            addJob(4, 1001, "mch503", "Faulty chassis", new DateTime(2018, 12, 20), 0, new DateTime(2019, 3, 20), "ESTIMATE NEEDED");
            addJob(5, 1001, "mch504", "Electrical fault", new DateTime(2019, 1, 2), 5, new DateTime(2019, 1, 3), "ESTIMATE NEEDED");
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
                PasswordHelper passwordHelper = new PasswordHelper();
                User userToVerify = context.Users.Where(user => user.username == username).FirstOrDefault<User>();
                if (userToVerify != null && passwordHelper.verifyPassword(password, userToVerify.password))
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

        public Company getCompanyByID(int companyID)
        {
            using (Model context = new Model())
            {
                Company companyToGet = context.Companies.Where(company => company.companyID == companyID).FirstOrDefault<Company>();
                return companyToGet;
            }
        }

        public Company getCompanyByName(string name)
        {
            using (Model context = new Model())
            {
                Company companyToGet = context.Companies.Where(company => company.name == name).FirstOrDefault<Company>();
                return companyToGet;
            }
        }

        public int generateCompanyID()
        {
            using (Model context = new Model())
            {
                int max = context.Companies.Max(company => company.companyID);
                return max + 1;
            }
        }

        
        /* ------------ */
        /* --- JOBS --- */
        /* ------------ */

        public void addJob(int jobID, int companyID, string machineID, string fault, DateTime dateReported, int urgency, DateTime lastStartDate, string state)
        {
            using (Model context = new Model())
            {
                context.Jobs.Add(new Job()
                {
                    jobID = jobID,
                    companyID = companyID,
                    machineID = machineID,
                    fault = fault,
                    dateReported = dateReported,
                    urgency = urgency,
                    lastStartDate = lastStartDate,
                    state = state
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

        public int generateJobID()
        {
            using (Model context = new Model())
            {
                int max = context.Jobs.Max(job => job.jobID);
                return max + 1;
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

        public Machine getMachine(string machineID)
        {
            using (Model context = new Model())
            {
                Machine machineToGet = context.Machines.Where(machine => machine.machineID == machineID).FirstOrDefault<Machine>();
                return machineToGet;
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

        public string generateMachineID()
        {
            using (Model context = new Model())
            {
                string[] parsed = context.Machines.Max(machine => machine.machineID).Split(new char[] { 'm', 'c', 'h' });
                int id;
                int.TryParse(parsed[3], out id);
                return "mch" + (id + 1).ToString();
            }
        }


        /* ---------------------- */
        /* --- SCHEDULED JOBS --- */
        /* ---------------------- */


        /* ------------------- */
        /* --- CLOSED JOBS --- */
        /* ------------------- */


    }
}
