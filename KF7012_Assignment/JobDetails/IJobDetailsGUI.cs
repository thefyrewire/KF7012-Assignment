using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface IJobDetailsGUI
    {
        void register(JobDetailsPresenter FM);
        void setReadOnlyFields();
        int jobID { get; set; }
        int companyID { get; set; }
        string companyName { get; set; }
        string location { get; set; }
        string machineID { get; set; }
        string assetTag { get; set; }
        int sizeComplexity { get; set; }
        string fault { get; set; }
        string description { get; set; }
        int urgency { get; set; }
        void setDateReported(DateTime date);
        void setLastStartDate(DateTime date);
    }
}
