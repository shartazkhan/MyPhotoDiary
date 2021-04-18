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
using PhotoDiary2.Data_Access_Layer;

namespace PhotoDiary2.Presentation_Layer
{
    
    public partial class StoryUpdate : Form
    {
        private Dashboard dashboard;
        string imageFileName;
        string updatefileName;
        public StoryUpdate(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetSList(dashboard.loggedUser);
        }

        private void StoryUpdate_Load(object sender, EventArgs e)
        {
           
            //StoryService storyService = new StoryService();

          //  textBoxStory.Text = storyService.ToStr
            //textBoxTitle.Text 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSerial.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxStory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           // guna2DateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           //textBoxPath.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            imageFileName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\"+imageFileName);
           
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 1)
            {
                radioButtonLow.Checked = true;
            }
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 2)
            {
                radioButtonModerate.Checked = true;
            }
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 3)
            {
                radioButtonHigh.Checked = true;
            }

            //textBoxStory.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textBoxStory.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        void UpdateList()
        {
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetStory(dashboard.loggedUser);
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text))
            {
               
            }
            else
            {
                string ln = Path.Combine(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image",
                    Path.GetFileName(textBoxPath.Text));

                File.Copy(textBoxPath.Text, ln, true);
            }

            int priority;
            if (radioButtonLow.Checked == true)
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

            StoryService storyService = new StoryService();
            int result = storyService.UpdateExistingStory(Convert.ToInt32(labelSerial.Text), textBoxTitle.Text, DateTime.Now.ToString("dd/MM/yyyy"),
                textBoxStory.Text, updatefileName, priority);

            if (result > 0)
            {
                MessageBox.Show("Story updated successfully !!");
                UpdateList();
            }
            else
            {
                MessageBox.Show("Error in updating.");
            }

            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Dummy.jpg");
            textBoxStory.Text = String.Empty;
            textBoxTitle.Text = String.Empty;
            textBoxPath.Text = String.Empty;
            //labelDate.Text = "Date";
            labelSerial.Text = String.Empty;
            radioButtonLow.Checked = false;
            radioButtonModerate.Checked = false;
            radioButtonHigh.Checked = false;
        }

        private void labelSerial_Click(object sender, EventArgs e)
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
                this.updatefileName = open.SafeFileName;
            }
        }

        private void StoryUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit( );
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            dashboard.Show();

        }
    }
}
