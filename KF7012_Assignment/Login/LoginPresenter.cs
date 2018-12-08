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
            screen.hideError();
            // updateView();

            // DB TEST
            /*using (var context = new Model())
            {
                context.Database.Delete();

                context.Users.Add(new User()
                {
                    userID = 00000,
                    username = "admin",
                    password = "admin"
                });

                context.SaveChanges();
            }*/
        }

        /*public void updateView()
        {
        }*/

        public void btn_Login_Click()
        {
            // DB TEST
            /*using (var context = new Model())
            {
                var userList = context.Users.ToList<User>();
                if (userList.Count<User>() > 0)
                    foreach (User user in userList)
                    {
                        Console.WriteLine(user.username);
                    }
            }*/

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
