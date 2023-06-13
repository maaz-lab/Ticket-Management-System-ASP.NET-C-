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
using System.Xml.Linq;

namespace HomeScreen
{
    public partial class movie_ticket : Form
    {
        int price;
        static int[] bookedseat;
        static int[] tempbookseat;
        static int[] movie_seat_price;
        string date;
        string seat_type;
        string seatbooked;
        string name1;
        public movie_ticket()
        {
            InitializeComponent();
        }
        public void Settextfromlabel1(string mytext)
        {
            name1 = mytext;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            comboBox1.Text = "06 June, 2023";
            label6.ForeColor = Color.DarkGoldenrod;
            label5.ForeColor = Color.Red;
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            movie_seat_price = new int[20];
            bookedseat = new int[20];
            tempbookseat = new int[20];

            tempbookseat[0] = 0;
            movie_seat_price[0] = 1000;
            tempbookseat[1] = 0;
            movie_seat_price[1] = 1000;
            tempbookseat[2] = 0;
            movie_seat_price[2] = 1000;
            tempbookseat[3] = 0;
            movie_seat_price[3] = 1000;
            tempbookseat[4] = 0;
            movie_seat_price[4] = 1000;
            tempbookseat[5] = 0;
            movie_seat_price[5] = 1000;
            tempbookseat[6] = 0;
            movie_seat_price[6] = 1000;
            tempbookseat[7] = 0;
            movie_seat_price[7] = 1000;
            tempbookseat[8] = 0;
            movie_seat_price[8] = 1000;
            tempbookseat[9] = 0;
            movie_seat_price[9] = 1000;
            tempbookseat[10] = 0;
            movie_seat_price[10] = 1000;
            tempbookseat[11] = 0;
            movie_seat_price[11] = 1000;
            tempbookseat[12] = 0;
            movie_seat_price[12] = 1000;
            tempbookseat[13] = 0;
            movie_seat_price[13] = 1000;
            tempbookseat[14] = 0;
            movie_seat_price[14] = 1000;
            tempbookseat[15] = 0;
            movie_seat_price[15] = 1000;
            tempbookseat[16] = 0;
            movie_seat_price[16] = 1000;
            tempbookseat[17] = 0;
            movie_seat_price[17] = 1000;
            tempbookseat[18] = 0;
            movie_seat_price[18] = 1000;
            tempbookseat[19] = 0;
            movie_seat_price[19] = 1000;
            alreadybooked();
        }
        
        private void alreadybooked()
        {
            String mycon = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            String myquery = "Select * from movieSeatStatus";
            SqlConnection con = new SqlConnection(mycon);
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
                status = ds.Tables[0].Rows[i]["Status"].ToString();
                if (status == "B")
                {
                    bookedseat[i] = 1;
                    if (i == 0)
                    {
                        button_1.BackColor = System.Drawing.Color.Red;
                        button_1.Enabled = false;
                    }
                    if (i == 1)
                    {
                        button_2.BackColor = System.Drawing.Color.Red;
                        button_2.Enabled = false;
                    }
                    if (i == 2)
                    {
                        button_3.BackColor = System.Drawing.Color.Red;
                        button_3.Enabled = false;
                    }
                    if (i == 3)
                    {
                        button_4.BackColor = System.Drawing.Color.Red;
                        button_4.Enabled = false;
                    }
                    if (i == 4)
                    {
                        button_5.BackColor = System.Drawing.Color.Red;
                        button_5.Enabled = false;
                    }
                    if (i == 5)
                    {
                        button_6.BackColor = System.Drawing.Color.Red;
                        button_6.Enabled = false;
                    }
                    if (i == 6)
                    {
                        button_7.BackColor = System.Drawing.Color.Red;
                        button_7.Enabled = false;
                    }
                    if (i == 7)
                    {
                        button_8.BackColor = System.Drawing.Color.Red;
                        button_8.Enabled = false;
                    }
                    if (i == 8)
                    {
                        button_9.BackColor = System.Drawing.Color.Red;
                        button_9.Enabled = false;
                    }
                    if (i == 9)
                    {
                        button_10.BackColor = System.Drawing.Color.Red;
                        button_10.Enabled = false;
                    }
                    if (i == 10)
                    {
                        button_11.BackColor = System.Drawing.Color.Red;
                        button_11.Enabled = false;
                    }
                    if (i == 11)
                    {
                        button_12.BackColor = System.Drawing.Color.Red;
                        button_12.Enabled = false;
                    }
                    if (i == 12)
                    {
                        button_13.BackColor = System.Drawing.Color.Red;
                        button_13.Enabled = false;
                    }
                    if (i == 13)
                    {
                        button_14.BackColor = System.Drawing.Color.Red;
                        button_14.Enabled = false;

                    }
                    if (i == 14)
                    {
                        button_15.BackColor = System.Drawing.Color.Red;
                        button_15.Enabled = false;

                    }
                    if (i == 15)
                    {

                        button_16.BackColor = System.Drawing.Color.Red;
                        button_16.Enabled = false;
                    }
                    if (i == 16)
                    {
                        button_17.BackColor = System.Drawing.Color.Red;
                        button_17.Enabled = false;
                    }
                    if (i == 17)
                    {
                        button_18.BackColor = System.Drawing.Color.Red;
                        button_18.Enabled = false;
                    }
                    if (i == 18)
                    {
                        button_19.BackColor = System.Drawing.Color.Red;
                        button_19.Enabled = false;

                    }
                    if (i == 19)
                    {
                        button_20.BackColor = System.Drawing.Color.Red;
                        button_20.Enabled = false;

                    }

                }
                if (status == "A")
                {
                    bookedseat[i] = 0;
                    if (i == 0)
                    {
                        button_1.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 1)
                    {
                        button_2.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 2)
                    {
                        button_3.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 3)
                    {
                        button_4.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 4)
                    {
                        button_5.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 5)
                    {
                        button_6.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 6)
                    {
                        button_7.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 7)
                    {
                        button_8.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 8)
                    {
                        button_9.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 9)
                    {
                        button_10.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 10)
                    {
                        button_11.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 11)
                    {
                        button_12.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 12)
                    {
                        button_13.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 13)
                    {
                        button_14.BackColor = System.Drawing.Color.White;

                    }
                    if (i == 14)
                    {
                        button_15.BackColor = System.Drawing.Color.White;

                    }
                    if (i == 15)
                    {

                        button_16.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 16)
                    {
                        button_17.BackColor = System.Drawing.Color.White;
                    }
                    if (i == 17)
                    {
                        button_18.BackColor = System.Drawing.Color.White;

                    }
                    if (i == 18)
                    {
                        button_19.BackColor = System.Drawing.Color.White;

                    }
                    if (i == 19)
                    {

                        button_20.BackColor = System.Drawing.Color.White;
                    }

                }
                i++;
            }
        }
        string selected_items_c1;

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Insert(2, tabPage3);
            
            button1.Enabled = false;
            button2.Enabled = false;
            comboBox1.Enabled = false;

            selected_items_c1 = comboBox1.Text.ToString();
            button3.Text = selected_items_c1;

            label9.Text = label4.Text;
            button4.Text = button1.Text;

            button5.Text = label5.Text;
            button6.Text = "2D";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Insert(2, tabPage3);
            button1.Enabled = false;
            button2.Enabled = false;
            comboBox1.Enabled = false;

            selected_items_c1 = comboBox1.Text.ToString();
            button3.Text = selected_items_c1;

            label9.Text = label7.Text;
            button4.Text = button2.Text;

            button5.Text = label6.Text;
            button6.Text = "2D";
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

        private void button_1_Click(object sender, EventArgs e)
        {
            if (tempbookseat[0] == 0)
            {
                button_1.BackColor = System.Drawing.Color.DodgerBlue;
                button_1.ForeColor = Color.White;
                button_1.FlatAppearance.BorderSize = 0;
               
                tempbookseat[0] = 1;
                
            }
            else
            {

                button_1.BackColor = System.Drawing.Color.White;
                button_1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_1.FlatAppearance.BorderSize = 1;
                button_1.ForeColor = Color.Blue;
                
                tempbookseat[0] = 0;
                

            }
        }
        private void button_2_Click(object sender, EventArgs e)
        {

            if (tempbookseat[1] == 0)
            {

                button_2.BackColor = System.Drawing.Color.DodgerBlue;
                button_2.ForeColor = Color.White;
                button_2.FlatAppearance.BorderSize = 0;
                
                tempbookseat[1] = 1;
                
            }

            else
            {

                button_2.BackColor = System.Drawing.Color.White;
                button_2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_2.FlatAppearance.BorderSize = 1;
                button_2.ForeColor = Color.Blue;
               
                tempbookseat[1] = 0;
                
            }

        }
    
        private void button_3_Click(object sender, EventArgs e)
        {
            if (tempbookseat[2] == 0)
            {
                button_3.BackColor = System.Drawing.Color.DodgerBlue;
                button_3.ForeColor = Color.White;
                button_3.FlatAppearance.BorderSize = 0;
                movie_seat_price[0] = 1000;
                tempbookseat[2] = 1;
                
            }
            else
            {
                button_3.BackColor = System.Drawing.Color.White;
                button_3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_3.FlatAppearance.BorderSize = 1;
                button_3.ForeColor = Color.Blue;
                
                tempbookseat[2] = 0;
               
               
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (tempbookseat[3] == 0)
            {
                button_4.BackColor = System.Drawing.Color.DodgerBlue;
                button_4.ForeColor = Color.White;
                button_4.FlatAppearance.BorderSize = 0;
                tempbookseat[3] = 1;

            }
            else
            {
                button_4.BackColor = System.Drawing.Color.White;
                button_4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_4.FlatAppearance.BorderSize = 1;
                button_4.ForeColor = Color.Blue;
                tempbookseat[3] = 0;
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (tempbookseat[4] == 0)
            {
                button_5.BackColor = System.Drawing.Color.DodgerBlue;
                button_5.ForeColor = Color.White;
                button_5.FlatAppearance.BorderSize = 0;
                tempbookseat[4] = 1;

            }
            else
            {
                button_5.BackColor = System.Drawing.Color.White;
                button_5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_5.FlatAppearance.BorderSize = 1;
                button_5.ForeColor = Color.Blue;
                tempbookseat[4] = 0;
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (tempbookseat[5] == 0)
            {
                button_6.BackColor = System.Drawing.Color.DodgerBlue;
                button_6.ForeColor = Color.White;
                button_6.FlatAppearance.BorderSize = 0;
                tempbookseat[5] = 1;

            }
            else
            {
                button_6.BackColor = System.Drawing.Color.White;
                button_6.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_6.FlatAppearance.BorderSize = 1;
                button_6.ForeColor = Color.Blue;
                tempbookseat[5] = 0;
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (tempbookseat[6] == 0)
            {
                button_7.BackColor = System.Drawing.Color.DodgerBlue;
                button_7.ForeColor = Color.White;
                button_7.FlatAppearance.BorderSize = 0;
                tempbookseat[6] = 1;

            }
            else
            {
                button_7.BackColor = System.Drawing.Color.White;
                button_7.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_7.FlatAppearance.BorderSize = 1;
                button_7.ForeColor = Color.Blue;
                tempbookseat[6] = 0;
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (tempbookseat[7] == 0)
            {
                button_8.BackColor = System.Drawing.Color.DodgerBlue;
                button_8.ForeColor = Color.White;
                button_8.FlatAppearance.BorderSize = 0;
                tempbookseat[7] = 1;
            }
            else
            {
                button_8.BackColor = System.Drawing.Color.White;
                button_8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_8.FlatAppearance.BorderSize = 1;
                button_8.ForeColor = Color.Blue;
                tempbookseat[7] = 0;
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (tempbookseat[8] == 0)
            {
                button_9.BackColor = System.Drawing.Color.DodgerBlue;
                button_9.ForeColor = Color.White;
                button_9.FlatAppearance.BorderSize = 0;
                tempbookseat[8] = 1;
            }
            else
            {
                button_9.BackColor = System.Drawing.Color.White;
                button_9.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_9.FlatAppearance.BorderSize = 1;
                button_9.ForeColor = Color.Blue;
                tempbookseat[8] = 0;
            }
        }

        private void button_10_Click(object sender, EventArgs e)
        {
            if (tempbookseat[9] == 0)
            {
                button_10.BackColor = System.Drawing.Color.DodgerBlue;
                button_10.ForeColor = Color.White;
                button_10.FlatAppearance.BorderSize = 0;
                tempbookseat[9] = 1;
            }
            else
            {
                button_10.BackColor = System.Drawing.Color.White;
                button_10.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_10.FlatAppearance.BorderSize = 1;
                button_10.ForeColor = Color.Blue;
                tempbookseat[9] = 0;
            }
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            if (tempbookseat[10] == 0)
            {
                button_11.BackColor = System.Drawing.Color.DodgerBlue;
                button_11.ForeColor = Color.White;
                button_11.FlatAppearance.BorderSize = 0;
                tempbookseat[10] = 1;
            }
            else
            {
                button_11.BackColor = System.Drawing.Color.White;
                button_11.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_11.FlatAppearance.BorderSize = 1;
                button_11.ForeColor = Color.Blue;
                tempbookseat[10] = 0;
            }
        }

        private void button_12_Click(object sender, EventArgs e)
        {
            if (tempbookseat[11] == 0)
            {
                button_12.BackColor = System.Drawing.Color.DodgerBlue;
                button_12.ForeColor = Color.White;
                button_12.FlatAppearance.BorderSize = 0;
                tempbookseat[11] = 1;
            }
            else
            {
                button_12.BackColor = System.Drawing.Color.White;
                button_12.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_12.FlatAppearance.BorderSize = 1;
                button_12.ForeColor = Color.Blue;
                tempbookseat[11] = 0;
            }
        }

        private void button_13_Click(object sender, EventArgs e)
        {
            if (tempbookseat[12] == 0)
            {
                button_13.BackColor = System.Drawing.Color.DodgerBlue;
                button_13.ForeColor = Color.White;
                button_13.FlatAppearance.BorderSize = 0;
                tempbookseat[12] = 1;
            }
            else
            {
                button_13.BackColor = System.Drawing.Color.White;
                button_13.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_13.FlatAppearance.BorderSize = 1;
                button_13.ForeColor = Color.Blue;
                tempbookseat[12] = 0;
            }
        }

        private void button_14_Click(object sender, EventArgs e)
        {
            if (tempbookseat[13] == 0)
            {
                button_14.BackColor = System.Drawing.Color.DodgerBlue;
                button_14.ForeColor = Color.White;
                button_14.FlatAppearance.BorderSize = 0;
                tempbookseat[13] = 1;
            }
            else
            {
                button_14.BackColor = System.Drawing.Color.White;
                button_14.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_14.FlatAppearance.BorderSize = 1;
                button_14.ForeColor = Color.Blue;
                tempbookseat[13] = 0;
            }
        }

        private void button_15_Click(object sender, EventArgs e)
        {
            if (tempbookseat[14] == 0)
            {
                button_15.BackColor = System.Drawing.Color.DodgerBlue;
                button_15.ForeColor = Color.White;
                button_15.FlatAppearance.BorderSize = 0;
                tempbookseat[14] = 1;
            }
            else
            {
                button_15.BackColor = System.Drawing.Color.White;
                button_15.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_15.FlatAppearance.BorderSize = 1;
                button_15.ForeColor = Color.Blue;
                tempbookseat[14] = 0;
            }
        }
    

        private void button_16_Click(object sender, EventArgs e)
        {
            if (tempbookseat[15] == 0)
            {
                button_16.BackColor = System.Drawing.Color.DodgerBlue;
                button_16.ForeColor = Color.White;
                button_16.FlatAppearance.BorderSize = 0;
                tempbookseat[15] = 1;
            }
            else
            {
                button_16.BackColor = System.Drawing.Color.White;
                button_16.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_16.FlatAppearance.BorderSize = 1;
                button_16.ForeColor = Color.Blue;
                tempbookseat[15] = 0;
            }
        }

        private void button_17_Click(object sender, EventArgs e)
        {
            if (tempbookseat[16] == 0)
            {
                button_17.BackColor = System.Drawing.Color.DodgerBlue;
                button_17.ForeColor = Color.White;
                button_17.FlatAppearance.BorderSize = 0;
                tempbookseat[16] = 1;
            }
            else
            {
                button_17.BackColor = System.Drawing.Color.White;
                button_17.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_17.FlatAppearance.BorderSize = 1;
                button_17.ForeColor = Color.Blue;
                tempbookseat[16] = 0;
            }
        }

        private void button_18_Click(object sender, EventArgs e)
        {
            if (tempbookseat[17] == 0)
            {
                button_18.BackColor = System.Drawing.Color.DodgerBlue;
                button_18.ForeColor = Color.White;
                button_18.FlatAppearance.BorderSize = 0;
                tempbookseat[17] = 1;
            }
            else
            {
                button_18.BackColor = System.Drawing.Color.White;
                button_18.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_18.FlatAppearance.BorderSize = 1;
                button_18.ForeColor = Color.Blue;
                tempbookseat[17] = 0;
            }
        }

        private void button_19_Click(object sender, EventArgs e)
        {
            if (tempbookseat[18] == 0)
            {
                button_19.BackColor = System.Drawing.Color.DodgerBlue;
                button_19.ForeColor = Color.White;
                button_19.FlatAppearance.BorderSize = 0;
                tempbookseat[18] = 1;
            }
            else
            {
                button_19.BackColor = System.Drawing.Color.White;
                button_19.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_19.FlatAppearance.BorderSize = 1;
                button_19.ForeColor = Color.Blue;
                tempbookseat[18] = 0;
            }
        }

        private void button_20_Click(object sender, EventArgs e)
        {
            if (tempbookseat[19] == 0)
            {
                button_20.BackColor = System.Drawing.Color.DodgerBlue;
                button_20.ForeColor = Color.White;
                button_4.FlatAppearance.BorderSize = 0;
                tempbookseat[19] = 1;
            }
            else
            {
                button_20.BackColor = System.Drawing.Color.White;
                button_20.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                button_20.FlatAppearance.BorderSize = 1;
                button_20.ForeColor = Color.Blue;
                tempbookseat[19] = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Insert(3, tabPage4);
            button7.Enabled = false;
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button8.BackColor = SystemColors.HotTrack;
            //panel3.Visible = true;
            button9.Enabled = false;
            button9.BackColor = System.Drawing.Color.Gray;
            int i = 0;
            seatbooked = "";
            for (i = 0; i < 20; i++)
            {
                if (tempbookseat[i] == 1)
                {
                    price = price + movie_seat_price[i];
                    seatbooked = seatbooked + (i + 1) + ", ";
                }
            }
            label13.Text = "RS " + Convert.ToString(price);
            label15.Text = seatbooked;
            this.Refresh();
        }
        public void setvalues(string m_name, string duration, string cinema1, string cinema1_lounge, string cinema1_timing, string cinema2, string cinema2_lounge, string cinema2_timing, Image pic, string details)
        {
            label1.Text = m_name;
            label2.Text = duration;
            label4.Text = cinema1;
            label5.Text = cinema1_lounge;
            button1.Text = cinema1_timing;
            label7.Text = cinema2;
            label6.Text = cinema2_lounge;
            button2.Text = cinema2_timing;
            pictureBox1.BackgroundImage = pic;
            richTextBox1.Text = details;
        }
        private void button8_Click(object sender, EventArgs e)
        {
           
            date = comboBox1.Text;
            seat_type = button7.Text;
            string movie_Name = label1.Text;
            string Cinema_Name1 = label9.Text;
            string Cinema_Lounge1 = button5.Text;
            string Time1 = button4.Text;

            string connectionString = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Movie_User_Details (Name, Date, Movie_Name, Time, Cinema_Name,Cinema_Lounge,Seat_type,Seat_No,Price) " +
                        "VALUES (@Name, @Date1, @Movie_Name1, @Time1, @Cinema_Name1,@Cinema_Lounge1,@Seat_type1,@Seat_No1,@Price1)";

                    command.Parameters.AddWithValue("@Name", name1);
                    command.Parameters.AddWithValue("@Date1", date);
                    command.Parameters.AddWithValue("@Movie_Name1", movie_Name);
                    command.Parameters.AddWithValue("@Time1", Time1);
                    command.Parameters.AddWithValue("@Cinema_Name1", Cinema_Name1);
                    command.Parameters.AddWithValue("@Cinema_Lounge1", Cinema_Lounge1);
                    command.Parameters.AddWithValue("@Seat_type1", seat_type);
                    command.Parameters.AddWithValue("@Seat_No1", seatbooked);
                    command.Parameters.AddWithValue("@Price1", price);
                    command.ExecuteNonQuery();
                }
            }
            int i = 0;
            for (i = 0; i < 20; i++)
            {
                if (tempbookseat[i] == 1)
                {
                    String mycon = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                    String updatedata = "Update movieSeatStatus set Status='B' where [Seat no]=" + (i + 1);
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
            messagebox m1 = new messagebox();
            m1.ShowDialog();
            Movie_Voucher m2 = new Movie_Voucher();
            m2.setvalues(name1,date,seat_type,price);
            m2.Show();
        }

        
    }
   }
