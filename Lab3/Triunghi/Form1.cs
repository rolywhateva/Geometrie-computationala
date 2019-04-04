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
        Random rnd = new Random((int)System.DateTime.Now.Ticks);
    
        private void Form1_Load(object sender, EventArgs e)
        {
            
       
       
           
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            labelA.Visible = labelB.Visible = labelC.Visible = false;
            labelAB.Visible = labelBC.Visible = labelAC.Visible = false;
          
            grp = Graphics.FromImage(bmp);
          // grp.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
            // DrawTriunghi();
         
           // grp.ResetTransform();
            pictureBox.Image = bmp;

        }
        private void DrawTriunghi()
        {
            do
            {
                p1 = RandomPoint();
                p2 = RandomPoint();
                p3 = RandomPoint();
            } while (invalidTriunghi(p1,p2,p3));
            grp.DrawPolygon(new Pen(Color.Black), new PointF[] { p1, p2, p3 });
            grp.DrawString("A", new Font(FontFamily.GenericSerif, 30, FontStyle.Regular), new SolidBrush(Color.Black), p1);
            grp.DrawString("B", new Font(FontFamily.GenericSerif, 30, FontStyle.Regular), new SolidBrush(Color.Black), p2);
            grp.DrawString("C", new Font(FontFamily.GenericSerif, 30, FontStyle.Regular), new SolidBrush(Color.Black), p3);
            if (BoxLiniiMijlocii.Checked)
                DeseneazaLiniiMijlocii(p1, p2, p3, Color.Moccasin);
            if (BoxMediana.Checked)
                DeseneazaMediane(p1, p2, p3, Color.Orange);
            // DeseneazaBisectoare(p1, p2, p3, Color.Green);
            if (BoxInaltime.Checked)
                DeseneazaInaltime(p1, p2, p3, Color.Red);
            if (BoxMediatoare.Checked)
                DeseneazaMediatoare(p1, p2, p3, Color.MediumSeaGreen);
            if (BoxBisectoare.Checked)
                DeseneazaBisectoare(p1, p2, p3, Color.MediumPurple);
            pictureBox.Image = bmp;

        }
    
        private void buttonDesenare_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox.BackColor);
            DrawTriunghi();
            labelA.Visible = labelB.Visible = labelC.Visible = true;
            labelAB.Visible = labelBC.Visible = labelAC.Visible = true;
         
            labelA.Text = "A="+pointString(p1);
            labelB.Text = "B="+pointString(p2);
            labelC.Text = "C="+pointString(p3);
            labelAC.Text = string.Format("AC={0:F2}", distanta(p1, p3));
            labelAB.Text = string.Format("AB={0:F2}", distanta(p1, p2));
            labelBC.Text = string.Format("BC={0:F2}", distanta(p2, p3));
        }
        #region utilitare
        private PointF Mijloc(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
        public bool invalidTriunghi(PointF p1, PointF p2, PointF p3)
        {
            int minlat = 200;
            int maxlat = 300;
            return Coliniare(p1, p2, p3)
                || distanta(p1, p3) < minlat || distanta(p1, p3) > maxlat
                || distanta(p2, p3) < minlat || distanta(p2, p3) > maxlat
                || distanta(p1, p2) < minlat || distanta(p1, p2) > maxlat;
        }
        public double distanta(PointF A, PointF B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }
        private bool Coliniare(PointF p1, PointF p2, PointF p3)
        {
            return p1.X * p2.Y + p2.X * p3.Y + p3.X * p1.Y - p3.X * p2.Y - p1.X * p3.Y - p2.X * p1.Y == 0;
        }

        private  PointF RandomPoint()
        {
            int randomX = rnd.Next(0, pictureBox.Width) ;
            int randomY = rnd.Next(0 ,pictureBox.Height) ;
            return new PointF(randomX, randomY);
        }
        private  float Panta(PointF A, PointF B)
        {
            return (B.Y - A.Y) / (B.X - A.X);
        }
   
        private void BoxLiniiMijlocii_Click(object sender, EventArgs e)
        {
            //DeseneazaLiniiMijlocii(p1, p2, p3, Color.Yellow);
        }
        /*
        private void BoxLiniiMijlocii_CheckedChanged(object sender, EventArgs e)
        {
            DeseneazaLiniiMijlocii(p1, p2, p3, Color.Yellow);


        }
        */

        private string  pointString(PointF A)
        {
            return $"({A.X},{A.Y})";
        }
        #endregion

        #region Linie mijlocie
        private void LinieMijlocie(PointF A, PointF B,PointF C,Color color )
        {
            PointF MijAB = Mijloc(A, B);
            PointF MijBC = Mijloc(B, C);
            Pen p = new Pen(color, 5);

            grp.DrawLine(p, MijAB, MijBC);

        }
        public void DeseneazaLiniiMijlocii(PointF A, PointF B, PointF C,Color color)
        {
            if (!BoxLiniiMijlocii.Checked)
                color = pictureBox.BackColor;
            LinieMijlocie(A, B, C, color);
            LinieMijlocie(B, C, A, color);
            LinieMijlocie(C,A,B, color);

        }
        #endregion
        #region Mediana
        public PointF  Mediana(PointF A, PointF B, PointF C,Color color )
        {
            PointF MijBC = Mijloc(B, C);
            Pen p = new Pen(Color.Orange, 5);

            grp.DrawLine(p, A, MijBC);
            return MijBC;
        }
        public void DeseneazaMediane(PointF A, PointF B, PointF C,Color color)
        {
          PointF mbc=  Mediana(A, B, C, color);
          PointF mac=  Mediana(B, A, C, color);
          PointF mab=  Mediana(C, A, B, color);
            PointF inter  = Intersectie(C, mab, A, Panta(A, mbc));
            grp.DrawString("G", new Font(FontFamily.GenericSerif,30,FontStyle.Regular), new SolidBrush(color), inter);
          

           
        }
        #endregion
        #region Bisectoare
        private PointF  Bisectoare(PointF A, PointF B, PointF C,Color color )
        {
            float ia, ja, ib, jb;
            ia = B.X - A.X;
            ja = B.Y - A.Y;
            ib = C.X - A.X;
            jb = C.Y - A.Y;
            float modA = (float)Math.Sqrt(ia * ia + ja * ja);
            float modb = (float)Math.Sqrt(ib * ib + jb * jb);
            float ic, jc;
            ic = modb * ia + modA * ib;
            jc = modb * ja + modA * jb;
            float xbis, ybis;
            xbis = ic + A.X;
            ybis = jc + A.Y;
            PointF bis = new PointF(xbis, ybis);
            PointF inter = Intersectie(B, C, A, Panta(A, bis));
            Pen p = new Pen(color, 5);
          
            grp.DrawLine(new Pen(color, 5), A, inter );
            return inter;



            // grp.DrawLine(new Pen(color), A, Inter);


        }
        private void DeseneazaBisectoare(PointF B, PointF A, PointF C, Color color)
        {

            if (BoxBisectoare.Checked)
            {


                PointF Bb =Bisectoare(B, A, C, color);
               
              PointF Ab=  Bisectoare(A, B, C, color);
                PointF Cb = Bisectoare(C,A,B, color);
                PointF I = Intersectie(A, Ab, Bb, Panta(B, Bb));
                grp.DrawString("I", new Font(FontFamily.GenericSerif, 30, FontStyle.Regular), new SolidBrush(color), I);

            }
        }
        private PointF Intersectie(PointF b, PointF c, PointF a, float panta)
        {
            float A1 = panta, A2 = Panta(b, c);
            float B1, B2;
            B1 = B2 = -1;
            float C1, C2;
            C1 = a.X * A1 - a.Y;
            C2 = A2 * b.X - b.Y;
            float det = A1 * B2 - A2 * B1;
            if (det == 0)
            {
                throw new Exception("Eroare");
               
            }
            float dx = C1 * B2 - B1 * C2;
            float dY = A1 * C2 - C1 * A2;
            float X = dx / det;
            float Y = dY / det;
            return new PointF(X, Y);


        }
        #endregion
        public void  Inaltime(PointF A , PointF B, PointF C, Color color)
        {
            float pantaBC = Panta(B, C);
            float pantaAH = -1 / pantaBC;
            PointF H = Intersectie(B,C,A, pantaAH);
            grp.DrawLine(new Pen(color,5),A,H);
        }
        public void DeseneazaInaltime(PointF A, PointF B, PointF C, Color color )
        {
            Inaltime(A, B, C, color);
            Inaltime(C, A, B, color);
            Inaltime(B, A, C, color);
        }
        public void Mediatoare(PointF A, PointF B, PointF C,Color color )
        {
            PointF MijAB = Mijloc(A, B);
            float pantaMed = -1 / Panta(A, B);
            PointF ExA, ExB;
            /*
            ExA = new PointF(-1000, pantaMed * (-1000) - pantaMed * MijAB.X + MijAB.Y);
            ExB = new PointF(1000, pantaMed * (1000) - pantaMed * MijAB.X + MijAB.Y);
            */
            PointF inter1 = new PointF();

            PointF inter2 = new PointF();
            inter1= Intersectie(B, C, MijAB, pantaMed);
           // inter2  = Intersectie(A, C, MijAB, pantaMed);

          //  PointF inter = (distanta(A, inter1) < distanta(A, inter2)) ? inter1 : inter2;
         
            Pen p = new Pen(color, 5);
         //   p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            grp.DrawLine(p, MijAB, inter1);

        }
        public void DeseneazaMediatoare(PointF A, PointF B,PointF C, Color color)
        {
            Mediatoare(A, B,C, color);
            Mediatoare(B, C,A, color);
            Mediatoare(A, C,B, color);
        }

    }
}
