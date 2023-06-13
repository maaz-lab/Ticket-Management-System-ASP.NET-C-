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
    public partial class Form6 : Form
    {
        public string passenger_name { get; set; }
        public Form6()
        {
            InitializeComponent();
        }
        public void setvalues(string passenger_name,string from,string to,DateTime Departure_date,int ticket_id)
        {
            
            label12.Text = from;
            label13.Text = to;
            label14.Text = Convert.ToString(Departure_date);
            label18.Text = Convert.ToString(ticket_id);
            label11.Text = passenger_name;
            label19.Text = passenger_name;
            label20.Text = from;
            label21.Text = to;
            label22.Text = Convert.ToString(Departure_date);
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
            e.Graphics.DrawImage(bitmap, -10, -15);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
