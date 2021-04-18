using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDiary2.Data_Access_Layer;
using PhotoDiary2.Data_Access_Layer.Entities;

namespace PhotoDiary2.Business_Logic_Layer
{
    class StoryService
    {
        StoryDataAccess storyDataAccess;

        public StoryService()
        {
            this.storyDataAccess = new StoryDataAccess();
        }

        public List<Story> GetAllStories()
        {
            return this.storyDataAccess.GetStories();
        }
        public Story GetStory(int serial)
        {
            return this.storyDataAccess.GetStory(serial);
        }

        public int UpdateExistingStory(int storySerial, string storyTitle, string date, string storyText, string pciture, int priority )
        {
            Story story = new Story() { StorySerial = storySerial ,StoryTitle = storyTitle, Date = date, StoryText = storyText, Picture = pciture, Priority = priority};
            return this.storyDataAccess.UpdateStory(story);
        }
        public List<Story> GetStory(string usersname)
        {
            return this.storyDataAccess.GetStoriesbyUsersname(usersname);
        }

        public List<Story> GetSList(string usersname)
        {
            return this.storyDataAccess.GetlistbyUsersname(usersname);
        }
        public int RemoveStory(int storySerial)
        {
            return this.storyDataAccess.RemoveStory(storySerial);

        }

        public int AddNewStory(string storyTitle,string date, string storyText, string picture, int priority, string usersname)
        {

            UsersDataAccess usersDataAccess = new UsersDataAccess();
            //int userID = usersDataAccess.GetUserId(storyTitle);
            this.storyDataAccess = new StoryDataAccess();
            Story story = new Story()
            {
                StoryTitle = storyTitle,
                Date = date,
                StoryText = storyText,
                Picture = picture,
                Priority = priority,
                Usersname = usersname

            };
           
            return this.storyDataAccess.AddStory(story);
        }


    }
}
