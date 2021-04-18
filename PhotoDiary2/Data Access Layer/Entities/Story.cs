using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDiary2.Data_Access_Layer.Entities
{
    class Story
    {
        public int StorySerial { get; set; }
        public string StoryTitle { get; set; }
        public string Date { get; set; }
        public string StoryText { get; set; }
        public string Picture { get; set; }
        public int Priority { get; set; }
        public string Usersname { get; set; }

        
    }
}
