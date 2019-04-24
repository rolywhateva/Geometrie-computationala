using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        int n;
        Color pointColor = Color.Black;
        Color lineColor = Color.Black;
        int pointSize = 5;
        Font pointFont = new Font("Verdana", 6, FontStyle.Bold);
        Random rnd = new Random((int)System.DateTime.Now.Ticks);
        Dictionary<Point, string> pointHash;
        List<Point> points = new List<Point>();
        List<Point> t = new List<Point>();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
        }

        private void buttonDesenare_Click(object sender, EventArgs e)
        {
            points = new List<Point>();
            points.Add(new Point(20, 80));
            points.Add(new Point(50, 10));
            points.Add(new Point(110, 50));
            points.Add(new Point(90, 200));
            points.Add(new Point(60, 70));
            points.Add(new Point(35, 110));
            for (int i = 0; i < points.Count; i++)
                t.Add(points[i]);
            pointHash = new Dictionary<Point, string>();
            for (int i = 0; i < points.Count; i++)
                pointHash.Add(points[i], "P" + (i + 1));
            //Triunghiulare(t);
            for (int i = 0; i < points.Count; i++)
            {
                grp.DrawEllipse(new Pen(pointColor), points[i].X, points[i].Y, pointSize, pointSize);
                grp.FillEllipse(new SolidBrush(pointColor), points[i].X, points[i].Y, pointSize, pointSize);
                grp.DrawString(pointHash[points[i]], pointFont, new SolidBrush(pointColor), points[i]);

            }
            grp.DrawPolygon(new Pen(lineColor), points.ToArray());
            /*
            for (int i = 0; i < points.Count - 1; i++)
                grp.DrawLine(new Pen(lineColor), points[i], points[i + 1]);
           grp.DrawLine(new Pen(lineColor), points[0], points[points.Count - 1]);
           */
            pictureBox.Image = bmp;
        }
   
        private  void Triunghiulare(List<Point> t)
        {
            if (t.Count <= 3)
                return;
            int i = 0;
            while (i < t.Count - 3 && !digvalid(t[i], t[i + 2],i))
                i++;
            grp.DrawLine(new Pen(Color.Black), t[i], t[i + 2]);
            t.Remove(t[i + 1]);
            Triunghiulare(t);
        }

        private float Orientare(Point A, Point B, Point C)
        {
            double temp = (B.Y - A.Y) * (C.X - A.X) - (C.Y - A.Y) * (B.X - A.X);
            if (temp < 0)
                return -1;
            else if (temp == 0)
                return 0;
            else
                return 1;
        }
        private bool SeIntersecteaza(Point A, Point B, Point C, Point D)
        {
            return Orientare(A, B, C) != Orientare(A, B, D) && Orientare(C, D, A) != Orientare(C, D, B);
        }
        private bool digvalid(Point point1,  Point point2, int index)
        {

          
            for (int i = 0; i < t.Count - 1; i++)
                if (i != index&&i!=index+1)
                {

                    if (SeIntersecteaza(point1, point2, t[i], t[i + 1]))
                        return false;
                }

            return true;



        }
    }
}
