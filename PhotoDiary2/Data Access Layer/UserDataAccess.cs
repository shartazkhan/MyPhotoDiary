using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDiary2.Data_Access_Layer.Entities;

namespace PhotoDiary2.Data_Access_Layer
{
    class UsersDataAccess : DataAccess
    {
        public List<User> GetUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
               
                user.Username = reader["Username"].ToString();
                
                user.Name = reader["Name"].ToString();
                user.Password = reader["Password"].ToString();
                user.StoryCount = Convert.ToInt32(reader["StoryCount"]);
                users.Add(user);
            }
            return users;
        }
        public User GetUsers(string username)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                User user = new User();
                user.Username = reader["Username"].ToString();
                user.Name = reader["Name"].ToString();
                user.Password = reader["Password"].ToString();
                user.StoryCount = Convert.ToInt32(reader["StoryCount"]);
                return user;
            }
            return null;
        }

       

        public int AddUser(User user)
        {
            string sql = "INSERT INTO Users(UserName,Name,Password,StoryCount) VALUES('" + user.Username + "','" + user.Name + "','" + user.Password + "', "+ user.StoryCount+")";
            return this.ExecuteQuery(sql);
        }

        public int UpdateUser(User user)
        {
            string sql = "UPDATE Users SET Name='" + user.Name + "' WHERE Username='" + user.Name + "'";
            return this.ExecuteQuery(sql);
        }
        public int DeleteUser(string username)
        {
            string sql = "DELETE FROM Users WHERE Username='" + username + "'";
            return this.ExecuteQuery(sql);
        }

        public int GetUsername(string username)
        {
            string sql = "SELECT Username FROM Users WHERE Username='" + username + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["Id"]);
            }
            return -1;
        }
        public List<string> GetUsernames()
        {
            string sql = "SELECT Username FROM Users";
            SqlDataReader reader = this.GetData(sql);
            List<string> usernames = new List<string>();
            while (reader.Read())
            {
                usernames.Add(reader["Usernames"].ToString());
            }
            return usernames;
        }
    }
}
