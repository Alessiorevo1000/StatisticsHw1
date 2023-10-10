using System;
using System.Drawing;
using System.Windows.Forms;

namespace Homework1
{

    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics a = e.Graphics;

            Pen pen = new Pen(Color.Black, 5);

            Brush brush = new SolidBrush(Color.Black);

            int x1_line = (this.Width / 2) - 100;
            int y1_line = 180;
            int x2_line = (this.Width / 2) + 100;
            int y2_line = 180;

            int x_point = (this.Width / 2);
            int y_point = 100;

            int x_circle = this.Width / 2 +200;
            int y_circle = this.Height / 2 - 50;
            int r_circle = 20;

            int x_rectangle = (this.Width / 2) - 350;
            int y_rectangle = 125;
            int width = 200;
            int height = 100;

            //draw rectangle
            a.DrawRectangle(pen, x_rectangle, y_rectangle, width, height);

            //draw line
            a.DrawLine(pen, x1_line, y1_line, x2_line, y2_line);

            //draw circle
            a.DrawEllipse(pen, x_circle - r_circle, y_circle - r_circle, 2 * r_circle, 2 * r_circle);

            //draw point
            a.FillEllipse(brush, x_point - 1, y_point - 1, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
