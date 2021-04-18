using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoDiary2.Business_Logic_Layer;

namespace PhotoDiary2.Presentation_Layer
{
    public partial class Dashboard : Form
    {
        private string abc;
        Login login;
        public string loggedUser;
        public Dashboard(Login login)
        {
            InitializeComponent();
            this.login = login;
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetSList(login.textBoxUsername.Text);
            this.loggedUser = login.textBoxUsername.Text;
           // PopulateItem();
           // addStory1.Visible = false;
           // updateStory1.Visible = false;
            labelUsername.Text += login.textBoxUsername.Text;
            UpdateList();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Dummy.jpg");
            guna2CirclePictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Avatar.png");
          
        }
        


        /* private void PopulateItem()
         {
             Tiles[] tiles = new Tiles[20];

             StoryService storyService = new StoryService();
             for (int i = 0; i < tiles.Length; i++)
             {
                 tiles[i] = storyService.GetTile(login.textBoxUsername.Text);

                 if (flowLayoutPanel1.Controls.Count < 0)
                 {
                     flowLayoutPanel1.Controls.Clear();
                 }
                 else
                 {
                     flowLayoutPanel1.Controls.Add(tiles[i]);
                 }

             }
         }*/

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           // addStory1.Visible = true;
          //  updateStory1.Visible = false;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            StoryUpdate storyUpdate = new StoryUpdate(this);
            this.Hide();
            storyUpdate.Show();

            // updateStory1.BringToFront();
            //  addStory1.Visible = false;
            //  updateStory1.Visible = true;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
           // addStory1.Visible = false;
          //  updateStory1.Visible = false;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
               // this.abc = System.IO.Path.GetFileNameWithoutExtension(open.FileName);
                this.abc = open.SafeFileName;
            }
        }

        void UpdateList()
        {
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetStory(login.textBoxUsername.Text);
        }

        private void buttonPost_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                MessageBox.Show("Please enter a title!");
            }
            else if (string.IsNullOrEmpty(textBoxStory.Text))
            {
                MessageBox.Show("Please enter a story!");
            }
            else if(string.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Please chose a image!");
            }
            else if(radioButtonHigh.Checked == false && radioButtonModerate.Checked == false && radioButtonLow.Checked == false)
            {
                MessageBox.Show("Please chose a priority!");
            }

            else
            {
                string pathOfFolder = @"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image";
                string pathOfFolder2 = pathOfFolder + loggedUser + "_";

                string ln = Path.Combine(pathOfFolder,
                    Path.GetFileName(textBoxPath.Text));

                File.Copy(textBoxPath.Text, ln, true);

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
                int result = storyService.AddNewStory(textBoxTitle.Text, DateTime.Now.ToString("dd/MM/yyyy"), textBoxStory.Text,
                    abc, priority, login.textBoxUsername.Text);

                if (result > 0)
                {
                    MessageBox.Show("New product added successfully !!");
                    UpdateList();

                    pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Dummy.jpg");
                    textBoxStory.Text = String.Empty;
                    textBoxTitle.Text = String.Empty;
                    textBoxPath.Text = String.Empty;
                    //labelDate.Text = "Date";

                    radioButtonLow.Checked = false;
                    radioButtonModerate.Checked = false;
                    radioButtonHigh.Checked = false;
                }
                else
                {
                    MessageBox.Show("Error in adding.");
                }
            }

           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            login.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowSotry_Click(object sender, EventArgs e)
        {
            Gallery gallery = new Gallery(this);
            this.Hide();
            gallery.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            StoryDelete storyDelete = new StoryDelete(this);
            this.Hide();
            storyDelete.Show();
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
