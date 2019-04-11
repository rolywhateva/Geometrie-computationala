using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        List<Point> points;
        Point[] pointArray;
        Dictionary<Point, string> hash = new Dictionary<Point, string>();
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pB.Width, pB.Height);
            grp = Graphics.FromImage(bmp);
            points = new List<Point>();
            points.Add(new Point(1, 11));
            points.Add(new Point(2, 7));
            points.Add(new Point(3, 8));
            points.Add(new Point(4, 10));
            points.Add(new Point(5, 7));
            points.Add(new Point(7, 11));
            points.Add(new Point(6, 7));
            labelIndic.Visible = false;
            labelPuncte.Visible = false;

        }
        private List<Point> Graham(Point[] points)
        {
            int index = 0;
            for (int i = 1; i < points.Length; i++)
                if (points[i].X < points[index].X ||
                    (points[i].X == points[index].X && points[i].Y > points[index].Y))
                    index = i;

            Swap(ref points[0], ref points[index]);

            Sort(points);
            Insert(ref points);


            int nrPuncte = 2;
            int steps = 0;
            for (int i = 3; i < points.Length; i++)
            {
                while (nrPuncte > 1 && Orientare(points[nrPuncte - 1], points[nrPuncte], points[i]) >= 0)
                    nrPuncte--;
                nrPuncte++;
                Swap(ref points[nrPuncte], ref points[i]);
            }
            Array.Resize(ref points, nrPuncte + 1);
            return points.ToList();
        }
        public void GrahamStep(int i,int nrPuncte)
        {
            for (int j = 0; j < i; j++)
                labelPuncte.Text += hash[pointArray[i]] + " ";
            while (nrPuncte>1&&Orientare(points[nrPuncte-1],points[nrPuncte],points[i])>=0)
            {
                nrPuncte--;
                

            }
            nrPuncte++;

            Swap(ref pointArray[nrPuncte], ref pointArray[i]);

        }
        public void Swap(ref Point a, ref Point b)
        {
            Point aux = new Point();
            aux = a;
            a = b;
            b = aux;


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
        private void Sort(Point[] points)
        {
            for (int i = 1; i < points.Length - 1; i++)
            {
                float pantaiX = points[0].X - points[i].X;
                float pantaiY = points[0].Y - points[i].Y;
                for (int j = i + 1; j < points.Length; j++)
                {
                    float pantajX = points[0].X - points[j].X;
                    float pantajY = points[0].Y - points[j].Y;
                    if (pantaiY * pantajX > pantajY * pantaiX)
                    {
                        Swap(ref points[i], ref points[j]);
                        pantaiX = points[0].X - points[i].X;
                        pantaiY = points[0].Y - points[i].Y;
                    }
                }
            }
        }
        private void Insert(ref Point[] points)
        {
            Array.Resize(ref points, points.Length + 1);

            for (int i = points.Length - 1; i > 0; i--)
                points[i] = points[i - 1];
            points[0] = points[points.Length - 1];
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

          
            for (int i = 0; i < points.Count; i++)
            {
                hash.Add(new Point(points[i].X*30,points[i].Y*30), "P" + (i + 1));
            }
            int pointwidth = 5;
           
            pointArray = points.ToArray();
            for (int i = 0; i < pointArray.Length; i++)
            {
                pointArray[i] = new Point(pointArray[i].X * 30, pointArray[i].Y * 30);
                grp.DrawEllipse(new Pen(Color.Black), pointArray[i].X, pointArray[i].Y, pointwidth, pointwidth);
                grp.FillEllipse(new SolidBrush(Color.Black), pointArray[i].X, pointArray[i].Y, pointwidth, pointwidth);
                grp.DrawString("P" + (i + 1), new Font(FontFamily.GenericMonospace,10, FontStyle.Bold), new SolidBrush(Color.Black), pointArray[i]);
            }
            index = 0;
            for (int i = 1; i < pointArray.Length; i++)
                if (pointArray[i].X < pointArray[index].X ||
                    (pointArray[i].X == pointArray[index].X && pointArray[i].Y > pointArray[index].Y))
                    index = i;

            Sort(pointArray);
            Insert(ref pointArray);
            labelIndic.Visible = true;
            labelPuncte.Visible = true;
            labelPuncte.Text = "";

            for (int i = 0; i <= 2; i++)
                labelPuncte.Text += hash[pointArray[i]] + " ";
            for (int i = 0; i < 2; i++)
                grp.DrawLine(new Pen(Color.Black), pointArray[i], pointArray[i + 1]);
           


          

            /*
            List<Point> CHS = Graham(points.ToArray());
            Point[] CHSArray = CHS.ToArray();
           grp.DrawPolygon(new Pen(Color.Black), CHSArray);
            //grp.FillPolygon(new SolidBrush(Color.BlanchedAlmond), CHSArray);

            for (int i = 0; i < points.Count; i++)
            {
               // points[i] = new Point(points[i].X * 10, points[i].Y * 10);
                grp.DrawEllipse(new Pen(Color.Black), points[i].X, points[i].Y, pointwidth, pointwidth);
                grp.FillEllipse(new SolidBrush(Color.Black), points[i].X, points[i].Y, pointwidth, pointwidth);

            }
            */

            pB.Image = bmp;

        }
    }
}
