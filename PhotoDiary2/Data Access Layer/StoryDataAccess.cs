using PhotoDiary2.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary2.Data_Access_Layer
{
    class StoryDataAccess : DataAccess
    {
        public List<Story> GetStories()
        {
            string sql = "SELECT * FROM Stories";
            SqlDataReader reader = this.GetData(sql);
            List<Story> stories = new List<Story>();

            while (reader.Read())
            {
                Story story = new Story();
                story.StorySerial = Convert.ToInt32(reader["StorySerial"]);
                story.StoryTitle = reader["StoryTitle"].ToString();
                story.Date = reader["Date"].ToString();
                story.StoryText = reader["StoryText"].ToString();
                story.Picture = reader["Picture"].ToString();
                story.Priority = Convert.ToInt32(reader["Priority"]);
                story.Usersname = reader["Usersname"].ToString();
                stories.Add(story);
            }
            return stories;
        }

        public List<Story> GetStoriesbyUsersname(string usersname)
        {
            string sql = "SELECT * FROM Stories WHERE Usersname='" + usersname +"'";
            SqlDataReader reader = this.GetData(sql);
            List<Story> stories = new List<Story>();

            while (reader.Read())
            {
                Story story = new Story();
                story.StorySerial = Convert.ToInt32(reader["StorySerial"]);
                story.StoryTitle = reader["StoryTitle"].ToString();
                story.Date = reader["Date"].ToString();
                story.StoryText = reader["StoryText"].ToString();
                story.Picture = reader["Picture"].ToString();
                story.Priority = Convert.ToInt32(reader["Priority"]);
                story.Usersname = reader["Usersname"].ToString();
                stories.Add(story);
                
            }
            return stories;
        }

        public List<Story> GetlistbyUsersname(string usersname)
        {
            string sql = "SELECT * FROM Stories WHERE Usersname='" + usersname + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Story> stories = new List<Story>();

            while (reader.Read())
            {
                Story story = new Story();
                story.StorySerial = Convert.ToInt32(reader["StorySerial"]);
                story.StoryTitle = reader["StoryTitle"].ToString();
                story.Date = reader["Date"].ToString();
                story.StoryText = reader["StoryText"].ToString();
                story.Picture = reader["Picture"].ToString();
                story.Priority = Convert.ToInt32(reader["Priority"]);
                story.Usersname = reader["Usersname"].ToString();
                stories.Add(story);

            }
            return stories;
        }

        public Story GetStory(int serial)
        {
            string sql = "SELECT * FROM Stories WHERE StorySerial=" + serial;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Story story = new Story();
                story.StorySerial = Convert.ToInt32(reader["StorySerial"]);
                story.StoryTitle = reader["StoryTitle"].ToString();
                story.Date = reader["Date"].ToString();
                story.StoryText = reader["StoryText"].ToString();
                story.Picture = reader["Picture"].ToString();
                story.Priority = Convert.ToInt32(reader["Priority"]);
                story.Usersname = reader["Usersname"].ToString();
                return story;
            }
            return null;
        }



        public int AddStory(Story story)
        {
            string sql = "INSERT INTO Stories(StoryTitle,Date,StoryText,Picture,Priority,Usersname) VALUES('" +
                         story.StoryTitle + "','" + story.Date + "','" + story.StoryText + "','" + story.Picture +
                         "'," + story.Priority + ",'" + story.Usersname + "')";
            return this.ExecuteQuery(sql);
        }

        public int UpdateStory(Story story)
        {
            string sql = "UPDATE Stories SET StoryTitle='" + story.StoryTitle + "',Date='" + story.Date + "',StoryText='" + story.StoryText + "',Picture='" + story.Picture + "',Priority=" + story.Priority +" WHERE StorySerial=" + story.StorySerial;
            return this.ExecuteQuery(sql);
        }

        public int RemoveStory(int storySerial)
        {
            string sql = "Delete FROM Stories WHERE StorySerial=" + storySerial;
            return this.ExecuteQuery(sql);
        }


    }
}
