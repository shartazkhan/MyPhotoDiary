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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            LoginService loginService = new LoginService();
            int result = loginService.LoginValidation(textBoxUsername.Text, textBoxPassword.Text);
            if (result == -1)
            {
                MessageBox.Show("Invalid username or password");
            }
            else
            {
                Dashboard dashboard = new Dashboard(this);

               
                textBoxPassword.Text = String.Empty;
                this.Hide();
                dashboard.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

        private void tiles1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            if (textBoxNewUsername.Text == "")
            {
                MessageBox.Show("Invalid username");
            }
            else if (textBoxName.Text == "")
            {
                MessageBox.Show("Invalid Name");
            }
            else if (textBoxNewPass.Text != textBoxNewConfirmPass.Text)
            {
                MessageBox.Show("password Didn't match!");
            }
            else
            {
                int result = userService.AddNewUser(textBoxNewUsername.Text, textBoxName.Text, textBoxNewPass.Text, 0);

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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
