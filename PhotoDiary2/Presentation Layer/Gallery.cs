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
    public partial class Gallery : Form
    {
        private Dashboard dashboard;
        private string imageFileName;
        public Gallery(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            StoryService storyService = new StoryService();
            dataGridView1.DataSource = storyService.GetSList(dashboard.loggedUser);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }
        private void Gallery_Load(object sender, EventArgs e)
        {
            labelTitle.Visible = false;
            textBoxStory.Visible = false;
            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\Dummy.jpg");

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            labelTitle.Visible = true;
            textBoxStory.Visible = true;
            labelDate.Visible = true;
            labelTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            labelDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxStory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            // guna2DateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            // textBoxPath.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            imageFileName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\shart\source\repos\PhotoDiary2\PhotoDiary2\Image\" + imageFileName);

            /* if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == 1)
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
             }*/

            //textBoxStory.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //textBoxStory.Text = categoryListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard.Show();
        }

        private void Gallery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
