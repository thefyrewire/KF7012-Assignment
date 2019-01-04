using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class FormPresenter
    {
        private IFormGUI screen;

        public FormPresenter(IFormGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            // updateView();
        }

        /*public void updateView()
        {
        }*/

        public void showRegisterCompanyForm()
        {
            screen.showRegisterCompanyForm();
        }

        public void showRegisterJobForm()
        {
            screen.showRegisterJobForm();
        }

        public void showJobsForm()
        {
            screen.showJobsForm();
        }

    }
}
