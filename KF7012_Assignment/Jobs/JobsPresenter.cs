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
        // private IModelRepository repository;
        ModelRepository repository = new ModelRepository();

        public JobsPresenter(IJobsGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.setReadOnlyFields();            
            updateView();
        }

        public void updateView()
        {
            autofillNameLocation();
            screen.clearSizeComplexity();
            populateMachines();
            checkEnableAddMachine();
        }

        public void btn_RegisterMachine_Click() {
            int companyID;
            bool parsed = int.TryParse(screen.companyID, out companyID);
            screen.showRegisterMachineForm(companyID);
        }

        public void setCompanyID(int companyID)
        {
            screen.companyID = companyID.ToString();
        }

        public void txt_CompanyID_Leave()
        {
            updateView();
        }

        private void autofillNameLocation()
        {
            int companyID;
            int.TryParse(screen.companyID, out companyID);
            Company company = repository.getCompanyByID(companyID);
            if (company != null)
            {
                screen.setCompanyName(company.name);
                screen.setLocation(company.location);
            }
            else screen.clearCompanyNameLocation();
        }

        private void populateMachines()
        {
            screen.clearMachineIDs();

            int companyID;
            int.TryParse(screen.companyID, out companyID);
            List<Machine> machines = repository.getMachinesForCompany(companyID);
            if (machines.Count > 0)
            {
                foreach (Machine machine in machines)
                {
                    screen.addMachine(machine.machineID);
                }
                screen.setMachineIndex(0);
            }
        }

        private void checkEnableAddMachine()
        {
            int companyID;
            int.TryParse(screen.companyID, out companyID);
            Company company = repository.getCompanyByID(companyID);
            if (company != null)
                screen.registerMachineEnabled(true);
            else
                screen.registerMachineEnabled(false);
        }

        public void cmb_MachineID_Leave()
        {
            Machine machine = repository.getMachine(screen.getMachineID());
            if (machine != null)
                screen.assetTag = machine.assetTag;
                screen.setSizeComplexity(machine.sizeComplexity);
        }

        public void btn_RegisterJob_Click()
        {
            
        }
    }
}
