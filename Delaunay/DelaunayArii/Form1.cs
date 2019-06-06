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
        Color[] colors = new Color[] { Color.MediumOrchid, Color.MediumSeaGreen, Color.MidnightBlue, Color.OldLace, Color.OliveDrab };
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            labelArii.Text = "";
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
        public int SqDistance(Point A, Point B)
        {
            return (B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X);
        }
        public int SqDistance(PointF A, PointF B)
        {
            return (int)((B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X));
        }
        private void Voronoi(List<PointF> points, Color[] colors)
        {
            for (int i = 0; i < pictureBox.Width; i++)
                for (int j = 0; j < pictureBox.Height; j++)
                {
                    PointF toCheck = new PointF(i, j);
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
        }
        public void DrawPoints(List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
                grp.FillEllipse(new SolidBrush(Color.Black), points[i].X, points[i].Y, 3, 3);
        }
        public void DrawPoints(List<PointF> points)
        {
            for (int i = 0; i < points.Count; i++)
                grp.FillEllipse(new SolidBrush(Color.Black), points[i].X, points[i].Y, 3, 3);
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {

            grp.Clear(pictureBox.BackColor);
            labelPuncte.Text = "";
            labelArii.Text = "";
            if (count <= 0)
            {
                ZoomAll(this.points, 110f);
                inSide = new PointF(inSide.X * 110, inSide.Y * 110);
                count++;
            }
            List<PointF> points = this.points.ToList<PointF>();
            points.Add(inSide);
            Color[] colors = new Color[points.Count];
            for (int i = 0; i < colors.Length; i++)
                colors[i] = RandomColor();
            DrawPoints(points);
            Voronoi(points, colors);


            PointF[] ex1 = new PointF[] { points[5], points[0], points[4], points[2], points[1], points[3] };
            PointF[] ex2 = new PointF[] { inSide, inSide, inSide, inSide, inSide, inSide };
            List<PointF[]> trigs = new List<PointF[]>();
            trigs.Add(new PointF[] { points[0], points[1], inSide });
            trigs.Add(new PointF[] { points[5], inSide, points[0] });
            trigs.Add(new PointF[] { points[4], points[5], inSide });
            trigs.Add(new PointF[] { points[4], points[3], inSide });
            trigs.Add(new PointF[] { points[1], inSide, points[2] });
            trigs.Add(new PointF[] { points[2], points[3], inSide });
            Dictionary<PointF,string> dic = new Dictionary<PointF,string>();
            for (int i = 0; i < this.points.Length; i++)
                dic.Add(points[i],letters[i].ToString());
            dic.Add(inSide, "G");



            //  FillTrig(trigs);
            for (int i = 0; i < trigs.Count; i++)
                labelArii.Text +=dic[trigs[i][0]]+dic[trigs[i][1]]+dic[trigs[i][2]]+"="+
                                  Arie(trigs[i][0], trigs[i][1], trigs[i][2])+Environment.NewLine;

            NoteazaAll("ABCDEFG");
            grp.DrawString("G", new Font("Verdana", 10, FontStyle.Bold), new SolidBrush(Color.Black), inSide);

            Listeaza();
            labelPuncte.Text += $"G=({inSide.X},{inSide.Y})" + Environment.NewLine;
            grp.DrawPolygon(new Pen(Color.Black), this.points);
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
        
        private double Dist(PointF A, PointF B)
        {
            return Math.Sqrt((B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X));
        }
        private double Arie(PointF A, PointF B,PointF C)
        {
            double p = (Dist(A, B) + Dist(A, C) + Dist(B, C)) / 2;
            double AB = Dist(A, B);
            double AC = Dist(A, C);
            double BC = Dist(B, C);
            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
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
        Random rnd = new Random();
        private Color RandomColor()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

    }

}
