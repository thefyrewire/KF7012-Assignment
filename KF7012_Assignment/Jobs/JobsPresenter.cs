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

        public void setCompanyID(int companyID)
        {
            screen.companyID = companyID.ToString();
        }

        public void txt_CompanyID_Leave()
        {
            autofillNameLocation();
            populateMachines();
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

        public void populateMachines()
        {
            int companyID;
            int.TryParse(screen.companyID, out companyID);
            List<Machine> machines = model.getMachinesForCompany(companyID);
            if (machines.Count > 0)
            {
                foreach (Machine machine in machines)
                {
                    screen.addMachine(machine.machineID, machine.assetTag);
                }
                screen.setMachineIndex(0);
            }
        }

        public void cmb_MachineID_SelectedIndexChanged()
        {
            string[] parsed = screen.getMachineID().Split( new Char[] {' ', '-', ' '} );
            Machine machine = model.getMachine(parsed[0]);
            if (machine != null)
                screen.setSizeComplexity(machine.sizeComplexity);
        }
    }
}
