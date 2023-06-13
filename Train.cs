using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HomeScreen
{
    public partial class Train : Form
    {
        string name;
        public Train()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Islamabad");
            comboBox1.Items.Add("Sukkur");
            comboBox1.Items.Add("Jacobabad");
            comboBox1.Items.Add("Hyderabad");


            comboBox2.Items.Add("Karachi");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Islamabad");
            comboBox2.Items.Add("Sukkur");
            comboBox2.Items.Add("Jacobabad");
            comboBox2.Items.Add("Hyderabad");
            string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            // SQL query to retrieve data from the database
            string query = "SELECT ArrivalStation, DepartureStation FROM TrainDatabase";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string arrivalStation = reader["ArrivalStation"].ToString();
                    string departureStation = reader["DepartureStation"].ToString();

                    if (!string.IsNullOrEmpty(arrivalStation))
                        comboBox1.Items.Add(arrivalStation);

                    if (!string.IsNullOrEmpty(departureStation))
                        comboBox2.Items.Add(departureStation);
                }

                reader.Close();
            }
        }



        public void setname(string name1)
        {
            name = name1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "From" || comboBox2.Text == "To")
            {
                string msg2 = "Please Select Arrival and Destination Stations";
                MessageBox.Show(msg2, "" , MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            else if(comboBox1.Text == comboBox2.Text)
            {
                string msg = "Arrival and Departure Stations Cannot be same!";
                MessageBox.Show(msg,"", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TrainCompartments tc = new TrainCompartments();
                tc.DepartureStation = comboBox1.Text;
                tc.ArrivalStation = comboBox2.Text;
                tc.bookingDate = dateTimePicker1.Value;
            
                tc.Show();
                this.Hide();
            }

          
        }
    }
}
