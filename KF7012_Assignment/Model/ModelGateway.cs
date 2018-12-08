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

        public void resetDatabase()
        {
            this.deleteDatabase();

            // ADD USERS
            this.addUser(0000, "admin", "admin", "admin");
            this.addUser(1701, "w1701", "pass", "user");
            this.addUser(1702, "w1702", "pass", "user");
            this.addUser(1703, "w1703", "pass", "user");
            this.addUser(1704, "w1704", "pass", "user");
        }

        /* ------------- */
        /* --- USERS --- */
        /* ------------- */

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

        public bool verifyUser(string username, string password)
        {
            using (var context = new Model())
            {
                List<User> users = this.getUsers();
                User userToVerify = users.Where(user => user.username == username && user.password == password).FirstOrDefault<User>();
                if (userToVerify != null)
                    return true;

                return false;
            }
        }
    }
}
