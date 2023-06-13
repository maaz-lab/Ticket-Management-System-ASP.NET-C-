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
using System.Xml.Linq;

namespace HomeScreen
{
   
    public partial class PlaneSeats : Form
    {
        string name;
        string departure1;
        string arrival1;
        string date1;
        string seat_type1;
        

        public PlaneSeats()
        {
            InitializeComponent();
            monthCalendar1.MaxSelectionCount = 1;
        }

       
        private void PlaneSeats_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(100, 0, 0,0);
            tabControl1.TabPages.Remove(tabPage2);
            if(label6.Text == "Karachi" || label7.Text == "Islamabad" || label6.Text == "Islamabad" || label7.Text == "Karachi")
            {
                label13.Text = "RS 31400";
            }
        }

        

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == " Date of Birth") {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                monthCalendar1.Visible = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!monthCalendar1.Focused || textBox3.Text == "")
                textBox3.Text = " Date of Birth";
                textBox3.ForeColor = SystemColors.WindowFrame;
                monthCalendar1.Visible = false;
            
        }
        public void seetvalues(string Departure,string arrival,string date,string seat_type)
        {
            label6.Text = Departure;
            label7.Text = arrival;
            label8.Text = arrival;
            label9.Text = Departure;
            label14.Text = date;
            label15.Text = seat_type;
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            textBox3.Text = monthCalendar.SelectionStart.ToString();
        }

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            var monthCalendar = sender as MonthCalendar;
            monthCalendar.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == " Enter Your Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
           if (textBox1.Text == "")
            {
                textBox1.Text = " Enter Your Name";
                textBox1.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == " CNIC")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = " CNIC";
                textBox4.ForeColor = SystemColors.WindowFrame;
            }

        }

       

        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if (textBox4.Text == " CNIC")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox7_Enter_1(object sender, EventArgs e)
        {
            if (textBox7.Text == " Enter email address")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = " Enter email address";
                textBox7.ForeColor = SystemColors.WindowFrame;
            }
        }
        public void setvalues(string name1)
        {
            name = name1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox2.Text = name;
            tabControl1.TabPages.Insert(1, tabPage2);
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int lowerBound = 1;
            int upperBound = 100;
            int rNum = random.Next(lowerBound, upperBound);
            string ss = Convert.ToString(rNum);

            string surname = comboBox1.Text;
            string name = surname + textBox1.Text;
            string date_of_birth = textBox3.Text;
            string CNIC = textBox4.Text;
            string country = comboBox2.Text;
            string email_address = textBox7.Text;
            string arrival = label7.Text;
            string departure = label6.Text;
            string date = label14.Text;
            string Price = label13.Text;
            string Seat_type = label15.Text;
            string Boarding_Time = label2.Text;
            string Seat_no = ss+" A";

            if (textBox1.Text == " Enter Your Name" || textBox3.Text == " Date of Birth" || textBox4.Text== " CNIC" 
                || comboBox2.Text == " Country" || textBox7.Text == " Enter email address")
            {
                string msg1 = "Please Fill all the feids";
                MessageBox.Show(msg1, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Flight_Passengers_Details (Name, [Date of Birth],CNIC, Country,Email,Arrival,Departure,Date,Price,[Seat Type],[Boarding Time],[Seat no])" +
                            " VALUES (@Name, @date_of_birth, @CNIC, @Country, @Email,@Arrival ,@departure,@date,@Price,@Seat_type,@Boarding_Time,@Seat_no)";

                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@date_of_birth", date_of_birth);
                        command.Parameters.AddWithValue("@CNIC", CNIC);
                        command.Parameters.AddWithValue("@Country", country);
                        command.Parameters.AddWithValue("@Email", email_address);
                        command.Parameters.AddWithValue("@Arrival", arrival);
                        command.Parameters.AddWithValue("@departure", departure);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@Price", Price);
                        command.Parameters.AddWithValue("@Seat_type", Seat_type);
                        command.Parameters.AddWithValue("@Boarding_Time", Boarding_Time);
                        command.Parameters.AddWithValue("@Seat_no", Seat_no);
                        command.ExecuteNonQuery();
                    }
                }
                string msg1 = "Successfully";
               
                MessageBox.Show(msg1, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                billing b1 = new billing();
                b1.ShowDialog();

                Flight_voucher f1 = new Flight_voucher();
                f1.setvalue(name, departure, arrival, date, Seat_no, Boarding_Time, Boarding_Time);
                f1.Show();
            }

        }
    }
}
