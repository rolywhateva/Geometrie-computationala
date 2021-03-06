﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace AcopeririConvexe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap map;
        int NrPuncte;
        int hullcounter = 0;
        //  List<Point> points = new List<Point>();
        Random rnd = new Random((int)System.DateTime.Now.Ticks);
        int pointWidth = 7;
        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(box.Width, box.Height);
            grp = Graphics.FromImage(map);
            grp.DrawLine(new Pen(Color.Black), 100, 200, 100, 300);
            box.Image = map;

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            NrPuncte = (int)NumericUpNrPuncte.Value;
            if (NrPuncte < 1)
            {
                MessageBox.Show("Puncte insuficiente.");
                return;
            }
            grp.Clear(box.BackColor);
            List<Point> points = new List<Point>();
            // points.Clear();
            Pen pen;
            
            int X=0 , Y=0 ;
            for (int i = 0; i < NrPuncte; i++)
            {
                Point p = nextRandomPoint(points);
               
           
                points.Add(p);
               // pen = new Pen(RandomColor(), pointWidth);
               // grp.DrawEllipse(pen, p.X, p.Y, pointWidth, pointWidth);
               // grp.FillEllipse(new SolidBrush(pen.Color), p.X, p.Y, pointWidth, pointWidth);

            }
            List<Point> CHS = Graham(points.ToArray());
            /*
             for (int i = 0; i < CHS.Count - 1; i++)
             {
                 grp.DrawLine(new Pen(Color.Black), CHS[i], CHS[i + 1]);
             }
             grp.DrawLine(new Pen(Color.HotPink), CHS[0], CHS[CHS.Count - 1]);
             */
            grp.DrawPolygon(new Pen(Color.HotPink), CHS.ToArray());
            grp.FillPolygon(new SolidBrush(Color.HotPink), CHS.ToArray());
            for (int i = 0; i < NrPuncte; i++)
            {
                Point p = points[i];


              //  points.Add(p);

                pen = new Pen(RandomColor(), pointWidth);
                grp.DrawEllipse(pen, p.X, p.Y, pointWidth, pointWidth);
                grp.FillEllipse(new SolidBrush(pen.Color), p.X, p.Y, pointWidth, pointWidth);

            }
            box.Image = map;
            hullcounter++;
            map.Save("hull"+hullcounter+".jpeg", ImageFormat.Jpeg);

        }
        private Point nextRandomPoint(List<Point> points)
        {
            // Random rnd = new Random((int)System.DateTime.Now.Ticks);
            Point p = new Point();
            do
            {
                p.X = rnd.Next(box.Width - pointWidth);
                p.Y = rnd.Next(box.Height - pointWidth);
            } while (points.Contains(p));
            return p;
        }
        private Color RandomColor()
        {
            //  Random rnd = new Random();
            Color toReturn = Color.FromArgb(rnd.Next() % 256, rnd.Next() % 256, rnd.Next() % 256);
            return toReturn;

        }
         public  float Panta(Point A, Point B)
        {
            return (B.Y - (float)A.Y) / (B.X - A.X);
        }
        private float CrossProduct(Point A, Point B)
        {
            return A.X * B.Y - B.X * A.Y;
        }
        private float Direction(Point A, Point B, Point C)
        {
            Point v1 = new Point(B.X - A.X, B.Y - A.Y);
            Point v2 = new Point(C.X - B.X, C.Y - B.Y);
            return CrossProduct(v1, v2);
        }
        private double Distance(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
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
            // points.Remove(points[indexmin]);
            for (int i = 0; i < CHS.Count; i++)
            {
                Point nextPoint = (CHS[i] == points[0]) ? points[1] : points[0];
                for (int j = 0; j < points.Count; j++)
                {
                    float det = Orientare(CHS[i], points[j], nextPoint);
                    if (det > 0 ||( det==0 
                        &&Distance(CHS[i],points[j])>Distance(CHS[i],nextPoint)))
                        nextPoint = points[j];
                }
             
                if (nextPoint != CHS[0])
                    CHS.Add(nextPoint);
            }
            return CHS;
        }
        public void Swap( ref Point a, ref  Point b)
        {
            Point aux = new Point();
            aux = a;
            a = b;
            b = aux;
              
            
        }
        private List<Point> Graham(Point[] points)
        {
         
            int index = 0;
            for (int i = 1; i < points.Length; i++)
                if (points[i].X < points[index].X || 
                    (points[i].X == points[index].X && points[i].Y > points[index].Y))
                    index = i;
            
           Swap(ref  points[0],ref  points[index]);
       
            Sort(points);
            Insert(ref points);
       
        
            int nrPuncte = 2;
            int steps = 0;
            for(int i=3;i<points.Length;i++)
            {
                while (nrPuncte >1 && Orientare(points[nrPuncte - 1], points[nrPuncte], points[i])>=0)
                    nrPuncte--;
                nrPuncte++;
                Swap(ref points[nrPuncte],  ref points[i]);
            }
            Array.Resize(ref points, nrPuncte+1);
            return points.ToList();
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
    }
}
