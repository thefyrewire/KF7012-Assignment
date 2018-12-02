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

        public JobsPresenter(IJobsGUI screen)
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

        public void btn_RegisterMachine_Click() {
            screen.showRegisterMachineForm();
        }
    }
}
