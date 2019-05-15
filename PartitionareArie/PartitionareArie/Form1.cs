using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartitionareArie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        List<Point> points=new List<Point>();
        List<Point> scaledpoints=new List<Point>();
        Point P;
        Dictionary<Point, string> hash  = new Dictionary<Point, string>();
        string chars = "ZXCVBNMASDFGHJKLQWERTYUIO";

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(PictureBox.Width, PictureBox.Height);
            grp = Graphics.FromImage(bmp);
            grp.TranslateTransform(PictureBox.Width / 2, PictureBox.Height / 2);
        }
        private void FormeazaLista()
        {
            /*
            points.Add(new Point(43, 107));
            points.Add(new Point(0, 100));
            points.Add(new Point(-27, 87));
            points.Add(new Point(-49, 70));
            points.Add(new Point(-67, 37));
            points.Add(new Point(-52, -7));
            points.Add(new Point(-20, 0));
            points.Add(new Point(0, 11));
            points.Add(new Point(26, 28));
            points.Add(new Point(48, 60));
            */
            points.Add(new Point(40, 220));
            points.Add(new Point(180, 80));
            points.Add(new Point(310, 160));
            points.Add(new Point(510, 40));
           
            points.Add(new Point(640, 320));
            points.Add(new Point(490, 240));
            points.Add(new Point(290, 310));
            labelPuncte.Text = "";
            for(int i=0;i<points.Count;i++)
            {
              labelPuncte.Text+= $"{chars[i]}=({points[i].X},{points[i].Y})\n";
              scaledpoints.Add(new Point(points[i].X*2/3, points[i].Y*2/3));

            }
           
        }
        private void Map()
        {
           
            for (int i = 0; i < scaledpoints.Count; i++)
            {
               
                hash.Add(scaledpoints[i], chars[i].ToString());
            }
        }
        private void Noteaza(Color color,Font font)
        {
            SolidBrush brush = new SolidBrush(color);
            for (int i = 0; i < scaledpoints.Count; i++)
                grp.DrawString(hash[scaledpoints[i]], font, brush, scaledpoints[i]);
        }
        private void DrawPunctInterior(Color color)
        {
            int raza = 3;
            grp.DrawEllipse(new Pen(color), P.X, P.Y, raza, raza);
            grp.FillEllipse(new SolidBrush(color), P.X, P.Y, raza, raza);

        }
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            points.Clear();
            scaledpoints.Clear();
            hash.Clear();
         
            FormeazaLista();
            P =new Point(0, 0);
            Map();
            Point[] pointArray = scaledpoints.ToArray();
           
            grp.DrawPolygon(new Pen(Color.Black), pointArray);
            Noteaza(Color.Black, new Font("Comic Sans",9, FontStyle.Regular));
            DrawPunctInterior(Color.Red);
            grp.DrawString("(0,0)", new Font("Comic Sans", 9, FontStyle.Regular), new SolidBrush(Color.Black), new Point(0,0));
            labelArie.Text = "Arie este  de : " + Arie().ToString();

            PictureBox.Image = bmp;
          
        

        }
        private int Arie()
        {
            points.Add(points[0]);
            int s = 0;
            for (int i = 0; i < points.Count-1; i++)
                s = s + points[i].X * points[i + 1].Y - points[i + 1].X * points[i].Y;
            return s / 2;


        }

    }
}
