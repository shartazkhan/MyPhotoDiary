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
    public partial class StoryDelete : Form
    {
        private Dashboard dashboard;
        private string imageFileName;
        public StoryDelete(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetSList(dashboard.loggedUser);
        }

        private void StoryDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void UpdateList()
        {
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetStory(dashboard.loggedUser);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this story?",
                "Mood Test", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                StoryService storyService = new StoryService();
                int result = storyService.RemoveStory(Convert.ToInt32(labelSerial.Text));
                
                if (result > 0)
                {
                    MessageBox.Show("Category deleted successfully !!");
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Error in deleting.");
                }

                if (imageFileName != "Dummy.jpg")
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Dummy.jpg");
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\" + imageFileName);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
              
            }

            

            
            textBoxStory.Text = String.Empty;
            textBoxTitle.Text = String.Empty;
            labelDate.Text = "Date";
            labelSerial.Text = String.Empty;
            labelPriority.Text = String.Empty;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSerial.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxStory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            labelDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            // textBoxPath.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            imageFileName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\" + imageFileName);

            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 1)
            {
                labelPriority.Text = " Low";
            }
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 2)
            {
                labelPriority.Text = " High";
            }
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 3)
            {
                labelPriority.Text = " High";
            }
        }

        private void StoryDelete_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Dummy.jpg");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard.Show();

        }
    }
}
