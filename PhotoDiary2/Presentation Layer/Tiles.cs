using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiary2.Presentation_Layer
{
    public partial class Tiles : UserControl
    {
        public Tiles()
        {
            InitializeComponent();
        }

        #region MyRegion
        private string  _title;
        private string _texts;
        private string _username;
        private string _dates;
        private Image _icon;

        [Category("Coustom Props")]
        public string Title
        {
            get { return _title;}
            set { _title = value;
                labelTitle.Text = value;
            }
        }
        [Category("Coustom Props")]
        public string Dates
        {
            get { return _dates; }
            set
            {
                _dates = value;
                labelDate.Text = value;
            }
        }
        [Category("Coustom Props")]
        public string Texts
        {
            get { return _texts; }
            set { _texts = value;
                labelTexts.Text = value;
            }
        }
        [Category("Coustom Props")]
        public string Usernamne
        {
            get { return _username; }
            set { _username = value;
                labelUsername.Text = value;
            }
        }
        [Category("Coustom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value;
                guna2PictureBox1.Image = value;
            }
        }




        #endregion

        private void Tiles_Load(object sender, EventArgs e)
        {

        }
    }
}
