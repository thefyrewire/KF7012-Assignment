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

        ModelGateway model = new ModelGateway(); 

        public LoginPresenter(ILoginGUI screen)
        {
            this.screen = screen;
            screen.register(this);
            initialiseForm();
        }

        private void initialiseForm()
        {
            screen.hideError();
            // updateView();

            // DB TEST
            model.deleteDatabase();
            model.addUser(0000, "w170", "pass", "user");
            model.addUser(0001, "w171", "pass", "user");
            model.addUser(0002, "w172", "pass", "user");
            model.addUser(0003, "w173", "pass", "user");
        }

        /*public void updateView()
        {
        }*/

        public void btn_Login_Click()
        {
            // DB TEST
            //List<User> users = model.getUsers();
            foreach (User user in model.getUsers())
            {
                Console.WriteLine(user.username);
            }

            if (!String.IsNullOrEmpty(screen.getAttemptUsername()) && !String.IsNullOrEmpty(screen.getAttemptPassword()))
            {
                if (screen.getAttemptUsername() == "admin" && screen.getAttemptPassword() == "admin")
                {
                    screen.showMainForm();
                }
                else
                {
                    Console.WriteLine("Wrong password, dummy!");
                    screen.showError("Incorrect username or password.");
                }

            }
            else
            { 
                Console.WriteLine("Fill in a field, dummy!");
                screen.showError("Enter username and password.");
            } 
        }
    }
}
