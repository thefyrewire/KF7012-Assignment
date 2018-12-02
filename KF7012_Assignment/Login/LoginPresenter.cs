using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class LoginPresenter
    {
        private ILoginGUI screen;

        public LoginPresenter(ILoginGUI screen)
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

        public void btn_Login_Click()
        {
            if (!String.IsNullOrEmpty(screen.getAttemptUsername()) && !String.IsNullOrEmpty(screen.getAttemptPassword()))
            {
                if (screen.getAttemptUsername() == "admin" && screen.getAttemptPassword() == "admin")
                {
                    screen.showMainForm();
                }
                else Console.WriteLine("Wrong password, dummy!");
            }
            else Console.WriteLine("Fill in a field, dummy!");
        }
    }
}
