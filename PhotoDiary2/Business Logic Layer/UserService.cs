using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDiary2.Data_Access_Layer;
using PhotoDiary2.Data_Access_Layer.Entities;

namespace PhotoDiary2.Business_Logic_Layer
{
    class UserService
    {
        UsersDataAccess usersDataAccess;
        public UserService()
        {
            this.usersDataAccess = new UsersDataAccess();
        }

        public List<User> GetAllUser()
        {

            return this.usersDataAccess.GetUsers();
        }
        public User GetUser(string username)
        {
            return this.usersDataAccess.GetUsers(username);
        }

        /*public int GetUserId(string username)
        {
            return this.usersDataAccess.GetUserIds(username);
        }*/

        public User GetList(string username)
        {
            return this.usersDataAccess.GetUsers(username);
        }

        public int AddNewUser(string username, string name, string password, int storyCount)
        {
            User user = new User() { Username = username, Name = name, Password = password, StoryCount = storyCount };
            return this.usersDataAccess.AddUser(user);
        }
        public int UpdateExistingUser(string name, string password)
        {
            User user = new User() {Name = name, Password =  password};
            return this.usersDataAccess.UpdateUser(user);
        }
        public int DeleteUser(string username)
        {
            return this.usersDataAccess.DeleteUser(username);
        }
        public List<string> GetUserNames()
        {
            return this.usersDataAccess.GetUsernames();
        }
    }
}
