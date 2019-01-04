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
        int companyID { get; set; }
        string companyName { get; set; }
        string location { get; set; }
        string machineID { get; set; }
        string assetTag { get; set; }
        int sizeComplexity { get; set; }
        string fault { get; set; }
        string description { get; set; }
        int urgency { get; set; }
        void showFaultError(bool boolean);
        void setReadOnlyFields();
        void clearCompanyDetails();
        void clearMachineIDs();
        void clearMachineDetails();
        void btn_RegisterMachineEnabled(bool allowed);
        void btn_RegisterJobEnabled(bool allowed);
        void cmb_MachineIDEnabled(bool allowed);
        void jobDetailsEnabled(bool allowed);
        void addMachineIDs(string machineID);
        void setMachineIndex(int index);
        void setUrgencyLabel(int value);
        void showRegisterMachineForm(int companyID);
    }
}
