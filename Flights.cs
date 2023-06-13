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
    public partial class Flights : Form
    {
        string name;
        public Flights()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.dateTimePicker2.Visible = true;
                this.checkBox2.Checked = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                this.dateTimePicker2.Visible = false;
                this.checkBox1.Checked = false;


            }
        }

        public void setvalues(string name1)
        {
            name = name1;
        }
        private void Flights_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "From" || comboBox3.Text == "To")
            {
                string msg2 = "Please Select Arrival and Destination Stations";
                MessageBox.Show(msg2, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(checkBox1.Checked == false && checkBox2.Checked == false)
            {
               
                string msg1 = "Select your trip";
                MessageBox.Show(msg1, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox2.Text == comboBox3.Text)
            {
                string msg = "Arrival and Departure Stations Cannot be same!";
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string departure = comboBox2.Text;
                string arrival = comboBox3.Text;
                string date = dateTimePicker1.Text;
                string seat_type = comboBox1.Text;

                PlaneSeats p1 = new PlaneSeats();
                p1.setvalues(name);
                p1.seetvalues(departure,arrival,date,seat_type);
                p1.Show();
            }
        }
    }
}
