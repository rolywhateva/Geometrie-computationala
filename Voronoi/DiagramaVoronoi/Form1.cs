using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramaVoronoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        List<Point> points = new List<Point>();
        List<Color> colors = new List<Color>();
        int pointCount;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            points = new List<Point>();
        }
    
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            points.Clear();
            colors.Clear();
           // grp.Clear(Color.White);
            try
            {
                pointCount = int.Parse(textBoxNrPuncte.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            loadPoints();
          //  MessageBox.Show(string.Join("", points.ToArray()));
            loadColors();
          //  MessageBox.Show(string.Join("", colors.ToArray()));
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
                            else
                                 if (sqdist == mindistance)
                                granita = true;
                            else
                                granita = false;
                        }
                        if(!granita)
                             grp.FillEllipse(new SolidBrush(colors[minindex]), toCheck.X,toCheck.Y, 3, 3);
                        else
                            grp.FillEllipse(new SolidBrush(Color.Black), toCheck.X, toCheck.Y, 3, 3);




                    
                    }
                   
                }
            DrawPoints();
            pictureBox.Image = bmp;

        }
        #region load points,load colors, and random stuff 
        private  void  loadPoints()
        {
            for (int i = 0; i < pointCount; i++)
                points.Add(getRandomPoint());

        }
        private Point  getRandomPoint()
        {
            Point toReturn = new Point();

            do
            {
                toReturn.X = rnd.Next() % bmp.Width;
                toReturn.Y = rnd.Next() % bmp.Height;
            } while (points.Contains(toReturn));
            return toReturn;
        }
        private  void  loadColors()
        {
            for (int i = 0; i < pointCount; i++)
                colors.Add(getRandomColor());

        }
        private Color getRandomColor()
        {
            Color toReturn = new Color();
            do
            {
                toReturn = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            } while (colors.Contains(toReturn)||toReturn==Color.Black);
            return toReturn;
        }
        #endregion
        public int SqDistance(Point A, Point B)
        {
            return (B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X);
        }
        private void DrawPoints()
        {
            for(int i=0;i<points.Count;i++)
            {
                grp.FillEllipse(new SolidBrush(Color.Black), points[i].X, points[i].Y, 5, 5);
               // grp.DrawString("P" + i.ToString(), new Font("Verdana", 8, FontStyle.Regular), new SolidBrush(Color.Black), points[i].X, points[i].Y);
            }
        }

    }
}
