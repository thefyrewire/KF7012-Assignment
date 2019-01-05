using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public interface ILoginGUI
    {
        void register(LoginPresenter FM);
        string getAttemptUsername();
        string getAttemptPassword();
        void showUserMenu();
        void showTechMngrMenu();
        void hideError();
        void showError(string error);
    }
}
