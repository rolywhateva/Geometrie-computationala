using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator10
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
        Dictionary<Point, string> dic = new Dictionary<Point, String>();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            grp.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
           // grp.DrawLine(new Pen(Color.Black), 30, 40, 50, 60);
        }
        public Point  SymetricOx(Point p)
        {
            Point M = new Point(p.X, 0);
            int sY = p.Y * (-1);
            int sX = p.X;
            return new Point(sX, sY);

        }
        public void DrawCircle(Point p)
        {
            int radius = 3;
            Color color = Color.Red;
            grp.DrawEllipse(new Pen(color), p.X, p.Y, radius, radius);
            grp.FillEllipse(new SolidBrush(color), p.X, p.Y, radius, radius);
        }
        public void Noteaza()
        {
            Font font = new Font("Georgia", 10, FontStyle.Regular);
            for (int i = 0; i < points.Count; i++)
                grp.DrawString(dic[points[i]], font, new SolidBrush(Color.Black), points[i]);
        }
        private void butonDraw_Click(object sender, EventArgs e)
        {
            points.Clear(); dic.Clear();
            points.Add(new Point(40, 40));
            points.Add(new Point(50, 60));
            points.Add(new Point(60, 40));
            points.Add(new Point(70, 40));
            points.Add(new Point(90, 60));
            points.Add(new Point(110, 60));

            for (int i = 5; i >=0; i--)
                points.Add(SymetricOx(points[i]));
            for (int i = 0; i < points.Count; i++)
                dic.Add(points[i], "P" + (i + 1));

            /*
            points.Add(SymetricOx(points[0]));
            points.Add(SymetricOx(points[1]));
            points.Add(SymetricOx(points[2]));
            points.Add(SymetricOx(points[3]));
            points.Add(SymetricOx(points[4]));
            points.Add(SymetricOx(points[5]));
            */
            Point[] pointArray = points.ToArray();
            grp.DrawPolygon(new Pen(Color.Black), pointArray);

            //Noteaza();
                
            DrawCircle(points[1]);
            DrawCircle(points[5]);
            pictureBox.Image = bmp;




        }
    }
}
