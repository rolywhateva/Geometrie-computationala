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
        Random rnd = new Random();
        private void Draw_Click(object sender, EventArgs e)
        {
            
            int elipsaWidth = 200;
            int elipsaHeight = 100;
            PointF center = new PointF(0, 0);
            grpObj.DrawEllipse(new Pen(Color.Black),center.X -elipsaWidth/2, center.Y - elipsaHeight/2,elipsaWidth,elipsaHeight);
            grpObj.DrawRectangle(new Pen(Color.Black), center.X - elipsaWidth / 2, center.Y - elipsaHeight / 2, elipsaWidth, elipsaHeight);
            grpObj.DrawEllipse(new Pen(Color.Red), new Rectangle(new Point(0,0), new Size(10,10)));
            grpObj.FillEllipse(new SolidBrush(Color.Red), new Rectangle(new Point(0,0), new Size(10, 10)));
            Box.Image = map;
            PointF rp = new PointF();
        
            double a = elipsaWidth / 2;
            double b = (elipsaHeight * elipsaHeight) / 4;
           double c =(float)Math.Sqrt(elipsaHeight/ (4 * a));
      
            PointF FLeft = new PointF((float)(-c),0);
            PointF FRight = new PointF((float)(c),0);
            grpObj.DrawEllipse(new Pen(Color.Red), new RectangleF(FLeft, new SizeF(3, 3)));
            grpObj.DrawEllipse(new Pen(Color.Red), new RectangleF(FRight, new SizeF(3, 3)));
            grpObj.FillEllipse(new SolidBrush(Color.Red), new RectangleF(FLeft, new SizeF(3, 3)));
            grpObj.FillEllipse(new SolidBrush(Color.Red), new RectangleF(FRight, new SizeF(3, 3)));
            
    float   limity = (int)Math.Sqrt(a * a - c * c);
            int numar;
            List<PointF> points = new List<PointF>();
             
      
            for (int i = 0; i < 100; i++)
            {
                do
                {

                   
                     rp.X = (float)(rnd.Next(-(int)a, (int)a)*rnd.NextDouble());
                     rp.Y = (float)((rnd.Next(-(int)limity/2 , (int)limity/2))*rnd.NextDouble());
                     


                } while (Distanta(FRight,rp)+Distanta(FLeft,rp)-2.0*a>=0|| (rp.X*rp.X)/(a*a)+(rp.Y*rp.Y)/(b*b)-1>=0/*||!validate(points,rp)*/);
                points.Add(rp);
              
                    grpObj.DrawEllipse(new Pen(Color.Blue), new RectangleF(rp, new SizeF(3, 3)));
                    grpObj.FillEllipse(new SolidBrush(Color.Blue), new RectangleF(rp, new SizeF(3, 3)));
                
                }
            /*
            for (int i = 0; i < points.Count; i++)
            {
                rp = points[i];
                if ((rp.X * rp.X) / (a * a) + (rp.Y * rp.Y) / (b * b) >= 1)

                {
                    grpObj.DrawEllipse(new Pen(PictureBox.DefaultBackColor), new RectangleF(rp, new SizeF(3, 3)));
                    grpObj.FillEllipse(new SolidBrush(PictureBox.DefaultBackColor), new RectangleF(rp, new SizeF(3, 3)));
                }
            }
            */
                Box.Image = map;


        }
        private double Distanta(PointF a, PointF b)
        {
            return Math.Sqrt((b.Y - a.Y) * (b.Y - a.Y) + (b.X - a.X) * (b.X - a.X));
        }
        private bool validate(List<PointF> p,PointF a)
        {
            for (int i = 0; i < p.Count; i++)
                if (p[i].Equals(a))
                    return false;
            return true;
        }
        private float RandomFloat()
        {
            try
            {
                byte[] data = new byte[4];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetBytes(data);
                return BitConverter.ToSingle(data, 0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
      
        }
    }
}
