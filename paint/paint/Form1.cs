using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Maximum = 100;
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gh = pictureBox1.CreateGraphics();
            Pen p = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Green);
            Pen p3 = new Pen(Color.Blue);
            Pen p4 = new Pen(Color.DarkMagenta);

            gh.DrawLine(p,10,10,100,100);
            Random r = new Random();
            int korx = r.Next(10, 150);
            int kory = r.Next(10, 150);
            

            gh.DrawEllipse(p2,korx,kory,40,30);
            gh.DrawRectangle(p3, kory, korx,100,40);
            gh.DrawLine(p4,kory, korx, 160, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gh = pictureBox1.CreateGraphics();
            gh.Clear(Color.Wheat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gh = pictureBox1.CreateGraphics();
            Brush br = new SolidBrush(Color.Red);
            Brush br2 = new SolidBrush(Color.DarkMagenta);
            Brush br3 = new SolidBrush(Color.DarkOrange);
            Brush br4 = new SolidBrush(Color.DarkCyan);

            gh.FillRectangle(br,20,20,120,120);
            gh.FillEllipse(br2, 30, 30, 130, 130);
            gh.FillRectangle(br3, 60, 60, 150, 110);
            gh.FillEllipse(br4, 80, 80, 190, 130);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            egergomb = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(egergomb)
            {
                Graphics gh = pictureBox1.CreateGraphics();
                Pen p2 = new Pen (colorDialog1.Color);
                int x = e.X;
                int y = e.Y;
                gh.DrawEllipse(p2, x, y, trackBar1.Value, trackBar2.Value);

            }
        }

        bool egergomb = false;

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            egergomb = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
