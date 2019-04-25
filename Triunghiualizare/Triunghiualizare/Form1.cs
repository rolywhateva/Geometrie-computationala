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
        Dictionary<Point, string> pointHash = new Dictionary<Point, string>();
        List<Point> t = new List<Point>();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);

        }
        #region Aleator
        List<Point> points = new List<Point>();
        private List<Point> GetRandomPoints(int n, int ct)
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
               if (ct < 10000)
            {
                list.Clear();
                return GetRandomPoints(n, ct + 1);
            }
            else
                return toReturn;
         
           
        
        }
        private Point RandomPoint(List<Point> list)
        {
            Point toReturn = new Point();
            try
            {
              
                int nr;
                do
                {

                    int x = rnd.Next() % (pictureBox.Width - 12);
                    int y = rnd.Next() % (pictureBox.Height - 5);
                    toReturn.X = x;
                    toReturn.Y = y;

                } while (list.Contains(toReturn));

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        

            return toReturn;
        }
    
        private bool SeIntersecteaza1(Point A, Point B, Point C, Point D)
        {
            return Orientare(A, B, C) != Orientare(A, B, D) && Orientare(C, D, A) != Orientare(C, D, B);
        }
        #endregion
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            GC.Collect();
            grp.Clear(pictureBox.BackColor);
            pointHash.Clear(); 
            points.Clear();
            t.Clear(); 
            n = int.Parse(textBoxPoints.Text);


            points = GetRandomPoints(n,0);

            for (int i = 0; i < points.Count; i++)
                pointHash.Add(points[i], "P" + (i + 1));
           
            for(int i=0;i<points.Count;i++)
            {
                grp.DrawEllipse(new Pen(pointColor), points[i].X, points[i].Y, pointSize, pointSize);
                grp.FillEllipse(new SolidBrush(pointColor), points[i].X, points[i].Y, pointSize, pointSize);
                grp.DrawString(pointHash[points[i]], pointFont, new SolidBrush(pointColor), points[i]);

            }
            for (int i = 0; i < points.Count; i++)
                t.Add(points[i]);
            Triunghiulare(t);
            grp.DrawPolygon(new Pen(lineColor), points.ToArray());
          
            /*
            for (int i = 0; i < points.Count - 1; i++)
                grp.DrawLine(new Pen(lineColor), points[i], points[i + 1]);
           grp.DrawLine(new Pen(lineColor), points[0], points[points.Count - 1]);
           */
            pictureBox.Image = bmp;

        }
   
        private void ButtonDesenare_Click(object sender, EventArgs e)
        {

            grp.Clear(pictureBox.BackColor);
            pictureBox.Image = bmp;
            t.Clear();

            for (int i = 0; i < points.Count; i++)
            {

                t.Add(points[i]);

            }
            t.Add(points[0]);
            pointHash = new Dictionary<Point, string>();
            for (int i = 0; i < points.Count; i++)
                pointHash.Add(points[i], "P" + (i + 1));
            /*
            grp.DrawLine(new Pen(Color.Black), points[0], points[4]);
            grp.DrawLine(new Pen(Color.Black), points[4], points[2]);
            grp.DrawLine(new Pen(Color.Black), points[1], points[4]);
            */
            Triunghiulare(t);
            for (int i = 0; i < points.Count; i++)
            {
                grp.DrawEllipse(new Pen(pointColor), points[i].X, points[i].Y, pointSize, pointSize);
                grp.FillEllipse(new SolidBrush(pointColor), points[i].X, points[i].Y, pointSize, pointSize);
                grp.DrawString(pointHash[points[i]], pointFont, new SolidBrush(pointColor), points[i]);

            }

            grp.DrawPolygon(new Pen(lineColor), points.ToArray());
            pictureBox.Image = bmp;

        }
        private void Triunghiulare(List<Point> t)
        {
            if (t.Count <= 3)
                return;
            int i = 0;
            while (i < t.Count - 3 && !digvalid(t[i], t[i + 2], i))
                i++;
            grp.DrawLine(new Pen(Color.Red), t[i], t[i + 2]);
            t.Remove(t[i + 1]);
            Triunghiulare(t);
        }
        private int Orientare2(Point A, Point B, Point C)
        {
            double temp = (B.Y - A.Y) * (C.X - A.X) - (C.Y - A.Y) * (B.X - A.X);
            if (temp == 0) return 0;  // colinear 
            return (temp > 0) ? 1 : 2; // clock or counterclock wise
        }
        /*
        private bool SeIntersecteaza(Point A, Point B, Point C, Point D)
        {
            int o1 = rientation(p1, q1, p2);
            int o2 = orientation(p1, q1, q2);
            int o3 = orientation(p2, q2, p1);
            int o4 = orientation(p2, q2, q1);
            if (Orientare(A, B, C) != Orientare(A, B, D) && Orientare(C, D, A) != Orientare(C, D, B))
                return true;

        }
        */
        bool SeIntersecteaza(Point p1, Point q1, Point p2, Point q2)
        {
            // Find the four orientations needed for general and 
            // special cases 
            int o1 = Orientare2(p1, q1, p2);
            int o2 = Orientare2(p1, q1, q2);
            int o3 = Orientare2(p2, q2, p1);
            int o4 = Orientare2(p2, q2, q1);
          
            // General case 
            if (o1 != o2 && o3 != o4)
                return true;

            // Special Cases 
            // p1, q1 and p2 are colinear and p2 lies on segment p1q1 
            if (o1 == 0 && onSegment(p1, p2, q1)) return true;

            // p1, q1 and p2 are colinear and q2 lies on segment p1q1 
            if (o2 == 0 && onSegment(p1, q2, q1)) return true;

            // p2, q2 and p1 are colinear and p1 lies on segment p2q2 
            if (o3 == 0 && onSegment(p2, p1, q2)) return true;

            // p2, q2 and q1 are colinear and q1 lies on segment p2q2 
            if (o4 == 0 && onSegment(p2, q1, q2)) return true;

            return false; // Doesn't fall in any of the above cases 
        }
        private bool digvalid(Point point1, Point point2, int index)
        {

            Point M = new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
            if (index == t.Count - 1)
                index = 0;
            for (int i = 0; i < t.Count - 1; i++)


            {

                if (SeIntersecteaza(point1, point2, t[i], t[i + 1]) ||!isInside(t, M))
                    return false;
            }


            return true;


        }

        #region In poligon
        bool onSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                    q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;
            return false;
        }
        bool isInside(List<Point> t, Point p)
        {
            if (t.Count < 3)
                return false;
            Point extreme = new Point(3000, p.Y);
            int count = 0, i = 0;
            do
            {
                int next = (i + 1) % t.Count;

                // Check if the line segment from 'p' to 'extreme' intersects 
                // with the line segment from 'polygon[i]' to 'polygon[next]' 
                if (SeIntersecteaza(t[i], t[next], p, extreme))
                {
                    // If the point 'p' is colinear with line segment 'i-next', 
                    // then check if it lies on segment. If it lies, return true, 
                    // otherwise false 
                    if (Orientare(t[i], p, t[next]) == 0)
                        return onSegment(t[i], p, t[next]);

                    count++;
                }
                i = next;
            } while (i != 0);

            return (count % 2 == 1);
        }

        #endregion
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
