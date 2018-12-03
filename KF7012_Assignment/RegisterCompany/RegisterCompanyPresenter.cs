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

        public RegisterCompanyPresenter(IRegisterCompanyGUI screen)
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

        public void message(String msg)
        {
            screen.message(msg);
        }
    }
}
