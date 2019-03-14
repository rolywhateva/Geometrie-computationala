using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Laborator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        RNGCryptoServiceProvider provider;
        public float RandomFloat()
        {
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);
            return  BitConverter.ToSingle(byteArray, 0);
        }
        public  int  RandomInt()
        {
            var byteArray = new byte[4];
            provider.GetBytes(byteArray);
            return Math.Abs(BitConverter.ToInt32(byteArray, 0));
        }
        public double Distanta(PointF a, PointF b)
        {
            return Math.Sqrt((b.Y - a.Y) * (b.Y - a.Y) + (b.X - a.X) * (b.X - a.X));
        }
        public bool Triunghi(PointF[] p)
        {
            double AB = Distanta(p[0], p[1]);
            double BC = Distanta(p[1], p[2]);
            double AC = Distanta(p[0], p[2]);
            return AB + AC > AC && AB + AC > BC && BC + AC > AB;

        }
        /*
        public bool Accept(List<Point> l )
        {

        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Box.Width, Box.Height);
            grp = Graphics.FromImage(bmp);
            // grp.DrawLine(new Pen(Color.Black), 30, 40, 50, 60);
            Random rnd = new Random();
            Color culoare;
            Pen p;
            provider = new RNGCryptoServiceProvider();
            List<PointF> l = new List<PointF>();
            List<Color> c = new List<Color>();
            for (int i=0;i<8;i++)
            {
                PointF[] points = new PointF[3];
             
                do {
                    PointF[] aux = points;
                    for (int j = 0; j < 3; j++)
                    {
                        do
                        {
                           points[j] = new PointF((float)(rnd.NextDouble() * 1000%Box.Width), (float)(rnd.NextDouble() * 1000%Box.Height));
                          //  points[j] = new PointF(Math.Abs(RandomFloat() % Box.Width), Math.Abs(RandomFloat() % Box.Height));
                        } while (l.Contains(points[j]));
                          
                        l.Add(points[j]);
                    }
                    }while (!Triunghi(points));
                do {
                    culoare = Color.FromArgb(RandomInt() % 255, RandomInt() % 255, RandomInt() % 255);
                } while (c.Contains(culoare));
                    p = new Pen(culoare, 5);
                grp.DrawLine(p, points[0], points[1]);
               
                grp.DrawLine(p, points[1], points[2]);
                grp.DrawLine(p, points[2], points[0]);
              grp.FillPolygon(new SolidBrush(p.Color), points);
                
            }

            Box.Image = bmp;

        }
    }
}
