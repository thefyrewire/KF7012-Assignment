using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class RegisterCompanyPresenter
    {
        private IRegisterCompanyGUI screen;
        // private IModelRepository repository;
        ModelRepository repository = new ModelRepository();

        public RegisterCompanyPresenter(IRegisterCompanyGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.hideError();
            // updateView();
        }

        /*public void updateView()
        {
        }*/

        public void message(string msg)
        {
            screen.message(msg);
        }

        public void btn_RegisterCompany_Click()
        {
            screen.hideError();

            if (screen.validateFields())
            {
                Company company = repository.getCompanyByName(screen.getCompanyName());
                if (company != null)
                    screen.message(company.name + " already exists.\n\nID: " + company.companyID);
                else
                {
                    int newCompanyID = repository.generateCompanyID();
                    repository.addCompany(newCompanyID, screen.getCompanyName(), screen.getLocation());
                    screen.message("New company registered: " + screen.getCompanyName() + "\n\nID: " + newCompanyID.ToString());

                    screen.showJobsForm(newCompanyID);
                }
            }
            else screen.showError("All fields must be filled.");
        }


    }
}
