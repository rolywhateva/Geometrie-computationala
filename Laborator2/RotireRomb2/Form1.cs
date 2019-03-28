using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotireRomb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        PointF[] points = new PointF[4];
        int width = 150;
        int height = 250;
        int angle = 45;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);

            PointF p = new PointF(bmp.Width / 2, bmp.Height / 2);

            points[0] = new PointF(p.X, p.Y - height / 2);
            points[1] = new PointF(p.X + width/2, p.Y);
            points[2] = new PointF(p.X-width/2, p.Y);
            points[3] = new PointF(p.X,p.Y+height/2);
            Pen pen = new Pen(Color.Red);
            SolidBrush b = new SolidBrush(Color.Red);
            grp.DrawLine(pen, points[0], points[1]);

            grp.DrawLine(pen, points[0], points[2]);
            grp.DrawLine(pen, points[2], points[3]);
            grp.DrawLine(pen, points[1], points[3]);
            grp.FillPolygon(b, new PointF[] { points[0], points[1], points[2] });
            grp.FillPolygon(b, new PointF[] { points[1], points[2], points[3] });
            pictureBox.Image = bmp;
        }
        public PointF RotatePoint(PointF a, float angle, PointF origin)
        {
            double x, y;
            const double DegToRad = Math.PI / 180;
            x = (a.X - origin.X) * Math.Cos(angle * DegToRad) - (a.Y - origin.Y) * Math.Sin(angle * DegToRad) + origin.X;
            y = (a.X - origin.X) * Math.Sin(angle * DegToRad) + (a.Y - origin.Y) * Math.Cos(angle * DegToRad) + origin.Y;
            return new Point((int)x, (int)y);
        }
        public double Distanta(PointF a, PointF b)
        {
            return Math.Sqrt((b.Y - a.Y) * (b.Y - a.Y) + (b.X - a.X) * (b.X - a.X));
        }
        public bool ContainsPoint(PointF[] points, PointF e)
        {
            PointF origin = new PointF(bmp.Width / 2, bmp.Height / 2);
            return (Distanta(origin, e) <= width &&Distanta(origin,e)<=height);


        }
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PointF position = new PointF(e.X, e.Y);
            if (ContainsPoint(points, e.Location))
            {
                //  MessageBox.Show($"{position.ToString()}");
                grp.Clear(pictureBox.BackColor);
                Pen pen = new Pen(Color.Red);
                SolidBrush b = new SolidBrush(Color.Red);
                Matrix m = new Matrix();
                Random rnd = new Random();
                do
                {
                    pen.Color = Color.FromArgb(rnd.Next() % 255, rnd.Next() % 255, rnd.Next() % 255);
                } while (pen.Color == pictureBox.BackColor || pen.Color == Color.White);

                b.Color = pen.Color;

                grp.TranslateTransform(bmp.Width / 2, bmp.Height / 2);

                m.TransformPoints(points);
                m.RotateAt(10f, new Point(bmp.Width / 2, bmp.Height / 2));
                for (int i = 0; i < points.Length; i++)
                    points[i] = RotatePoint(points[i], 10f, new Point(bmp.Width / 2, bmp.Height / 2));
                angle += 10;
                grp.Transform = m;

                grp.DrawPolygon(pen, points);
                //  grp.FillRectangle(b, new Rectangle(points[0], new Size(300, 300)));
                grp.FillPolygon(b, new PointF[] { points[0], points[1], points[2] });
                grp.FillPolygon(b, new PointF[] { points[1], points[2], points[3] });
                grp.ResetTransform();
                pictureBox.Image = bmp;





            }
        }
    }
}
