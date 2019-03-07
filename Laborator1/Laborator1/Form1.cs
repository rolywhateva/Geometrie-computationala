using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap map;
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTriunghi.Visible = false;
            labelColiniare.Visible = false;
            map = new Bitmap(box.Width, box.Height);
            grp = Graphics.FromImage(map);
          //  grp.DrawLine(new Pen(Color.Pink), 30, 40, 100, 200);
           // box.Image = map;

        }
        private bool coliniare(PointF A, PointF B,PointF C)
        {
            float det = A.X * B.Y + B.X * C.Y + C.X * A.Y - 
                        (C.X * B.Y + A.X * C.Y + B.X * A.Y);
            return det == 0;
        }
        private  float  distanta(PointF A,PointF B)
        {
            return (float)Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }
        private void DrawPoint(Pen pen,  PointF p,int width)
        {
            grp.DrawEllipse(pen, p.X,p.Y, width, width);
            SolidBrush sb = new SolidBrush(pen.Color);
            grp.FillEllipse(sb, p.X, p.Y, width, width);
            box.Image = map;
        }
        private  void DrawTriunghi(Pen pen,int width ,params PointF[] p)
        {
            grp.DrawPolygon(pen, p);
            SolidBrush sb = new SolidBrush(pen.Color);
            grp.FillPolygon(sb, p);
            box.Image = map;
        }
        private void ButonExecuta_Click(object sender, EventArgs e)
        {
            PointF A = new PointF();
            PointF B = new PointF();
            PointF C = new PointF();
            A.X = float.Parse(textBoxXA.Text);
            A.Y = float.Parse(textBoxYA.Text);
            B.X = float.Parse(textBoxXB.Text);
            B.Y = float.Parse(textBoxYB.Text);
            C.X = float.Parse(textBoxXC.Text);
            C.Y = float.Parse(textBoxYc.Text);
            bool col = coliniare(A, B, C);
            labelColiniare.Visible = true;
            Pen p = new Pen(Color.Pink);
            int width = 6;
            grp.Clear(box.BackColor);
            DrawPoint(p, A, width);
            DrawPoint(p, B, width);
            DrawPoint(p, C, width);





            if (col)
            {

                labelColiniare.Text = string.Format("Punctele {0},{1},{2} sunt coliniare", A, B, C);
            }else
            {
                p.Color = Color.Red;

                DrawTriunghi(p, width, A,B,C);
                labelColiniare.Text = string.Format("Punctele {0},{1},{2}nu sunt coliniare", A, B, C);

                float AB = distanta(A, B);
                float BC = distanta(B, C);
                float AC = distanta(A, C);
                if (AB == BC && BC == AC)
                {
                    labelTriunghi.Visible = true;
                    labelTriunghi.Text = "Triunghiul este echilateral";
                }
                else
                {

                    labelTriunghi.Visible = true;
                    if (AB == BC || BC == AC || AB == AC)

                        labelTriunghi.Text = string.Format("Triunghiul format din punctele {0},{1},{2} este  isoscel", A, B, C);
                    else

                        labelTriunghi.Text = string.Format("Triunghiul format din punctele {0},{1},{2}  nu este  isoscel", A, B, C);


                }






            }




        }
    }
}
