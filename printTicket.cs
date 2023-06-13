using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen
{
    public partial class printTicket : Form
    {
        public printTicket()
        {
            InitializeComponent();
        }

        private void printTicket_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\bookmedatabase; Initial Catalog = BOOKMEDATABASE; Integrated Security = True"))
            {
                connection.Open();

                string query = "SELECT TOP 1 ticketID, passengerName, departreStatiom, arrivalStation, bookingDate FROM trainTicketBooking ORDER BY ticketID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string ticketID = reader["ticketID"].ToString();
                        string passengerName = reader["passengerName"].ToString();
                        string departureStation = reader["departreStatiom"].ToString();
                        string arrivalStation = reader["arrivalStation"].ToString();
                        string bookingDate = reader["bookingDate"].ToString();

                        reader.Close();

                        name.Text = passengerName;
                        ticketid.Text = ticketID;
                        from.Text = departureStation;
                        to.Text = arrivalStation;
                        datetime.Text = DateTime.Now.ToString();
                        d_date.Text = bookingDate;

                        name1.Text = passengerName;
                        ticketid.Text = ticketID;
                        from1.Text = departureStation;
                        to1.Text = arrivalStation;
                        datetime1.Text = DateTime.Now.ToString();
                        d_date1.Text = bookingDate;


                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = "TrainTicket" + (ticketid.Text);
                string fileName = "TrainTicket " + (ticketid.Text);
                printDocument1.PrintPage += PrintDocument_PrintPage;
                printDocument1.DocumentName = fileName;
                printDocument1.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Get the bounds of the printable area
            RectangleF bounds = e.PageSettings.PrintableArea;

            Bitmap formImage = new Bitmap(this.Width, this.Height, graphics);
            this.DrawToBitmap(formImage, new Rectangle(0, 0, this.Width, this.Height));
            // Calculate the scaling factor

            float scaleX = bounds.Width / formImage.Width;
            float scaleY = bounds.Height / formImage.Height;
            // Set the scaling mode to maintain the aspect ratio
            float scale = Math.Min(scaleX, scaleY);
            SizeF newSize = new SizeF(formImage.Width * scale, formImage.Height * scale);

            // Calculate the position to center the image on the page
            PointF newPosition = new PointF((bounds.Width - newSize.Width) / 2, (bounds.Height - newSize.Height) / 2);
            // Draw the form's content onto the page
            graphics.DrawImage(formImage, newPosition.X, newPosition.Y, newSize.Width, newSize.Height);


        }
    }

}