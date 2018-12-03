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
        String getAttemptUsername();
        String getAttemptPassword();
        void showMainForm();
        void hideError();
        void showError(String error);
    }
}
