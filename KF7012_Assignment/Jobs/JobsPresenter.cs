using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class JobsPresenter
    {
        private IJobsGUI screen;

        ModelGateway model = new ModelGateway();

        public JobsPresenter(IJobsGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.setReadOnlyFields();
            // updateView();
        }

        /*public void updateView()
        {
        }*/

        public void btn_RegisterMachine_Click() {
            screen.showRegisterMachineForm();
        }

        public void txt_CompanyID_Leave()
        {
            autofillNameLocation();
        }

        public void autofillNameLocation()
        {
            int companyID;
            int.TryParse(screen.companyID, out companyID);
            Company company = model.getCompanyByID(companyID);
            if (company != null)
            {
                screen.setCompanyName(company.name);
                screen.setLocation(company.location);
            }
            else screen.clearCompanyNameLocation();
        }

        public void setCompanyID(int companyID)
        {
            screen.companyID = companyID.ToString();
        }
    }
}
