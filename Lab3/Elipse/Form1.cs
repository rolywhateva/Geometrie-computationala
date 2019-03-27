using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grpObj;
        Bitmap map;
        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(Box.Width, Box.Height);
            grpObj = Graphics.FromImage(map);
            Point center = new Point(this.Width / 2, this.Height / 2);
            grpObj.TranslateTransform(center.X, center.Y);
            Box.Image = map;

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            
            int elipsaWidth = 200;
            int elipsaHeight = 100;
            Point center = new Point(0, 0);
            grpObj.DrawEllipse(new Pen(Color.Black),center.X -elipsaWidth/2, center.Y - elipsaHeight/2,elipsaWidth,elipsaHeight);
            grpObj.DrawEllipse(new Pen(Color.Red), new Rectangle(new Point(0,0), new Size(10,10)));
            grpObj.FillEllipse(new SolidBrush(Color.Red), new Rectangle(new Point(0,0), new Size(10, 10)));
            Box.Image = map;
            Point rp = new Point();
            float b = elipsaHeight * elipsaHeight / 4;
            float a = elipsaWidth;
            int numar;
            Random rnd = new Random();
            List<Point> points = new List<Point>();
            for (int i = 0; i < 100; i++)
            {
                do
                {
                    rp.X = rnd.Next() %(int) a;
                    rp.Y = rnd.Next() % (int)b;
                    numar = rnd.Next() % 2;
                    if (numar % 2 == 0)
                        rp.X = rp.X * (-1);
                    if (numar % 3 == 0)
                        rp.Y = rp.Y * (-1);
                    
                } while ((rp.X * rp.X) / (a * a) + (rp.Y * rp.Y) / (b * b) > 1&&!validate(points,rp));
                points.Add(rp);
                grpObj.DrawEllipse(new Pen(Color.Blue), new Rectangle(rp, new Size(3, 3)));
                grpObj.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(rp, new Size(3, 3)));
            }
                Box.Image = map;


        }
        private double Distanta(Point a, Point b)
        {
            return Math.Sqrt((b.Y - a.Y) * (b.Y - a.Y) + (b.X - a.X) * (b.X - a.X));
        }
        private bool validate(List<Point> p,Point a)
        {
            for (int i = 0; i < p.Count; i++)
                if (Distanta(a, p[i]) <=5)
                    return false;
            return true;
        }
    }
}
