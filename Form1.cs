using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            // Handle HomeButton click event
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       private void signin_Click(object sender, EventArgs e)
        {
            SigninForm signinForm = new SigninForm();
            signinForm.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.Show();
        }
    }
}

