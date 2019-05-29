using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelaunayArii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        string letters = "ABCDEFG";

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            labelPuncte.Text = "";
        }
        public void ReDraw()
        {
            pictureBox.Image = bmp;
        }
        PointF[] points = new PointF[] {
            new PointF(2.6f,2.4f),
            new PointF(4f,2f),
            new PointF(4f,1f),
            new PointF(2.5f,0.5f),
            new PointF(1.5f,1f),
            new PointF(1.5f,2f)

        };
        PointF inSide = new PointF(2.6f, 1.6f);
        public void ZoomAll(PointF[] points, float val)
        {
            for (int i = 0; i < points.Length; i++)
                points[i] = Zoom(points[i], val);

        }
        public PointF Zoom(PointF point, float val)
        {
            return new PointF(point.X * val, point.Y * val);
        }
        int count = 0;

        private void buttonDraw_Click(object sender, EventArgs e)
        {

            grp.Clear(pictureBox.BackColor);
            labelPuncte.Text = "";
            if (count <= 0)
            {
                ZoomAll(points, 110f);
                inSide = new PointF(inSide.X * 110, inSide.Y * 110);
                count++;
            }




            PointF[] ex1 = new PointF[] { points[5], points[5], points[5], points[1], points[1], points[3] };
            PointF[] ex2 = new PointF[] { inSide, points[1], points[3], inSide, points[3], inSide };
            List<PointF[]> trigs = new List<PointF[]>();
            trigs.Add(new PointF[] { points[0], points[1], points[5] });
            trigs.Add(new PointF[] { points[5], inSide, points[1] });
            trigs.Add(new PointF[] { points[5], points[3], inSide });
            trigs.Add(new PointF[] { points[5], points[4], points[3] });
            trigs.Add(new PointF[] { points[1], inSide, points[3] });
            trigs.Add(new PointF[] { points[1], points[2], points[3] });

          //  FillTrig(trigs);
            NoteazaAll("ABCDEFG");
            grp.DrawString("G", new Font("Verdana", 10, FontStyle.Bold), new SolidBrush(Color.Black), inSide);

            Listeaza();
            labelPuncte.Text += $"G=({inSide.X},{inSide.Y})" + Environment.NewLine;
            grp.DrawPolygon(new Pen(Color.Black), points);
            DrawTrig(ex1, ex2, new Pen(Color.Black));
            ReDraw();

        }
        private void NoteazaAll(string letters)
        {
            for (int i = 0; i < points.Length; i++)
                grp.DrawString(letters[i].ToString(), new Font("Verdana", 10, FontStyle.Bold), new SolidBrush(Color.Black), points[i]);


        }

        private void Listeaza()
        {
            for (int i = 0; i < points.Length; i++)
                labelPuncte.Text += $"{letters[i]}=({points[i].X},{points[i].Y})" + Environment.NewLine;


        }
        private void DrawMuchie(PointF A, PointF B, Pen P)
        {
            grp.DrawLine(P, A, B);
        }


        private void DrawTrig(PointF[] ex1, PointF[] ex2, Pen p)
        {
            for (int i = 0; i < ex1.Length; i++)
                DrawMuchie(ex1[i], ex2[i], p);
        }
      //  private void FillTrig(List<PointF[]> trigs)
       // {
       //     for (int i = 0; i < trigs.Count; i++)
               // grp.FillPolygon(new SolidBrush(RandomColor()), trigs[i]);
        //}
       // private Color RandomColor()
       // {
       //   //  return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
       // }

    }

}
