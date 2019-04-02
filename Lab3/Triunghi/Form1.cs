using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
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
            //  grp.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
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
            } while (invalidTriunghi(p1, p2, p3));
            grp.DrawPolygon(new Pen(Color.Black), new PointF[] { p1, p2, p3 });
            if (BoxLiniiMijlocii.Checked)
                DeseneazaLiniiMijlocii(p1, p2, p3, Color.Yellow);
            if (BoxMediana.Checked)
                DeseneazaMediane(p1, p2, p3, Color.Orange);
          
            if (BoxInaltime.Checked)
                DeseneazaInaltime(Color.Red);
            if (BoxMediatoare.Checked)
                DeseneazaMediatoare(Color.Aquamarine);
             if(BoxBisectoare.Checked)
                DeseneazaBisectoare(p1, p2, p3, Color.Green);

            pictureBox.Image = bmp;

        }

        private void buttonDesenare_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox.BackColor);
            DrawTriunghi();
            labelA.Visible = labelB.Visible = labelC.Visible = true;
            labelAB.Visible = labelBC.Visible = labelAC.Visible = true;

            labelA.Text = "A=" + pointString(p1);
            labelB.Text = "B=" + pointString(p2);
            labelC.Text = "C=" + pointString(p3);
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
            int minlat = 150;
            int maxlat = 250;
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

        private PointF RandomPoint()
        {
            int randomX = rnd.Next(pictureBox.Width);
            int randomY = rnd.Next(pictureBox.Height);
            return new PointF(randomX, randomY);
        }
        private float Panta(PointF A, PointF B)
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

        private string pointString(PointF A)
        {
            return $"({A.X},{A.Y})";
        }
        #endregion

        #region Linie mijlocie
        private void LinieMijlocie(PointF A, PointF B, PointF C, Color color)
        {
            PointF MijAB = Mijloc(A, B);
            PointF MijBC = Mijloc(B, C);
            Pen p = new Pen(color, 5);

            grp.DrawLine(p, MijAB, MijBC);

        }
        public void DeseneazaLiniiMijlocii(PointF A, PointF B, PointF C, Color color)
        {
            if (!BoxLiniiMijlocii.Checked)
                color = pictureBox.BackColor;
            LinieMijlocie(A, B, C, color);
            LinieMijlocie(B, C, A, color);
            LinieMijlocie(C, A, B, color);

        }
        #endregion
        #region Mediana
        public void Mediana(PointF A, PointF B, PointF C, Color color)
        {
            PointF MijBC = Mijloc(B, C);
            Pen p = new Pen(Color.Orange, 5);
            grp.DrawLine(p, A, MijBC);
        }
        public void DeseneazaMediane(PointF A, PointF B, PointF C, Color color)
        {
            Mediana(A, B, C, color);
            Mediana(B, A, C, color);
            Mediana(C, A, B, color);

        }
        #endregion
        #region Bisectoare
        private void Bisectoare(PointF A, PointF B, PointF C, Color color)
        {
            //MessageBox.Show("*");
            PointF D = new PointF();
        
            double ia, ib, ja, jb;
            ia = B.X - A.X;
            ja = B.Y - A.Y;
            ib = C.X - A.X;
            jb = C.Y - A.Y;
         
            
                double modA = Math.Sqrt(ia * ia + ja * ja);
               double modB = Math.Sqrt(ib * ib + jb * jb);
              double  DX = modB*ia+modA*ib + A.X;
            double  DY = modB*ja+modA*jb + A.Y;
                 D = new PointF((float)DX, (float)DY);
            PointF inter = Intersectie(B, C, A, Panta(A, D));
            grp.DrawLine(new Pen(color, 5), A, inter);
         

        }
        private void DeseneazaBisectoare(PointF B, PointF A, PointF C, Color color)
        {

            if (BoxBisectoare.Checked)
            {

               
                Bisectoare(B, A, C, color);
             
                Bisectoare(A, B, C, color);
                Bisectoare(C,A,B, color);
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
                throw new Exception("Eroare");
            float dx = C1 * B2 - B1 * C2;
            float dY = A1 * C2 - C1 * A2;
            float X = dx / det;
            float Y = dY / det;
            return new PointF(X, Y);


        }
        #endregion
        #region inaltime
        private void Inaltime(PointF B, PointF A, PointF C, Color c)
        {
            float pantaBh = -1 / Panta(A, C);
            PointF h = Intersectie(A, C, B, pantaBh);
            grp.DrawLine(new Pen(c, 5), B, h);

        }
        private void DeseneazaInaltime(Color c)
        {
            Inaltime(p1, p2, p3, c);
            Inaltime(p3, p2, p1, c);
            Inaltime(p2, p1, p3, c);
        }
        #endregion 
   
        private void Mediatoare(PointF A, PointF B, Color c)
        {
            float pantaM = -1 / Panta(A, B);
            PointF Mij = Mijloc(A, B);
            float MC = -pantaM * Mij.X + Mij.Y;

            Pen p = new Pen(c, 5);
            p.DashStyle = DashStyle.DashDot;
            PointF X, Y;
            int nr1, nr2;
          
            X = new PointF(10000, 10000 * pantaM + MC);
            Y = new PointF(-10000, -10000 * pantaM + MC);
           
            grp.DrawLine(p, X, Y);
        }
        private void DeseneazaMediatoare(Color c)
        {
            Mediatoare(p1, p2, c);
            Mediatoare(p2, p3, c);
            Mediatoare(p1, p3, c);
        }


    }
}

