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
    public interface ITechnicalManagerGUI
    {
        void register(TechnicalManagerPresenter FM);
        void populateRequestJob(Job job, Machine machine);
        void populateProblemJob(Job job, Machine machine);
        void clearRequestJobs();
        void clearProblemJobs();
        void setReadOnlyFields();
        int jobID { get; set; }
        void populateEngineer(string name);
        void clearEngineers();
        string getSelectedEngineer();
        string skills { get; set; }
        void clearSkills();
        int estimatedDays { get; set; }
        void showError(string error);
        void hideError();
        void showJobDetailsForm(Job job);
        void showRegisterCompanyForm();
        void showRegisterJobForm();
        void showJobsForm();
    }
}
