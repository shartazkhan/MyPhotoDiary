using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoDiary2.Business_Logic_Layer;

namespace PhotoDiary2.Presentation_Layer
{
   
    public partial class AddStory : UserControl
    {
        

        public AddStory()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddStory_Load(object sender, EventArgs e)
        {
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            

            UserService userService = new UserService();
           // int userId = userService.GetUserId(login.textBoxUsername.Text);

            StoryService storyService = new StoryService();
            int priority;
            if (radioButtonHigh.Checked == true)
            {
                priority = 1;
            }
            else if (radioButtonModerate.Checked == true)
            {
                priority = 2;
            }
            else
            {
                priority = 3;
            }
            int result = storyService.AddNewStory( textBoxTitle.Text, guna2DateTimePicker1.Text, textBoxStory.Text,
                textBoxPath.Text, priority, "textBoxUsername");

            if (result > 0)
            {
                MessageBox.Show("New product added successfully !!");
                
            }
            else
            {
                MessageBox.Show("Error in adding.");
            }

        }

    }
}
