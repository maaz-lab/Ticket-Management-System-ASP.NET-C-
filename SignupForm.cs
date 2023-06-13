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
    public partial class SignupForm : Form
    {
        public SignupForm()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SigninForm signinForm = new SigninForm();
            signinForm.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                // Get the input values from the TextBoxes
                string username = textBox2.Text;
                string firstName = textBox1.Text;
                string password = textBox3.Text;
                string email = textBox4.Text;
                string cnic = textBox5.Text;

                // Check if any field is empty
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(firstName) ||
                    string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(cnic))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the event handler
                }

                // Generate a unique ID for the user (you can modify this according to your requirements)
                int id = GenerateUniqueId();

                // Insert the user data into the database
                string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"; // Replace with your actual connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO UserInformation (id, username, user_Fname, user_pass, email, cnic) VALUES (@id, @username, @firstName, @password, @email, @cnic)";
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@cnic", cnic);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Signup successful!");

                // Clear the TextBoxes
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            SigninForm s1 = new SigninForm();
            s1.Show();
            this.Hide();
        }

        private int GenerateUniqueId()
        {
            // Generate a unique ID based on the current timestamp (you can modify this according to your requirements)
            return (int)DateTime.Now.Ticks;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
