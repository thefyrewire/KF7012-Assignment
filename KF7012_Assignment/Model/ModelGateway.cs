using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KF7012_Assignment
{
    public class ModelGateway
    {
        /* --- GLOBAL --- */
        public void deleteDatabase()
        {
            using (var context = new Model()) { context.Database.Delete(); }
        }


        /* --- USERS --- */
        public void addUser(int userID, string username, string password, string profile)
        {
            using (var context = new Model())
            {
                context.Users.Add(new User()
                {
                    userID = userID,
                    username = username,
                    password = password,
                    profile = profile
                });

                context.SaveChanges();
            }
        }

        public List<User> getUsers()
        {
            using (var context = new Model())
            {
                var users = context.Users.ToList<User>();
                return users;
            }
        }
    }
}
