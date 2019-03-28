using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triunghi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        PointF p1, p2, p3;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            grp.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
            DrawTriunghi();
           
          
           grp.ResetTransform();
            pictureBox.Image = bmp;

        }
        private void DrawTriunghi()
        {
            do
            {
                p1 = RandomPoint();
                p2 = RandomPoint();
                p3 = RandomPoint();
            } while (Coliniare(p1, p2, p3));
            grp.DrawPolygon(new Pen(Color.Black), new PointF[] { p1, p2, p3 });
            pictureBox.Image = bmp;

        }
        private PointF Mijloc(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
        private bool Coliniare(PointF p1, PointF p2, PointF p3)
        {
            return p1.X * p2.Y + p2.X * p3.Y + p3.X * p1.Y - p3.X * p2.Y - p1.X * p3.Y - p2.X * p1.Y == 0;
        }

        private  PointF RandomPoint()
        {
          
            return new PointF(rnd.Next(-pictureBox.Width/2,pictureBox.Width/2), rnd.Next(-pictureBox.Height/2,pictureBox.Height/2));
        }
    }
}
