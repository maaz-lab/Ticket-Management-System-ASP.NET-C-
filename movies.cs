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
    public partial class movies : Form
    {
        string m_name;
        string duration;
        string cinema1;
        string cinema1_lounge;
        string cinema1_timing;
        string cinema2;
        string cinema2_lounge;
        string cinema2_timing;
        Image pic;
        string movie_details;
        string name1;
        public movies()
        {
            InitializeComponent();
        }
        public void Settextfromlabel1(string mytext)
        {
            name1 = mytext;
        }
        private void movies_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Karachi")
            {
                button2.Visible = true;
                button3.Visible = true;
                button5.Visible = true;
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fast X 3D
            movie_ticket m1 = new movie_ticket();
            m1.Show();
            m_name = "Fast X 3D";
            duration = "2:00";
            cinema1 = "Nupelex Cinema";
            cinema1_lounge = "Red Lounge";
            cinema1_timing = "3:15 PM";
            cinema2 = "cineplex cinema";
            cinema2_lounge = "Gold Lounge";
            cinema2_timing = "8:15 PM";
            pic = this.button2.BackgroundImage;
            movie_details = "Dom Toretto and his family are targeted by the vengeful son of drug kingpin Hernan Reyes.";
            
            m1.setvalues(m_name,duration,cinema1,cinema1_lounge,cinema1_timing,cinema2,cinema2_lounge,cinema2_timing,pic,movie_details);
            m1.Settextfromlabel1(name1);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //Maula Jatt
            movie_ticket m1 = new movie_ticket();
            m1.Show();
            m_name = "Maula Jatt";
            duration = "2:00";
            cinema1 = "Nupelex Cinema";
            cinema1_lounge = "Red Lounge";
            cinema1_timing = "5:15 PM";
            cinema2 = "cineplex cinema";
            cinema2_lounge = "Gold Lounge";
            cinema2_timing = "11:15 PM";
            pic = this.button3.BackgroundImage;
            movie_details = "Maula Jatt, a fierce prizefighter with a tortured past seeks vengeance against his arch nemesis Noori Natt," +
                " the most feared warrior in the land of Punjab.";
            m1.setvalues(m_name, duration, cinema1, cinema1_lounge, cinema1_timing, cinema2, cinema2_lounge, cinema2_timing, pic, movie_details);
            m1.Settextfromlabel1(name1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //teefa in trouble
            movie_ticket m1 = new movie_ticket();
            m1.Show();
            m1.Show();
            m_name = "Teefa In Trouble";
            duration = "2:15";
            cinema1 = "Nupelex Cinema";
            cinema1_lounge = "Red Lounge";
            cinema1_timing = "2:15 PM";
            cinema2 = "cineplex cinema";
            cinema2_lounge = "Gold Lounge";
            cinema2_timing = "7:15 PM";
            pic = this.button4.BackgroundImage;
            movie_details = "Teefa goes to Poland to get Anya to Pakistan to marry Butt gangster's son but lands up in trouble with " +
                "Anya's gangster father and the Polish police.";
           
            m1.setvalues(m_name, duration, cinema1, cinema1_lounge, cinema1_timing, cinema2, cinema2_lounge, cinema2_timing, pic, movie_details);
            m1.Settextfromlabel1(name1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Spider-man No Way Home
            movie_ticket m1 = new movie_ticket();
            m1.Show();
            m_name = "SPIDER-MAN No Way Home";
            duration = "2:00";
            cinema1 = "Nupelex Cinema";
            cinema1_lounge = "Red Lounge";
            cinema1_timing = "8:15 PM";
            cinema2 = "cineplex cinema";
            cinema2_lounge = "Gold Lounge";
            cinema2_timing = "11:15 PM";
            pic = this.button5.BackgroundImage;
            movie_details = "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, " +
                "bringing in monstrous villains that could destroy the world.";
           
            m1.setvalues(m_name, duration, cinema1, cinema1_lounge, cinema1_timing, cinema2, cinema2_lounge, cinema2_timing, pic, movie_details);
            m1.Settextfromlabel1(name1);
        }
    }
}
