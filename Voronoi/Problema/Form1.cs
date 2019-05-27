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
        /*
         * A(30,50),B(60,60),C(90,40),D(90,50),E(90,70),F(100,80).
         * */
        Graphics grp;
        Bitmap bmp;
        Point[] pointArray = new Point[] {
            new Point(30,50),
            new Point(60,90),
            new Point(90,40),
            new Point(90,50),
            new Point(90,70),
            new Point(100,80)
        };
        List<Point> points; 
        Color[] colors = new Color[] { Color.Yellow, Color.Green, Color.Goldenrod, Color.HotPink,Color.BlanchedAlmond,Color.MediumSpringGreen};
        string letters = "ABCDEF";
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < pointArray.Length; i++)
                pointArray[i] = new Point(pointArray[i].X * 2, pointArray[i].Y * 2);
            points = new List<Point>(pointArray);
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBox.Width; i++)
                for (int j = 0; j < pictureBox.Height; j++)
                {
                    Point toCheck = new Point(i, j);
                    if (!points.Contains(toCheck))
                    {
                        int minindex = 0, mindistance = SqDistance(toCheck, points[0]);
                        bool granita = false;
                        for (int z = 1; z < points.Count; z++)
                        {
                            int sqdist = SqDistance(toCheck, points[z]);
                            if (sqdist < mindistance)
                            {
                                minindex = z;
                                mindistance = sqdist;
                            }
                            // else
                            //     if (sqdist == mindistance)
                            //    granita = true;
                            //  else
                            //     granita = false;
                        }
                        //    if (!granita)
                        grp.FillEllipse(new SolidBrush(colors[minindex]), toCheck.X, toCheck.Y, 3, 3);
                        //  else
                        //  grp.FillEllipse(new SolidBrush(Color.Black), toCheck.X, toCheck.Y, 3, 3);





                    }

                }
            DrawPoints();
            pictureBox.Image = bmp;
        }
        public int SqDistance(Point A, Point B)
        {
            return (B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X);
        }
        private void DrawPoints()
        {
            for (int i = 0; i < points.Count; i++)
            {
                grp.FillEllipse(new SolidBrush(Color.Black), points[i].X, points[i].Y, 3, 3);
                grp.DrawString(letters[i].ToString(), new Font("Verdana", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[i].X, points[i].Y);
            }
        }

    }
}
