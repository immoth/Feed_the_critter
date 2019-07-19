using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evo_0._1
{
    public partial class Form1 : Form
    {
        public void RandomDrawing()
        {
            int width = 50, height = 50;
            Bitmap bmp = new Bitmap(width, height);
            Random brand = new Random();
            for (int by = 0; by < height; by++)
            {
                for (int bx = 0; bx < width; bx++)
                {
                    int a = brand.Next(256);
                    int r = brand.Next(256);
                    int g = brand.Next(256);
                    int b = brand.Next(256);

                    bmp.SetPixel(bx, by, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox1.Image = bmp;
            pictureBox1.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            this.Width = 550;
            this.Height = 550;

            RandomDrawing();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


        Random rnd = new Random();
        int px = 0;
        int py = 0;
        int rbx = 0;
        int rby = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //moves the imported image picture box
            px += rnd.Next(-1, 2);
            py += rnd.Next(-1, 2);
            if (crit.Left < 10) { px = 5; }
            if (crit.Left > 400) { px = -5; }
            if (crit.Top < 10) { py = 5; }
            if (crit.Top > 420) { py = -5; }
            crit.Left += rnd.Next(-1 + px, 2 + px);
            crit.Top += rnd.Next(-1 + py, 2 + py);

            crith.Left = crit.Left;
            crith.Top = crit.Top;

            //moves the random colored picture box
            //rbx += rnd.Next(-1, 2);
            //rby += rnd.Next(-1, 2);
            //if (pictureBox1.Left < 10) { rbx = 5; }
            //if (pictureBox1.Left > 400) { rbx = -5; }
            //if (pictureBox1.Top < 10) { rby = 5; }
            //if (pictureBox1.Top > 420) { rby = -5; }
            //pictureBox1.Left += rnd.Next(-1 + rbx, 2 + rbx);
            //pictureBox1.Top += rnd.Next(-1 + rby, 2 + rby);
            

            if (Math.Abs(food.Top-crit.Top)<100)
            {
                if(Math.Abs(food.Left-crit.Left)<100)
                {
                    timerF.Enabled = false;
                    food.Visible = false;
                    food.Top = 600;
                    crith.Visible = true;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawRectangle(myPen, 2, 2, 500, 500);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timerF.Enabled = true;
            food.Top = e.Y;
            food.Left = e.X;
        }

        private void timerF_Tick(object sender, EventArgs e)
        {
            if(food.Top < 470)
            {
                food.Visible = true;
                food.Top += 2;
            }
            else
            {
                food.Visible = false;
                food.Top = 600;
            }

            if (Math.Abs(food.Top - pictureBox1.Top) < 10)
            {
                if (Math.Abs(food.Left - pictureBox1.Left) < 100)
                {
                    timerF.Enabled = false;
                    food.Visible = false;
                    food.Top = 600;
                    RandomDrawing();
                }
            }

        }

        private void timerHunger_Tick(object sender, EventArgs e)
        {
            crith.Visible = false;
        }
    }
}
