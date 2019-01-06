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
    public interface IFormGUI
    {
        void register(FormPresenter FM);
        void showRegisterCompanyForm();
        void showRegisterJobForm();
        void showJobsForm();
    }
}
