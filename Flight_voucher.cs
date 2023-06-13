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
    public partial class Flight_voucher : Form
    {
        public Flight_voucher()
        {
            InitializeComponent();
        }
        public void setvalue(string passenger_name,string departure,string arrival,string date,string seat_no,string time,string board_time)
        {
            label16.Text = passenger_name;
            label17.Text = departure;
            label18.Text = arrival;
            label19.Text = date;
            label20.Text = seat_no;
            label21.Text = time;
            label22.Text = board_time;

            label23.Text = passenger_name;
            label24.Text = departure;
            label25.Text = arrival;
            label26.Text = date;
            label27.Text = time;
            label28.Text = seat_no;
        }
        private void Flight_voucher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Panel panel1 = new Panel();
            this.Controls.Add(panel1);
            Graphics grp = panel1.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel1.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, -20,-15);
        }
    }
}
