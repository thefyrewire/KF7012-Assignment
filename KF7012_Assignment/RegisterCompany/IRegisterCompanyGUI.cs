using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface IRegisterCompanyGUI
    {
        void register(RegisterCompanyPresenter FM);
        void message(string msg);
        bool validateFields();
        string getCompanyName();
        string getLocation();
        void hideError();
        void showError(string error);
        void showJobsForm(int companyID);
    }
}
