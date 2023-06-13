using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HomeScreen
{
    public partial class billing : Form
    {
        
        public billing()
        {
            InitializeComponent();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void billing_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "  Card Owner Name";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "  Card Owner Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "  Card Number")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "  Card Number";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "  MM")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "  MM";
                textBox3.ForeColor = Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "  YYYY")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "  YYYY";
                textBox4.ForeColor = Color.LightGray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "CVV No.")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "CVV No.";
                textBox5.ForeColor = Color.LightGray;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            

            string Card_O_Name = textBox1.Text;
            string Card_Number = textBox2.Text;
            string Month = textBox3.Text;
            string Year = textBox4.Text;
            string CVV_No = textBox5.Text;
            

            if (textBox1.Text == "" || textBox1.Text == "  Card Owner Name" || textBox2.Text == ""
                || textBox2.Text == "  Visa Owner Name" || textBox3.Text == "" || textBox3.Text == "  MM"
                || textBox4.Text == "" || textBox4.Text == "  YYYY" || textBox5.Text == ""
                || textBox5.Text == "CVV No.")
                
            {
                label1.Text = "Please fill all feilds";
            }
           
            else {
                string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Card_Details (Card_O_Name, Card_Number, Month, Year, CVV_No) VALUES (@Card_O_Name, @Card_Number, @Month, @Year, @CVV_No)";

                        command.Parameters.AddWithValue("@Card_O_Name", Card_O_Name);
                        command.Parameters.AddWithValue("@Card_Number", Card_Number);
                        command.Parameters.AddWithValue("@Month", Month);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@CVV_No", CVV_No);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment Succefully");
                this.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
