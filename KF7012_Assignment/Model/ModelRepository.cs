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
            addUser(0000, "admin", "hGTdTaRRFO8KkxXlaDMhO+G2Q0ZG++z58SnIeC27otrEPqNr", "techmngr"); // admin
            addUser(1701, "w1701", "w9vAcmhb2aKIIvChFld1g+pqeSxXTbFvJfZT8Z32fRXHumRK", "user"); // password123
            addUser(1702, "w1702", "YY7QFxa3L6YBeAOlym7LrjFfXdkqzSnZ71udnj8k3UpPvLMo", "user"); // th1s1sMYpa5sw0rD
            addUser(1703, "w1703", "u5Z1ko9IFcMaHmDUzR6eCYdf0IjOfuTROmnj3FsPhbxx0bR2", "user"); // secure111
            addUser(1704, "w1704", "/T5yjATcnLwLimMbODNhhpnbiaaIJE5o+1TFznXqvCCoqEFm", "user"); // ppaasswwoorrdd

            // ADD COMPANIES
            addCompany(1000, "ComTech Solutions", "Newcastle");
            addCompany(1001, "Blue Arm Robotics", "London");

            // ADD MACHINES
            addMachine("mch500", 1000, "CT001", 4, "Large and fairly old tank, not many moving parts.");
            addMachine("mch501", 1000, "CT002", 3, "Medium-sized cutting machine.");
            addMachine("mch502", 1001, "BLUE_Homer", 5, "Large and complex manufacturing machine.");
            addMachine("mch503", 1001, "BLUE_Marge", 2, "Semi-large artboard cutting machine.");
            addMachine("mch504", 1001, "BLUE_Bart", 0, "Table-top parts stand.");

            // ADD JOBS
            addJob(1000, "mch500", "Leaking pipe", new DateTime(2018, 12, 29), 2, new DateTime(2019, 1, 12), "ESTIMATE NEEDED");
            addJob(1000, "mch501", "Broken screen", new DateTime(2018, 11, 20), 4, new DateTime(2018, 11, 21), "ESTIMATE NEEDED");
            addJob(1000, "mch500", "Damaged components", new DateTime(2018, 11, 25), 2, new DateTime(2018, 11, 26), "PENDING");
            addJob(1000, "mch501", "Malfunctioning robot arm", new DateTime(2018, 12, 26), 5, new DateTime(2019, 2, 4), "PENDING");
            addJob(1001, "mch503", "Faulty chassis", new DateTime(2018, 12, 20), 0, new DateTime(2019, 3, 20), "ESTIMATE NEEDED");
            addJob(1001, "mch504", "Electrical fault", new DateTime(2019, 1, 2), 5, new DateTime(2019, 1, 3), "ACTIVE");
            addJob(1001, "mch503", "Strange sounds", new DateTime(2018, 12, 29), 1, new DateTime(2019, 1, 8), "ESTIMATE NEEDED");

            // ADD SCHEDULED JOBS
            addScheduledJob(1, 1, 10);
            addScheduledJob(2, 1, 15);

            // ADD ENGINEERS
            addEngineer("Nelda Kleiber", "engineer", "Electronics, heavy machinery");
            addEngineer("Iola Shellhammer", "engineer", "Robotics, soldering");
            addEngineer("Rossana Sherrard", "engineer", "Glassware, soldering");
            addEngineer("Nyla Wilczynski", "engineer", "Heavy machinery");
            addEngineer("Lloyd Fackler", "engineer", "Robotics");
            addEngineer("John Cornett", "engineer", "Soldering");
            addEngineer("Kenneth Sanderlin", "engineer", "Metalworks, soldering");
            addEngineer("Jamie Kangas", "engineer", "Electronics");
            addEngineer("Desmond Lamb", "engineer", "Robotics, electronics");
            addEngineer("Brandon Nowakowski", "engineer", "Metalworks");
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

        public string verifyUser(string username, string password)
        {
            using (Model context = new Model())
            {
                PasswordHelper passwordHelper = new PasswordHelper();
                User userToVerify = context.Users.Where(user => user.username == username).FirstOrDefault<User>();
                if (userToVerify != null && passwordHelper.verifyPassword(password, userToVerify.password))
                    return userToVerify.profile;

                return null;
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

        public void addJob(int companyID, string machineID, string fault, DateTime dateReported, int urgency, DateTime lastStartDate, string state)
        {
            using (Model context = new Model())
            {
                context.Jobs.Add(new Job()
                {
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

        public Job getJobByID(int jobID)
        {
            using (Model context = new Model())
            {
                Job jobToGet = context.Jobs.Where(job => job.jobID == jobID).FirstOrDefault<Job>();
                return jobToGet;
            }
        }

        public List<Job> getCriticalJobs()
        {
            using (Model context = new Model())
            {
                List<Job> criticalJobs = context.Jobs.ToList<Job>().FindAll(job => job.lastStartDate.Subtract(DateTime.Now).Days <= 7).OrderBy(job => job.lastStartDate.Subtract(DateTime.Now).Days).ToList<Job>();
                return criticalJobs;
            }
        }

        public List<Job> getNonCriticalJobs()
        {
            using (Model context = new Model())
            {
                List<Job> jobs = context.Jobs.ToList<Job>().FindAll(job => job.lastStartDate.Subtract(DateTime.Now).Days > 7).OrderByDescending(job => job.urgency).ToList<Job>();
                return jobs;
            }
        }

        public List<Job> getSortedJobs()
        {
            List<Job> sortedJobs = getCriticalJobs();
            List<Job> jobs = getNonCriticalJobs();
            sortedJobs.AddRange(jobs);

            return sortedJobs;
        }

        public List<Job> getRequestJobs()
        {
            using (Model context = new Model())
            {
                List<Job> jobs = context.Jobs.ToList<Job>().FindAll(job => job.state == "ESTIMATE NEEDED").OrderByDescending(job => job.urgency).ToList<Job>();
                return jobs;
            }
        }

        public List<Job> getProblemJobs()
        {
            using (Model context = new Model())
            {
                List<Job> jobs = context.Jobs.ToList<Job>().FindAll(job => job.state == "ESTIMATE NEEDED" || job.state == "PENDING").FindAll(job => job.lastStartDate.Subtract(DateTime.Now).Days <= 0).OrderBy(job => job.lastStartDate.Subtract(DateTime.Now).Days).ToList<Job>();
                return jobs;
            }
        }

        public void updateJobStateByID(int jobID, string state)
        {
            using (Model context = new Model())
            {
                Job jobToUpdate = context.Jobs.ToList<Job>().Where(job => job.jobID == jobID).FirstOrDefault<Job>();
                jobToUpdate.state = state;

                context.SaveChanges();
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

        public void addEngineer(string name, string profile, string skills)
        {
            using (Model context = new Model())
            {
                context.Engineers.Add(new Engineer()
                {
                    name = name,
                    profile = profile,
                    skills = skills
                });

                context.SaveChanges();
            }
        }

        public List<Engineer> getEngineers()
        {
            using (Model context = new Model())
            {
                List<Engineer> engineers = context.Engineers.ToList<Engineer>();
                return engineers;
            }
        }

        public Engineer getEngineerByID(int engineerID)
        {
            using (Model context = new Model())
            {
                Engineer engineerToGet = context.Engineers.Where(engineer => engineer.engineerID == engineerID).FirstOrDefault<Engineer>();
                return engineerToGet;
            }
        }


        /* ---------------- */
        /* --- MACHINES --- */
        /* ---------------- */

        public void addMachine(string machineID, int companyID, string assetTag, int sizeComplexity, string description)
        {
            using (Model context = new Model())
            {
                context.Machines.Add(new Machine()
                {
                    machineID = machineID,
                    companyID = companyID,
                    assetTag = assetTag,
                    sizeComplexity = sizeComplexity,
                    description = description
                });

                context.SaveChanges();
            }
        }

        public Machine getMachineByID(string machineID)
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

        public void addScheduledJob(int jobID, int assignedEngineer, int estimatedDays)
        {
            using (Model context = new Model())
            {
                context.ScheduledJobs.Add(new ScheduledJob()
                {
                    jobID = jobID,
                    assignedEngineer = assignedEngineer,
                    estimatedDays = estimatedDays
                });

                context.SaveChanges();
            }
        }

        public ScheduledJob getScheduledJobByID(int jobID)
        {
            using (Model context = new Model())
            {
                ScheduledJob jobToGet = context.ScheduledJobs.Where(scheduledJob => scheduledJob.jobID == jobID).FirstOrDefault<ScheduledJob>();
                return jobToGet;
            }
        }


        /* ------------------- */
        /* --- CLOSED JOBS --- */
        /* ------------------- */


    }
}
