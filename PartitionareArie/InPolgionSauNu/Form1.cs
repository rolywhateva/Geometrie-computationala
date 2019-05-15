using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InPolgionSauNu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        List<PointF> points = new List<PointF>();
        List<PointF> originalpoints = new List<PointF>();
        PointF point = new PointF(1000, 1000);
        Dictionary<PointF, string> table = new Dictionary<PointF, string>();
        string chars = "ABCDEFGHJ";
        
        Pen p = new Pen(Color.Black, 2);
        SolidBrush pointBrush = new SolidBrush(Color.Red);
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width,pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            grp.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            labelResponse.Text = "";
            labelResponse.Visible = false;

        }
        private void LoadPoints()
        {
            PointF[] pointArray = new PointF[] { new Point(112, 54), new Point(123, 16), new Point(93, -14), new Point(60, -20), new Point(18, 12), new Point(19, 46), new Point(51, 58) };
            originalpoints = pointArray.ToList();
            for (int i = 0; i < pointArray.Length; i++)
               pointArray[i] = new PointF(pointArray[i].X*3 , pointArray[i].Y*3);
            points = pointArray.ToList();
        }
        private void Hash()
        {
            for (int i = 0; i < points.Count; i++)
                table.Add(points[i], $"({originalpoints[i].X},{originalpoints[i].Y})");
          
            
        }
        private void Note(Font f, Color c)
        {
            for (int i = 0; i < points.Count; i++)
                grp.DrawString(table[points[i]], f, new SolidBrush(c), points[i]);
        }
        private float Arie(PointF A, PointF B,PointF P)
        {
            return (P.X*A.Y+A.X*B.Y+B.X*P.Y-B.X*A.Y-P.X*B.Y-A.X*P.Y)/ 2;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            points.Clear();
            originalpoints.Clear();
            table.Clear();
            originalpoints.Clear();


            LoadPoints();
            Hash();
            

            Note(new Font("Verdana", 14, FontStyle.Regular), Color.Red);


            PointF[] pointArray = points.ToArray();
            grp.DrawPolygon(p, pointArray);


            pictureBox.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResponse.Text = "";

        }
        int sign(float val)
        {
            if (val > 0) return 1;
            else
                return -1;
        }

        public bool inPolygon(PointF p)
        {
            
            originalpoints.Add(originalpoints[0]);
          
           
            int semn = -2;
            for (int i = 0; i < originalpoints.Count - 1; i++)
            {
                float arie = Arie(originalpoints[i], originalpoints[i + 1], p);
                int s = sign(arie);
                if (semn == -2)
                    semn = s;
                else
                    if (semn != s)
                {
                   
                    originalpoints.RemoveAt(originalpoints.Count - 1);
                    return false;
                }
            }

            originalpoints.RemoveAt(originalpoints.Count - 1);
            /*
            int semn = -2;
            for(int i=0;i<originalpoints.Count;i++)
                for(int j=i+1;j<originalpoints.Count;j++)
                {
                    float  arie = Arie(originalpoints[i], originalpoints[j], p);
                    int  s = sign(arie);
                    if (semn ==-2)
                        semn = s;
                    else
                       if (semn !=s)
                        return false;
                }
            */
            return true;
        }
        private void DrawPoint(PointF p,Color c, int raza)
        {

            grp.DrawEllipse(new Pen(c), p.X, p.Y, raza, raza);
            grp.FillEllipse(new SolidBrush(c), p.X, p.Y, raza, raza);
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            labelResponse.Visible = true;
            //DrawPoint(point, pictureBox.BackColor, 4);
            try
            {

                point.X = int.Parse(textBoxX.Text);
                point.Y = int.Parse(textBoxY.Text);

            }catch(Exception exception)
            {
                MessageBox.Show("Eroare");
                return;
            }

            PointF translatedPoint = new PointF(point.X*3 , point.Y*3);
            DrawPoint(translatedPoint, Color.Green, 4);
       
            bool ok = inPolygon(point);
            string nu = "";
            if (!ok)
                nu = "nu";
            labelResponse.Text+=$"({point.X},{point.Y})  {nu} este in poligon\n";
            pictureBox.Image = bmp;
            point = translatedPoint;
           

        }
    }
}
