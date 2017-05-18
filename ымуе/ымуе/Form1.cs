using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ымуе
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        static Color color1;
        static Color color2;
        static Color color3;
        
        private void ChangeSvet()
        {
           
                color1 = Color.Red;
                color2 = Color.Black;
                color3 = Color.Black;
              /*  color1 = Color.Black;
                color2 = Color.Yellow;
                color3 = Color.Black;
                Thread.Sleep(200);
                Refresh();
                color1 = Color.Black;
                color2 = Color.Black;
                color3 = Color.Green;
                Thread.Sleep(200);
                Refresh();*/
            }
        

        Pen p1 = new Pen(Color.Red);
        Pen p2 = new Pen(Color.Gray);
        Pen p3 = new Pen(Color.Yellow);
        Pen p4 = new Pen(Color.Green);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            while (true)
            {

               /* color1 = Color.Red;
                color2 = Color.Black;
                color3 = Color.Black;*/
                e.Graphics.FillEllipse(p1.Brush, 200, 80, 70, 70);
                e.Graphics.DrawEllipse(p2, 200, 160, 70, 70);
                e.Graphics.DrawEllipse(p2, 200, 240, 70, 70);
                Thread.Sleep(2000);
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawEllipse(p2, 200, 80, 70, 70);
                e.Graphics.FillEllipse(p3.Brush, 200, 160, 70, 70);
                e.Graphics.DrawEllipse(p2, 200, 240, 70, 70);
                Thread.Sleep(2000);
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawEllipse(p2, 200, 80, 70, 70);
                e.Graphics.DrawEllipse(p2, 200, 160, 70, 70);
                e.Graphics.FillEllipse(p4.Brush, 200, 240, 70, 70);
                Thread.Sleep(2000);
                e.Graphics.Clear(Color.Black);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
