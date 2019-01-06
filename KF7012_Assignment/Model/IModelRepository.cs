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
    public interface IModelRepository
    {
        void deleteDatabase();
        void resetDatabase();


        void addUser(int userID, string username, string password, string profile);
        List<User> getUsers();
        string verifyUser(string username, string password);


        void addCompany(int companyID, string name, string location);
        List<Company> getCompanies();
        Company getCompanyByID(int companyID);
        Company getCompanyByName(string name);
        int generateCompanyID();


        void addJob(int companyID, string machineID, string description, DateTime dateReported, int priority, DateTime lastStartDate, string state);
        List<Job> getJobsForCompany(int companyID);
        Job getJobByID(int jobID);
        List<Job> getCriticalJobs();
        List<Job> getNonCriticalJobs();
        List<Job> getSortedJobs();
        List<Job> getRequestJobs();
        List<Job> getProblemJobs();
        void updateJobStateByID(int jobID, string state);
        int generateJobID();


        void addEngineer(string name, string profile, string skills);
        List<Engineer> getEngineers();
        Engineer getEngineerByID(int engineerID);

        void addMachine(string machineID, int companyID, string assetTag, int sizeComplexity, string description);
        Machine getMachineByID(string machineID);
        List<Machine> getMachinesForCompany(int companyID);
        string generateMachineID();


        void addScheduledJob(int jobID, int assignedEngineer, int estimatedDays);
        ScheduledJob getScheduledJobByID(int jobID);

    }
}
