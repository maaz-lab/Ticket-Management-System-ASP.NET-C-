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
    public partial class TrainCompartments : Form
    {
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
<<<<<<< HEAD


        string passenger_name;
=======
        
>>>>>>> 17636025b17271e9db42e71c2246c4bc38c86f7b
        public DateTime bookingDate { get; set; }

        public string username { get; set; }

        int price;
        static int[] bookedSeat;
        static int[] tempBookedSeat;
        static int[] seatPrice;
        static int[] berthPrice;


        public TrainCompartments()
        {
            InitializeComponent();
            coach1.GotFocus += button33_GotFocus;
            coach1.Click += button33_Click;
            coach2.GotFocus += button34_GotFocus;
            coach3.GotFocus += button35_GotFocus;
            coach4.GotFocus += button36_GotFocus;
            coach5.GotFocus += button37_GotFocus;
            coach6.GotFocus += button38_GotFocus;
            coach7.GotFocus += button39_GotFocus;
            coach8.GotFocus += button40_GotFocus;

            panel2.Visible = false;
            panel3.Visible = false;
            

        }

        //private bool isColorChanged = false;

        private void TrainCompartment_Load(object sender, EventArgs e)
        {
            seatPrice = new int[31];
            berthPrice = new int[31];
            tempBookedSeat = new int[31];
            bookedSeat = new int[31];


            tempBookedSeat[30] = 0;
            seatPrice[0] = 1350;

            tempBookedSeat[29] = 0;
            seatPrice[1] = 1350;

            tempBookedSeat[28] = 0;
            seatPrice[2] = 1350;

            tempBookedSeat[27] = 0;
            seatPrice[3] = 1350;

            tempBookedSeat[26] = 0;
            seatPrice[4] = 1350;

            tempBookedSeat[25] = 0;
            seatPrice[5] = 1350;

            tempBookedSeat[24] = 0;
            seatPrice[6] = 1350;

            tempBookedSeat[0] = 0;
            berthPrice[0] = 1500;

            tempBookedSeat[1] = 0;
            berthPrice[1] = 1500;

            tempBookedSeat[2] = 0;
            berthPrice[2] = 1500;

            tempBookedSeat[3] = 0;
            berthPrice[3] = 1500;

            tempBookedSeat[4] = 0;
            berthPrice[4] = 1500;

            tempBookedSeat[5] = 0;
            berthPrice[5] = 1500;

            tempBookedSeat[6] = 0;
            berthPrice[6] = 1500;

            tempBookedSeat[7] = 0;
            berthPrice[7] = 1500;

            tempBookedSeat[8] = 0;
            berthPrice[8] = 1500;

            tempBookedSeat[9] = 0;
            berthPrice[9] = 1500;

            tempBookedSeat[10] = 0;
            berthPrice[10] = 1500;

            tempBookedSeat[11] = 0;
            berthPrice[11] = 1500;

            tempBookedSeat[12] = 0;
            berthPrice[12] = 1500;

            tempBookedSeat[13] = 0;
            berthPrice[13] = 1500;

            tempBookedSeat[14] = 0;
            berthPrice[14] = 1500;

            tempBookedSeat[15] = 0;
            berthPrice[15] = 1500;

            tempBookedSeat[16] = 0;
            berthPrice[16] = 1500;

            tempBookedSeat[17] = 0;
            berthPrice[17] = 1500;

            tempBookedSeat[18] = 0;
            berthPrice[18] = 1500;

            tempBookedSeat[19] = 0;
            berthPrice[19] = 1500;

            tempBookedSeat[20] = 0;
            berthPrice[20] = 1500;

            tempBookedSeat[21] = 0;
            berthPrice[21] = 1500;

            tempBookedSeat[22] = 0;
            berthPrice[22] = 1500;

            tempBookedSeat[23] = 0;
            berthPrice[23] = 1500;

            alreadyBooked();
        }
        private void alreadyBooked()
        {
            string myquery = "select * from berthStatus";
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
                string status;
                status = ds.Tables[0].Rows[i]["status"].ToString();


                if (status == "B")
                {
                    bookedSeat[i] = 1;
                    if (i == 0)
                    {
                        berth1.BackColor = System.Drawing.Color.Red;
                        berth1.Enabled = false;
                    }
                    if (i == 1)
                    {
                        berth2.BackColor = System.Drawing.Color.Red;
                        berth2.Enabled = false;
                    }
                    if (i == 2)
                    {
                        berth3.BackColor = System.Drawing.Color.Red;
                        berth3.Enabled = false;
                    }
                    if (i == 3)
                    {
                        berth4.BackColor = System.Drawing.Color.Red;
                        berth4.Enabled = false;
                    }
                    if (i == 4)
                    {
                        berth5.BackColor = System.Drawing.Color.Red;
                        berth5.Enabled = false;
                    }
                    if (i == 5)
                    {
                        berth6.BackColor = System.Drawing.Color.Red;
                        berth6.Enabled = false;
                    }
                    if (i == 6)
                    {
                        berth7.BackColor = System.Drawing.Color.Red;
                        berth7.Enabled = false;
                    }
                    if (i == 7)
                    {
                        berth8.BackColor = System.Drawing.Color.Red;
                        berth8.Enabled = false;
                    }
                    if (i == 8)
                    {
                        berth9.BackColor = System.Drawing.Color.Red;
                        berth9.Enabled = false;
                    }
                    if (i == 9)
                    {
                        berth10.BackColor = System.Drawing.Color.Red;
                        berth10.Enabled = false;
                    }
                    if (i == 10)
                    {
                        berth11.BackColor = System.Drawing.Color.Red;
                        berth11.Enabled = false;
                    }
                    if (i == 11)
                    {
                        berth12.BackColor = System.Drawing.Color.Red;
                        berth12.Enabled = false;
                    }
                    if (i == 12)
                    {
                        berth13.BackColor = System.Drawing.Color.Red;
                        berth13.Enabled = false;
                    }
                    if (i == 13)
                    {
                        berth14.BackColor = System.Drawing.Color.Red;
                        berth14.Enabled = false;
                    }
                    if (i == 14)
                    {
                        berth15.BackColor = System.Drawing.Color.Red;
                        berth15.Enabled = false;
                    }
                    if (i == 15)
                    {
                        berth16.BackColor = System.Drawing.Color.Red;
                        berth16.Enabled = false;
                    }
                    if (i == 16)
                    {
                        berth17.BackColor = System.Drawing.Color.Red;
                        berth17.Enabled = false;
                    }
                    if (i == 17)
                    {
                        berth18.BackColor = System.Drawing.Color.Red;
                        berth18.Enabled = false;
                    }
                    if (i == 18)
                    {
                        berth19.BackColor = System.Drawing.Color.Red;
                        berth19.Enabled = false;
                    }
                    if (i == 19)
                    {
                        berth20.BackColor = System.Drawing.Color.Red;
                        berth20.Enabled = false;
                    }
                    if (i == 20)
                    {
                        berth21.BackColor = System.Drawing.Color.Red;
                        berth21.Enabled = false;
                    }
                    if (i == 21)
                    {
                        berth22.BackColor = System.Drawing.Color.Red;
                        berth22.Enabled = false;
                    }
                    if (i == 22)
                    {
                        berth23.BackColor = System.Drawing.Color.Red;
                        berth23.Enabled = false;
                    }
                    if (i == 23)
                    {
                        berth24.BackColor = System.Drawing.Color.Red;
                        berth24.Enabled = false;
                    }
                    if (i == 24)
                    {
                        seat1.BackColor = System.Drawing.Color.Red;
                        seat1.Enabled = false;
                    }
                    if (i == 25)
                    {
                        seat2.BackColor = System.Drawing.Color.Red;
                        seat2.Enabled = false;
                    }
                    if (i == 26)
                    {
                        seat3.BackColor = System.Drawing.Color.Red;
                        seat3.Enabled = false;
                    }
                    if (i == 28)
                    {
                        seat4.BackColor = System.Drawing.Color.Red;
                        seat4.Enabled = false;
                    }
                    if (i == 29)
                    {
                        seat5.BackColor = System.Drawing.Color.Red;
                        seat5.Enabled = false;
                    }
                    if (i == 30)
                    {
                        seat6.BackColor = System.Drawing.Color.Red;
                        seat6.Enabled = false;
                    }
                    if (i == 31)
                    {
                        seat7.BackColor = System.Drawing.Color.Red;
                        seat7.Enabled = false;
                    }


                }
                if (status == "A")
                {
                    bookedSeat[i] = 0;
                    if (i == 0)
                    {
                        berth1.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 1)
                    {
                        berth2.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 2)
                    {
                        berth3.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 3)
                    {
                        berth4.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 4)
                    {
                        berth5.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 5)
                    {
                        berth6.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 6)
                    {
                        berth7.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 7)
                    {
                        berth8.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 8)
                    {
                        berth9.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 9)
                    {
                        berth10.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 10)
                    {
                        berth11.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 11)
                    {
                        berth12.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 12)
                    {
                        berth13.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 13)
                    {
                        berth14.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 14)
                    {
                        berth15.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 15)
                    {
                        berth16.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 16)
                    {
                        berth17.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 17)
                    {
                        berth18.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 18)
                    {
                        berth19.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 19)
                    {
                        berth20.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 20)
                    {
                        berth21.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 21)
                    {
                        berth22.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 22)
                    {
                        berth23.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 23)
                    {
                        berth24.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 24)
                    {
                        seat1.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 25)
                    {
                        seat2.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 26)
                    {
                        seat3.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 28)
                    {
                        seat4.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 29)
                    {
                        seat5.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 30)
                    {
                        seat6.BackColor = System.Drawing.Color.Green;
                    }
                    if (i == 31)
                    {
                        seat7.BackColor = System.Drawing.Color.Green;

                    }


                }

                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage m1 = new mainpage();
            m1.Show();
            this.Hide();
        }
        private void button33_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }
        private void button33_GotFocus(object sender, EventArgs e)
        {
            coach1.BackColor = Color.RoyalBlue;
            coach2.BackColor = Color.Green;
            coach3.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.Green;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

        }
        private void button34_GotFocus(object sender, EventArgs e)
        {
            coach2.BackColor = Color.RoyalBlue;
            coach1.BackColor = Color.Green;
            coach3.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.Green;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button35_GotFocus(object sender, EventArgs e)
        {
            coach3.BackColor = Color.RoyalBlue;
            coach2.BackColor = Color.Green;
            coach1.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.Green;


        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button36_GotFocus(object sender, EventArgs e)
        {
            coach4.BackColor = Color.RoyalBlue;
            coach3.BackColor = Color.Green;
            coach2.BackColor = Color.Green;
            coach1.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.Green;


        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button37_GotFocus(object sender, EventArgs e)
        {
            coach1.BackColor = Color.Green;
            coach2.BackColor = Color.Green;
            coach3.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.RoyalBlue;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.Green;

        }
        private void button38_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button38_GotFocus(object sender, EventArgs e)
        {
            coach1.BackColor = Color.Green;
            coach2.BackColor = Color.Green;
            coach3.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.RoyalBlue;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.Green;

        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button39_GotFocus(object sender, EventArgs e)
        {
            coach1.BackColor = Color.Green;
            coach2.BackColor = Color.Green;
            coach3.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.RoyalBlue;
            coach8.BackColor = Color.Green;

        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button40_GotFocus(object sender, EventArgs e)
        {
            coach1.BackColor = Color.Green;
            coach2.BackColor = Color.Green;
            coach3.BackColor = Color.Green;
            coach4.BackColor = Color.Green;
            coach5.BackColor = Color.Green;
            coach6.BackColor = Color.Green;
            coach7.BackColor = Color.Green;
            coach8.BackColor = Color.RoyalBlue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tempBookedSeat[0] == 0)
            {
                berth1.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[0] = 1;
            }
            else
            {
                berth1.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[0] = 0;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            bookme.Enabled = false;
            panel3.Visible = true;
            bookme.Enabled = false;
            bookme.BackColor = System.Drawing.Color.Gray;
            int i = 0, j = 0 ;
            String seatbooked = "";

            try
            {
                for (i = 0; i < 31; i++)
                {
                    if (tempBookedSeat[i] == 1)
                    {
                        price += berthPrice[i];
                        //price += seatPrice[i];
                        seatbooked =+ (i + 1) + ", ";
                    }
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception occurred: " + ex.Message);
            }

            for (j = 0; j < 31; j++)
            {
                if (tempBookedSeat[j] == 1)
                {
                   price += seatPrice[j];
                   seatbooked =+ (j + 1) + ", ";
                }
            }


            Bseat_price.Text = "Rs. " + Convert.ToString(price);
            label9.Text = seatbooked;
            this.Refresh();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[1] == 0)
            {
                berth2.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[1] = 1;
            }
            else
            {
                berth2.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[1] = 0;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[2] == 0)
            {
                berth3.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[2] = 1;
            }
            else
            {
                berth3.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[2] = 0;
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[24] == 0)
            {
                seat1.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[24] = 1;
            }
            else
            {
                seat1.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[24] = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[3] == 0)
            {
                berth4.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[3] = 1;
            }
            else
            {
                berth4.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[3] = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[4] == 0)
            {
                berth5.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[4] = 1;
            }
            else
            {
                berth5.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[4] = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[5] == 0)
            {
                berth6.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[5] = 1;
            }
            else
            {
                berth6.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[5] = 0;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[6] == 0)
            {
                berth7.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[6] = 1;
            }
            else
            {
                berth7.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[6] = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[7] == 0)
            {
                berth8.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[7] = 1;
            }
            else
            {
                berth8.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[7] = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[8] == 0)
            {
                berth9.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[8] = 1;
            }
            else
            {
                berth9.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[8] = 0;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[25] == 0)
            {
                seat2.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[25] = 1;
            }
            else
            {
                seat2.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[25] = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[9] == 0)
            {
                berth10.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[9] = 1;
            }
            else
            {
                berth10.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[9] = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[10] == 0)
            {
                berth11.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[10] = 1;
            }
            else
            {
                berth11.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[10] = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[11] == 0)
            {
                berth12.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[11] = 1;
            }
            else
            {
                berth12.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[11] = 0;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[26] == 0)
            {
                seat3.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[26] = 1;
            }
            else
            {
                seat3.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[26] = 0;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[27] == 0)
            {
                seat4.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[27] = 1;
            }
            else
            {
                seat4.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[27] = 0;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[28] == 0)
            {
                seat5.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[28] = 1;
            }
            else
            {
                seat5.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[28] = 0;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[29] == 0)
            {
                seat6.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[29] = 1;
            }
            else
            {
                seat6.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[29] = 0;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[30] == 0)
            {
                seat7.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[30] = 1;
            }
            else
            {
                seat7.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[30] = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[14] == 0)
            {
                berth15.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[14] = 1;
            }
            else
            {
                berth15.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[14] = 0;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[17] == 0)
            {
                berth18.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[17] = 1;
            }
            else
            {
                berth18.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[17] = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[20] == 0)
            {
                berth21.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[20] = 1;
            }
            else
            {
                berth21.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[20] = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[23] == 0)
            {
                berth24.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[23] = 1;
            }
            else
            {
                berth24.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[23] = 0;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[13] == 0)
            {
                berth14.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[13] = 1;
            }
            else
            {
                berth14.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[13] = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[16] == 0)
            {
                berth17.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[16] = 1;
            }
            else
            {
                berth17.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[16] = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[19] == 0)
            {
                berth20.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[19] = 1;
            }
            else
            {
                berth20.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[19] = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[22] == 0)
            {
                berth23.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[22] = 1;
            }
            else
            {
                berth23.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[22] = 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[12] == 0)
            {
                berth13.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[12] = 1;
            }
            else
            {
                berth13.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[12] = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[15] == 0)
            {
                berth16.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[15] = 1;
            }
            else
            {
                berth16.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[15] = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[18] == 0)
            {
                berth19.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[18] = 1;
            }
            else
            {
                berth19.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[18] = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (tempBookedSeat[21] == 0)
            {
                berth22.BackColor = System.Drawing.Color.RoyalBlue;
                tempBookedSeat[21] = 1;
            }
            else
            {
                berth22.BackColor = System.Drawing.Color.Green;
                tempBookedSeat[21] = 0;
            }
        }
        

        int seatNoBooked;
        private void button25_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (textBox1.Text == "")
=======
            panel2.Visible = false;
            int i = 0;
            for (i = 0; i < 31; i++)
>>>>>>> 17636025b17271e9db42e71c2246c4bc38c86f7b
            {
                label20.Text = "Please Enter Your name";
            }
<<<<<<< HEAD
            else
            {
                int i = 0;
                for (i = 0; i < 31; i++)
                {
                    if (tempBookedSeat[i] == 1)
                    {
                        string mycon = "Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                        string updatedata = "update berthStatus set status='B' where [berthNo] =" + (i + 1);
                        seatNoBooked = (i + 1);
                        SqlConnection con = new SqlConnection(mycon);
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = updatedata;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
=======
            this.Refresh();
            messagebox m = new messagebox();
            m.ShowDialog();
            this.Refresh();
            string t_Status = "confirmed";
            string p_Status = "Paid";

            int id = GenerateUniqueId();

            string insertTicketData = "insert into trainTicketBooking(ticketID, passengerName, departreStatiom, arrivalStation, " +
                "seatNumber, fare, bookingDate, ticketStatus, paymentStatus) VALUES (@id, @p_name, @d_station, @a_station, @s_num, @fare, @b_date, @t_status, @p_status) ";
            int idToFind = 731525176;
           using ( SqlConnection Booking_connection = new SqlConnection("Data Source = (localdb)\\bookmedatabase; Initial Catalog = BOOKMEDATABASE; Integrated Security = True"))
            {
                
                Booking_connection.Open();
                string getUserFnameQuery = "SELECT user_Fname FROM UserInformation WHERE id = @username";
                string passengerName = string.Empty;

                using (SqlCommand getUserFnameCommand = new SqlCommand(getUserFnameQuery, Booking_connection))
                {
                    getUserFnameCommand.Parameters.AddWithValue("@username", idToFind);  // Replace userID with the actual user ID value

                    SqlDataReader reader = getUserFnameCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the user_Fname value
                        passengerName = reader["user_Fname"].ToString();
                    }

                    reader.Close();
                }

                using ( SqlCommand command = Booking_connection.CreateCommand())
                {
                    command.CommandText = insertTicketData;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@p_name", passengerName);
                    command.Parameters.AddWithValue("@d_station", DepartureStation);
                    command.Parameters.AddWithValue("@a_station", ArrivalStation);
                    command.Parameters.AddWithValue("@s_num", seatNoBooked);
                    command.Parameters.AddWithValue("@fare", price);
                    command.Parameters.AddWithValue("@b_date", bookingDate);
                    command.Parameters.AddWithValue("@t_status", t_Status);
                    command.Parameters.AddWithValue("@p_status", p_Status);
                    command.ExecuteNonQuery();
>>>>>>> 17636025b17271e9db42e71c2246c4bc38c86f7b

                }
                this.Refresh();
                messagebox m = new messagebox();
                m.ShowDialog();
                this.Hide();
                this.Refresh();
                string t_Status = "confirmed";
                string p_Status = "Paid";

<<<<<<< HEAD
                int id = GenerateUniqueId();

                string insertTicketData = "insert into trainTicketBooking(ticketID, passengerName, departreStatiom, arrivalStation, " +
                    "seatNumber, fare, bookingDate, ticketStatus, paymentStatus) VALUES (@id, @p_name, @d_station, @a_station, @s_num, @fare, @b_date, @t_status, @p_status) ";

                using (SqlConnection Booking_connection = new SqlConnection("Data Source=MAAZ\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
                {
                    passenger_name = textBox1.Text;

                    Booking_connection.Open();
                    using (SqlCommand command = Booking_connection.CreateCommand())
                    {
                        command.CommandText = insertTicketData;
                        command.Parameters.AddWithValue("@id", id);
                        // Check if passengerName is not empty before adding it as a parameter value
                        if (!string.IsNullOrEmpty(passenger_name))
                        {
                            command.Parameters.AddWithValue("@p_name", passenger_name);
                        }
                        else
                        {

                            command.Parameters.AddWithValue("@p_name", DBNull.Value);
                            // throw new Exception("Passenger name is required."); // Example of throwing an exception
                        }

                        command.Parameters.AddWithValue("@d_station", DepartureStation);
                        command.Parameters.AddWithValue("@a_station", ArrivalStation);
                        command.Parameters.AddWithValue("@s_num", seatNoBooked);
                        command.Parameters.AddWithValue("@fare", price);
                        command.Parameters.AddWithValue("@b_date", bookingDate);
                        command.Parameters.AddWithValue("@t_status", t_Status);
                        command.Parameters.AddWithValue("@p_status", p_Status);


                        command.ExecuteNonQuery();

                    }
                }
                Form6 f6 = new Form6();
                f6.setvalues(passenger_name, DepartureStation, ArrivalStation, bookingDate, id);

                f6.Show();
            }

=======
            printTicket pt = new printTicket();
            pt.Show();
>>>>>>> 17636025b17271e9db42e71c2246c4bc38c86f7b
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            bookme.BackColor = System.Drawing.Color.RoyalBlue;
            bookme.Enabled = true;
            panel2.Visible = true;
            panel2.Refresh();

        }
        private static int GenerateUniqueId()
        {
            int id=1;
            return id++;
        }


    }
}
