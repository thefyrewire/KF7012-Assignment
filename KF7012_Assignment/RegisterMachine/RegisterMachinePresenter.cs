using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class RegisterMachinePresenter
    {
        private IRegisterMachineGUI screen;
        ModelRepository repository = new ModelRepository();

        public RegisterMachinePresenter(IRegisterMachineGUI screen)
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

        public void setCompanyID(int companyID)
        {
            screen.companyID = companyID;
        }

        public void trb_SizeComplexity_ValueChanged()
        {
            screen.setSizeComplexityLabel(screen.sizeComplexity);
        }

        public void btn_Register_Click()
        {
            repository.addMachine(repository.generateMachineID(), screen.companyID, screen.assetTag, screen.sizeComplexity);
            screen.closeForm();
        }
    }
}
