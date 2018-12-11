using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface IJobsGUI
    {
        void register(JobsPresenter FM);
        void setReadOnlyFields();
        string companyID { get; set; }
        void setCompanyName(string companyName);
        void setLocation(string location);
        void clearCompanyNameLocation();
        void showRegisterMachineForm();
        void autofillNameLocation();
    }
}
