using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triunghiualizare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FIX THIS!!!!!
        /// </summary>
        Graphics grp;
        Bitmap bmp;
        int n;
        Color pointColor = Color.Black;
        Color lineColor = Color.Black;
        int pointSize = 5;
        Font pointFont = new Font("Verdana", 8, FontStyle.Bold);
        Random rnd = new Random((int)System.DateTime.Now.Ticks);
        Dictionary<Point, string> pointHash;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);

        }
        #region Aleator
        List<Point> points;
        private List<Point> GetRandomPoints(int n)
        {
            
            List<Point> list = new List<Point>();
           
       
            for (int i=0;i<n;i++)
            {
                 list.Add(RandomPoint(list));
            }
            //MessageBox.Show("Works!");
            List<Point> toReturn = Jarvis(list);
            if (n == toReturn.Count)
                return toReturn;
            else
                return GetRandomPoints(n);
         
      
            
        }
        private Point RandomPoint(List<Point> list)
        {
            Point toReturn = new Point();
            int nr;
            do
            {
                int x = rnd.Next() % (pictureBox.Width - 12);
                int y = rnd.Next() % (pictureBox.Height - 5);
                toReturn = new Point(x, y);
             
            } while (list.Contains(toReturn));
        

            return toReturn;
        }
    
        private bool SeIntersecteaza(Point A, Point B, Point C, Point D)
        {
            return Orientare(A, B, C) != Orientare(A, B, D) && Orientare(C, D, A) != Orientare(C, D, B);
        }
        #endregion
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox.BackColor);
            pointHash = new Dictionary<Point, string>();
            points = new List<Point>();
            n = int.Parse(textBoxPoints.Text);


            points = GetRandomPoints(n);

            for (int i = 0; i < points.Count; i++)
                pointHash.Add(points[i], "P" + (i + 1));
           
            for(int i=0;i<points.Count;i++)
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
        #region Jarvis

        private double Distance(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
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
        private List<Point> Jarvis(List<Point> points)
        {

            //se afla punctul cu  y minim, daca sunt mai multe puncte cu y min, se ia cea cu x minim.
            int indexmin = 0;
            for (int i = 1; i < points.Count; i++)
                if (points[i].Y < points[indexmin].Y || (points[i].Y == points[indexmin].Y && points[i].X > points[indexmin].X))
                    indexmin = i;
            List<Point> CHS = new List<Point>();
            CHS.Add(points[indexmin]);
            //points.Remove(points[indexmin]);
            for (int i = 0; i < CHS.Count; i++)
            {
                Point nextPoint = (CHS[i] == points[0]) ? points[1] : points[0];
                for (int j = 0; j < points.Count; j++)
                {
                    float det = Orientare(CHS[i], points[j], nextPoint);
                    if (det > 0 || (det == 0
                        && Distance(CHS[i], points[j]) > Distance(CHS[i], nextPoint)))
                        nextPoint = points[j];
                }

                if (nextPoint != CHS[0])
                    CHS.Add(nextPoint);
            }
            return CHS;
        }
        #endregion
      
    }
}
