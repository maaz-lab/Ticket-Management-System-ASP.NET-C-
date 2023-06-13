using System;
using System.Windows.Forms;
namespace HomeScreen
{
    public partial class Bus : Form
    {
        string name;
        public Bus()
        { 
            InitializeComponent();
            //panel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { }

        private void Bus_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.Show();
            
        }
        public void setValues(string username)
        {
            name = username;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Departure" || comboBox2.Text == "Select Arrival")
            {
                string msg1 = "No City is Selected";
                MessageBox.Show(msg1, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox1.Text == comboBox2.Text)
            {
                string msg = "Arrival and Departure Stations Cannot be same!";
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Refresh();
                timer1.Interval = 5;
                timer1.Start();
                //panel1.Visible = true;
                timer1.Stop();
                busseat b1 = new busseat();
                b1.setname(name);

                string arrival = comboBox2.Text.ToString();
                string departure = comboBox1.Text.ToString();
                string date = dateTimePicker1.Text.ToString();

                b1.setvalue(arrival, departure,date);
                b1.Show();
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel1.Width = panel1.Width + 15;
        }
    }
}
