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
        ModelRepository repository = new ModelRepository();

        public LoginPresenter(ILoginGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.hideError();

            // DB TEST
            repository.resetDatabase();
        }

        public void btn_Login_Click()
        {
            if (!string.IsNullOrEmpty(screen.getAttemptUsername()) && !string.IsNullOrEmpty(screen.getAttemptPassword()))
            {
                string profile = repository.verifyUser(screen.getAttemptUsername(), screen.getAttemptPassword());

                if (profile != null)
                {
                    switch (profile)
                    {
                        case "techmngr":
                            screen.showTechMngrMenu();
                            break;
                        case "user":
                            screen.showUserMenu();
                            break;
                    }
                }
                else screen.showError("Incorrect username or password.");
            }
            else
            { 
                screen.showError("Enter username and password.");
            } 
        }
    }
}
