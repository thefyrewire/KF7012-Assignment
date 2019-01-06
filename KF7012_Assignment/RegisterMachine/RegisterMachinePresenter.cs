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
            screen.showError(false);
        }

        public void setCompanyID(int companyID)
        {
            screen.companyID = companyID;
        }

        public void trb_SizeComplexity_ValueChanged()
        {
            screen.setSizeComplexityLabel(screen.getSizeComplexity());
        }

        public void btn_Register_Click()
        {
            if (!string.IsNullOrEmpty(screen.getAssetTag()) && !string.IsNullOrEmpty(screen.getDescription()))
            {
                screen.showError(false);
                repository.addMachine(repository.generateMachineID(), screen.companyID, screen.getAssetTag(), screen.getSizeComplexity(), screen.getDescription());
                screen.closeForm();
            }
            else screen.showError(true);
            
        }
    }
}
