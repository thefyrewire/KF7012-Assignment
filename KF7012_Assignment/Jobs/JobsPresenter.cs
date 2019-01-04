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
            screen.showFaultError(false);
            updateView();
        }

        public void updateView()
        {
            getCompanyDetails();
            screen.clearMachineDetails();
            populateMachines();
            checkEnableAddMachine();
            checkEnableRegisterJob();
        }

        public void btn_RegisterMachine_Click() {
            screen.showRegisterMachineForm(screen.companyID);
        }

        public void setCompanyID(int companyID)
        {
            screen.companyID = companyID;
        }

        public void txt_CompanyID_Leave()
        {
            updateView();
        }

        private void getCompanyDetails()
        {
            Company company = repository.getCompanyByID(screen.companyID);
            if (company != null)
            {
                screen.companyName = company.name;
                screen.location = company.location;
            }
            else screen.clearCompanyDetails();
        }

        private void populateMachines()
        {
            screen.clearMachineIDs();

            List<Machine> machines = repository.getMachinesForCompany(screen.companyID);
            if (machines.Count > 0)
            {
                foreach (Machine machine in machines)
                {
                    screen.addMachineIDs(machine.machineID);
                }
                screen.setMachineIndex(0);
                screen.cmb_MachineIDEnabled(true);
            }
            else screen.cmb_MachineIDEnabled(false);
        }

        private void checkEnableAddMachine()
        {
            Company company = repository.getCompanyByID(screen.companyID);
            if (company != null)
                screen.btn_RegisterMachineEnabled(true);
            else
                screen.btn_RegisterMachineEnabled(false);
        }

        private void checkEnableRegisterJob()
        {
            if (!string.IsNullOrEmpty(screen.machineID))
            {
                screen.btn_RegisterJobEnabled(true);
                screen.jobDetailsEnabled(true);
            }
            else
            {
                screen.btn_RegisterJobEnabled(false);
                screen.jobDetailsEnabled(false);
            }
                
        }

        public void cmb_MachineID_Leave()
        {
            if (!string.IsNullOrEmpty(screen.machineID))
            {
                Machine machine = repository.getMachine(screen.machineID);
                if (machine != null)
                {
                    screen.assetTag = machine.assetTag;
                    screen.sizeComplexity = machine.sizeComplexity;
                    screen.btn_RegisterJobEnabled(true);
                } else
                    screen.btn_RegisterJobEnabled(false);
            }
        }

        public void trb_Urgency_ValueChanged()
        {
            screen.setUrgencyLabel(screen.urgency);
        }

        public void btn_RegisterJob_Click()
        {
            validateJob();
        }

        private void validateJob()
        {
            if (string.IsNullOrEmpty(screen.fault.Trim()))
                screen.showFaultError(true);
            else
                screen.showFaultError(false);


        }
    }
}
