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

        ModelGateway model = new ModelGateway(); 

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
                Company company = model.getCompanyByName(screen.getCompanyName());
                if (company != null)
                    screen.message(company.name + " already exists.\n\nID: " + company.companyID);
                else
                {
                    int newCompanyID = model.generateCompanyID();
                    model.addCompany(newCompanyID, screen.getCompanyName(), screen.getLocation());
                    screen.message("New company registered: " + screen.getCompanyName() + "\n\nID: " + newCompanyID.ToString());
                }
            }
            else screen.showError("All fields must be filled.");
            

        }
    }
}
