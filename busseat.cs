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

namespace HomeScreen
{
    public partial class busseat : Form
    {
        int price;
        static int[] bookedseat;
        static int[] tempbookseat;
        static int[] bus_seat_price;
        string name1;
        string Arrival;
        string Departure;
        string date1;
        string seatbooked;
        public busseat()
        {
            InitializeComponent();
        }
        public void setname(string name)
        {
            name1 = name;
        }
        public void setvalue(string arrival, string departure,string date)
        {
            Arrival = arrival;
            Departure = departure;
            date1 = date;
        }
        private void busseat_Load(object sender, EventArgs e)
        {
                bus_seat_price = new int[20];
                bookedseat = new int[20];
                tempbookseat = new int[20];

                tempbookseat[0] = 0;
                bus_seat_price[0] = 600;
                tempbookseat[1] = 0;
                bus_seat_price[1] = 600;
                tempbookseat[2] = 0;
                bus_seat_price[2] = 600;
                tempbookseat[3] = 0;
                bus_seat_price[3] = 600;
                tempbookseat[4] = 0;
                bus_seat_price[4] = 600;
                tempbookseat[5] = 0;
                bus_seat_price[5] = 600;
                tempbookseat[6] = 0;
                bus_seat_price[6] = 600;
                tempbookseat[7] = 0;
                bus_seat_price[7] = 600;
                tempbookseat[8] = 0;
                bus_seat_price[8] = 600;
                tempbookseat[9] = 0;
                bus_seat_price[9] = 600;
                tempbookseat[10] = 0;
                bus_seat_price[10] = 600;
                tempbookseat[11] = 0;
                bus_seat_price[11] = 600;
                tempbookseat[12] = 0;
                bus_seat_price[12] = 600;
                tempbookseat[13] = 0;
                bus_seat_price[13] = 600;
                tempbookseat[14] = 0;
                bus_seat_price[14] = 600;
                tempbookseat[15] = 0;
                bus_seat_price[15] = 600;
                tempbookseat[16] = 0;
                bus_seat_price[16] = 600;
                tempbookseat[17] = 0;
                bus_seat_price[17] = 600;
                tempbookseat[18] = 0;
                bus_seat_price[18] = 600;
                tempbookseat[19] = 0;
                bus_seat_price[19] = 600;
            alreadybooked();
        }
        private void alreadybooked()
        {
         
            String myquery = "Select * from SeatStatus";
            SqlConnection con = new SqlConnection("Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            int rows = ds.Tables[0].Rows.Count;
            int i = 0;
            while (i < rows)
            {
                String status;
                status = ds.Tables[0].Rows[i]["status"].ToString();
                if (status == "B")
                {
                    bookedseat[i] = 1;
                    if (i == 0)
                    {
                        button1.BackColor = System.Drawing.Color.Red;
                        button1.Enabled = false;
                    }
                    if (i == 1)
                    {
                        button2.BackColor = System.Drawing.Color.Red;
                        button2.Enabled = false;
                    }
                    if (i == 2)
                    {
                        button3.BackColor = System.Drawing.Color.Red;
                        button3.Enabled = false;
                    }
                    if (i == 3)
                    {
                        button4.BackColor = System.Drawing.Color.Red;
                        button4.Enabled = false;
                    }
                    if (i == 4)
                    {
                        button5.BackColor = System.Drawing.Color.Red;
                        button5.Enabled = false;
                    }
                    if (i == 5)
                    {
                        button6.BackColor = System.Drawing.Color.Red;
                        button6.Enabled = false;
                    }
                    if (i == 6)
                    {
                        button7.BackColor = System.Drawing.Color.Red;
                        button7.Enabled = false;
                    }
                    if (i == 7)
                    {
                        button8.BackColor = System.Drawing.Color.Red;
                        button8.Enabled = false;
                    }
                    if (i == 8)
                    {
                        button9.BackColor = System.Drawing.Color.Red;
                        button9.Enabled = false;
                    }
                    if (i == 9)
                    {
                        button10.BackColor = System.Drawing.Color.Red;
                        button10.Enabled = false;
                    }
                    if (i == 10)
                    {
                        button11.BackColor = System.Drawing.Color.Red;
                        button11.Enabled = false;
                    }
                    if (i == 11)
                    {
                        button12.BackColor = System.Drawing.Color.Red;
                        button12.Enabled = false;
                    }
                    if (i == 12)
                    {
                        button13.BackColor = System.Drawing.Color.Red;
                        button13.Enabled = false;
                    }
                    if (i == 13)
                    {
                        button14.BackColor = System.Drawing.Color.Red;
                        button14.Enabled = false;

                    }
                    if (i == 14)
                    {
                        button15.BackColor = System.Drawing.Color.Red;
                        button15.Enabled = false;

                    }
                    if (i == 15)
                    {

                        button16.BackColor = System.Drawing.Color.Red;
                        button16.Enabled = false;
                    }
                    if (i == 16)
                    {
                        button17.BackColor = System.Drawing.Color.Red;
                        button17.Enabled = false;
                    }
                    if (i == 17)
                    {
                        button18.BackColor = System.Drawing.Color.Red;
                        button18.Enabled = false;
                    }
                    if (i == 18)
                    {
                        button19.BackColor = System.Drawing.Color.Red;
                        button19.Enabled = false;

                    }
                    if (i == 19)
                    {
                        button20.BackColor = System.Drawing.Color.Red;
                        button20.Enabled = false;

                    }
                   
                }
                if (status == "A")
                { 
                    bookedseat[i] = 0;
                    if (i == 0)
                    {
                        button1.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 1)
                    {
                        button2.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 2)
                    {
                        button3.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 3)
                    {
                        button4.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 4)
                    {
                        button5.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 5)
                    {
                        button6.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 6)
                    {
                        button7.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 7)
                    {
                        button8.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 8)
                    {
                        button9.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 9)
                    {
                        button10.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 10)
                    {
                        button11.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 11)
                    {
                        button12.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 12)
                    {
                        button13.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 13)
                    {
                        button14.BackColor = System.Drawing.Color.Gray;

                    }
                    if (i == 14)
                    {
                        button15.BackColor = System.Drawing.Color.Gray;

                    }
                    if (i == 15)
                    {

                        button16.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 16)
                    {
                        button17.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 17)
                    {
                        button18.BackColor = System.Drawing.Color.Gray;

                    }
                    if (i == 18)
                    {
                        button19.BackColor = System.Drawing.Color.Gray;

                    }
                    if (i == 19)
                    {

                        button20.BackColor = System.Drawing.Color.Gray;
                    }

                }
                i++;
            }
        }
        private void button24_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button24.Enabled = false;
            button24.BackColor = System.Drawing.Color.Gray;
            int i = 0;
            seatbooked = "";
            for (i = 0; i < 20; i++)
            {
                if (tempbookseat[i] == 1)
                {
                    price = price + bus_seat_price[i];
                    seatbooked = seatbooked + (i + 1) + ", ";
                }
            }
            Bseat_price.Text = "RS " + Convert.ToString(price);
            label10.Text = seatbooked;
            this.Refresh();

        }
        private void button25_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Bus_User_Details (Name, Departure, Arrival, Date, [Seat no]) VALUES (@Name, @Departure, @Arrival,@Date, @Seat_no)";

                    command.Parameters.AddWithValue("@Name", name1);
                    command.Parameters.AddWithValue("@Departure", Departure);
                    command.Parameters.AddWithValue("@Arrival", Arrival);
                    command.Parameters.AddWithValue("@Date", date1);
                    command.Parameters.AddWithValue("@Seat_no", seatbooked);
                    command.ExecuteNonQuery();
                }
            }
            int i = 0;
            for (i = 0; i < 20; i++)
            {
                if (tempbookseat[i] == 1)
                {
                    String mycon = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                    String updatedata = "Update SeatStatus set Status='B' where [Seat no]=" + (i + 1);
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = updatedata;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            billing b1 = new billing();
            b1.ShowDialog();
            this.Hide();
            this.Refresh();
            messagebox m = new messagebox();
            m.ShowDialog();

            Form4 f4 = new Form4();
            f4.Settextfromlabel(seatbooked,Arrival,Departure,date1,name1);
            f4.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tempbookseat[0] == 0)
            {
                button1.BackColor = System.Drawing.Color.Green;
                tempbookseat[0] = 1;

            }
            else
            {
                button1.BackColor = System.Drawing.Color.Gray;
                tempbookseat[0] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tempbookseat[1] == 0)
            {
                button2.BackColor = System.Drawing.Color.Green;
                tempbookseat[1] = 1;

            }
            else
            {
                button2.BackColor = System.Drawing.Color.Gray;
                tempbookseat[1] = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tempbookseat[2] == 0)
            {
                button3.BackColor = System.Drawing.Color.Green;
                tempbookseat[2] = 1;

            }
            else
            {
                button3.BackColor = System.Drawing.Color.Gray;
                tempbookseat[2] = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tempbookseat[3] == 0)
            {
                button4.BackColor = System.Drawing.Color.Green;
                tempbookseat[3] = 1;

            }
            else
            {
                button4.BackColor = System.Drawing.Color.Gray;
                tempbookseat[3] = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tempbookseat[4] == 0)
            {
                button5.BackColor = System.Drawing.Color.Green;
                tempbookseat[4] = 1;

            }
            else
            {
                button5.BackColor = System.Drawing.Color.Gray;
                tempbookseat[4] = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tempbookseat[5] == 0)
            {
                button6.BackColor = System.Drawing.Color.Green;
                tempbookseat[5] = 1;

            }
            else
            {
                button6.BackColor = System.Drawing.Color.Gray;
                tempbookseat[5] = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tempbookseat[6] == 0)
            {
                button7.BackColor = System.Drawing.Color.Green;
                tempbookseat[6] = 1;

            }
            else
            {
                button7.BackColor = System.Drawing.Color.Gray;
                tempbookseat[6] = 0;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (tempbookseat[7] == 0)
            {
                button8.BackColor = System.Drawing.Color.Green;
                tempbookseat[7] = 1;
            }
            else
            {
                button8.BackColor = System.Drawing.Color.Gray;
                tempbookseat[7] = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tempbookseat[8] == 0)
            {
                button9.BackColor = System.Drawing.Color.Green;
                tempbookseat[8] = 1;
            }
            else
            {
                button9.BackColor = System.Drawing.Color.Gray;
                tempbookseat[8] = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tempbookseat[9] == 0)
            {
                button10.BackColor = System.Drawing.Color.Green;
                tempbookseat[9] = 1;
            }
            else
            {
                button10.BackColor = System.Drawing.Color.Gray;
                tempbookseat[9] = 0;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (tempbookseat[10] == 0)
            {
                button11.BackColor = System.Drawing.Color.Green;
                tempbookseat[10] = 1;
            }
            else
            {
                button11.BackColor = System.Drawing.Color.Gray;
                tempbookseat[10] = 0;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (tempbookseat[19] == 0)
            {
                button20.BackColor = System.Drawing.Color.Green;
                tempbookseat[19] = 1;
            }
            else
            {
                button20.BackColor = System.Drawing.Color.Gray;
                tempbookseat[19] = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tempbookseat[11] == 0)
            {
                button12.BackColor = System.Drawing.Color.Green;
                tempbookseat[11] = 1;
            }
            else
            {
                button12.BackColor = System.Drawing.Color.Gray;
                tempbookseat[11] = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tempbookseat[12] == 0)
            {
                button13.BackColor = System.Drawing.Color.Green;
                tempbookseat[12] = 1;
            }
            else
            {
                button13.BackColor = System.Drawing.Color.Gray;
                tempbookseat[12] = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tempbookseat[13] == 0)
            {
                button14.BackColor = System.Drawing.Color.Green;
                tempbookseat[13] = 1;
            }
            else
            {
                button14.BackColor = System.Drawing.Color.Gray;
                tempbookseat[13] = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tempbookseat[14] == 0)
            {
                button15.BackColor = System.Drawing.Color.Green;
                tempbookseat[14] = 1;
            }
            else
            {
                button15.BackColor = System.Drawing.Color.Gray;
                tempbookseat[14] = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (tempbookseat[15] == 0)
            {
                button16.BackColor = System.Drawing.Color.Green;
                tempbookseat[15] = 1;
            }
            else
            {
                button16.BackColor = System.Drawing.Color.Gray;
                tempbookseat[15] = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tempbookseat[16] == 0)
            {
                button17.BackColor = System.Drawing.Color.Green;
                tempbookseat[16] = 1;
            }
            else
            {
                button17.BackColor = System.Drawing.Color.Gray;
                tempbookseat[15] = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tempbookseat[17] == 0)
            {
                button18.BackColor = System.Drawing.Color.Green;
                tempbookseat[17] = 1;
            }
            else
            {
                button18.BackColor = System.Drawing.Color.Gray;
                tempbookseat[17] = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tempbookseat[18] == 0)
            {
                button19.BackColor = System.Drawing.Color.Green;
                tempbookseat[18] = 1;
            }
            else
            {
                button19.BackColor = System.Drawing.Color.Gray;
                tempbookseat[18] = 0;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();
            b.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
