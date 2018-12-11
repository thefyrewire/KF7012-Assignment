using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    interface IModelRepository
    {
        void deleteDatabase();
        void resetDatabase();


        void addUser(int userID, string username, string password, string profile);
        List<User> getUsers();
        bool verifyUser(string username, string password);


        void addCompany(int companyID, string name, string location);
        List<Company> getCompanies();
        Company getCompanyByID(int companyID);
        Company getCompanyByName(string name);
        int generateCompanyID();


        void addJob(int jobID, int companyID, string machineID, string description, DateTime dateReported, int priority);
        List<Job> getJobsForCompany(int companyID);
        void addEngineer(string engineerID, string name, string profile, string skills);
        void addMachine(string machineID, int companyID, string assetTag, int sizeComplexity);
        Machine getMachine(string machineID);
        List<Machine> getMachinesForCompany(int companyID);

    }
}
