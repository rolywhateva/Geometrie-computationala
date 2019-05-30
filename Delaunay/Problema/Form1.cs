using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        Point[] points = new Point[] { new Point(3, 5), new Point(6, 6), new Point(6, 4), new Point(9, 5), new Point(9, 7) };
        Color[] colors = new Color[] { Color.HotPink, Color.MediumBlue, Color.Yellow, Color.IndianRed, Color.Purple };
        string letters = "ABCDE";
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
         
            Scale(40);
         
            
        }
        public void DrawPoints()
        {
            for (int i = 0; i < points.Length; i++)
                grp.FillEllipse(new SolidBrush(Color.Black), points[i].X, points[i].Y, 3, 3);
        }
        public  void Scale(int val)
        {
            for (int i = 0; i < points.Length; i++)
            {

                points[i] = new Point(points[i].X * val, points[i].Y * val);
               // MessageBox.Show(points[i].ToString());
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            
            Voronoi();
            Noteaza();
          
            DrawPoints();
            DrawTrig();
         
            pictureBox.Image = bmp;
        }
        private void DrawMuchie(PointF A, PointF B)
        {
            grp.DrawLine(new Pen(Color.Black), A, B);
        }
        private void DrawTrig()
        {
            PointF[] ex1 = {points[0],points[0],points[1],points[4],points[2],points[2],points[3]};
            PointF[] ex2 = {points[1],points[2],points[4],points[3],points[3],points[1],points[1]};
            for (int i = 0; i < ex1.Length; i++)
                DrawMuchie(ex1[i], ex2[i]);
        }
        private void DrawPoly()
        {
            for (int i = 0; i < points.Length - 1; i++)
                grp.DrawLine(new Pen(Color.Black), points[i], points[i + 1]);
            grp.DrawLine(new Pen(Color.Black),points[0], points[points.Length - 1]);
        }
        private void Voronoi()
        {
            for (int i = 0; i < pictureBox.Width; i++)
                for (int j = 0; j < pictureBox.Height; j++)
                {
                    Point toCheck = new Point(i, j);
                    if (!points.Contains(toCheck))
                    {
                        int minindex = 0, mindistance = SqDistance(toCheck, points[0]);
                        bool granita = false;
                        for (int z = 1; z < points.Length; z++)
                        {
                            int sqdist = SqDistance(toCheck, points[z]);
                            if (sqdist < mindistance)
                            {
                                minindex = z;
                                mindistance = sqdist;
                            }
                            else
                                 if (sqdist == mindistance)
                                granita = true;
                            else
                                granita = false;
                        }
                        if (!granita)
                            grp.FillEllipse(new SolidBrush(colors[minindex]), toCheck.X, toCheck.Y, 3, 3);
                       // else
                         //   grp.FillEllipse(new SolidBrush(Color.Black), toCheck.X, toCheck.Y, 3, 3);





                    }

                }
        }
        public int SqDistance(Point A, Point B)
        {
            return (B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X);
        }
        public void Noteaza()
        {
            for (int i = 0; i < points.Length; i++)
                grp.DrawString(letters[i].ToString(), new Font("Verdana", 16, FontStyle.Bold), new SolidBrush(Color.Black), points[i]);
        }

    }
}
