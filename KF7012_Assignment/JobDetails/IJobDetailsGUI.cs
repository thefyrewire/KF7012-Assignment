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
        int companyID { get; set; }
    }
}
