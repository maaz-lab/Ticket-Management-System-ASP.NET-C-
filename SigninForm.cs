using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen
{
    public partial class SigninForm : Form
    {
        string UserNameToPass = "";
        public SigninForm()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void SigninForm_Load(object sender, EventArgs e)
        {

        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if (user.Text == "" && pass.Text == "")
            {
                MessageBox.Show("Enter a Valid Username and Password");
            }
            else if (user.Text == "")
            {
                MessageBox.Show("Enter a Valid Username");   
            }
            else if(pass.Text == "")
            {
                MessageBox.Show("Enter a Valid Password");
            }
            else
            {
<<<<<<< HEAD
                string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"; // Replace with your actual connection string
                string username = user.Text;
=======
                string connectionString = "Data Source=(localdb)\\bookmedatabase;Initial Catalog=BOOKMEDATABASE;Integrated Security=True"; // Replace with your actual connection string
                UserNameToPass = user.Text;
>>>>>>> 17636025b17271e9db42e71c2246c4bc38c86f7b
                string password = pass.Text;
                
                
                using ( TrainCompartments tc = new TrainCompartments())
                {
                    tc.username = UserNameToPass;
                }
                string username = UserNameToPass;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())

                    {
                        command.CommandText = "SELECT COUNT(*) FROM UserInformation WHERE username = @username AND user_pass = @password";
                        command.Parameters.AddWithValue("@username",username);
                        command.Parameters.AddWithValue("@password", password);
                        
                        int result = (int)command.ExecuteScalar();
                        if (result > 0)
                        {
                            mainpage m1 = new mainpage();
<<<<<<< HEAD
                            
                            
                            m1.Show();
                            m1.Settextfromlabel(username);
                           
=======
                            m1.Show();
                            m1.Settextfromlabel(username);
>>>>>>> 17636025b17271e9db42e71c2246c4bc38c86f7b
                            this.Hide();

                        }
                        else if (pass.Text != "@password" || user.Text == "@username")
                        {
                            MessageBox.Show("Invalid password");
                            pass.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                            pass.Clear();
                            user.Clear();
                            // Handle invalid credentials
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
