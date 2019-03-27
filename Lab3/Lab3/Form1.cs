using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelNorma.Visible = false;
            labelProdus.Visible = false;
            labelArie.Visible = false;
            labelProdusMixt.Visible = false;
            labelv1.Visible = false;
            labelv2.Visible = false;
            labelv3.Visible = false;
        }

        private void ButonCalculare_Click(object sender, EventArgs e)
        {
            Vector3D v1, v2, v3;
            v1 = new Vector3D(float.Parse(Boxa1.Text), float.Parse(Boxb1.Text), float.Parse(Boxc1.Text));
            v2 = new Vector3D(float.Parse(Boxa2.Text), float.Parse(Boxb2.Text), float.Parse(Boxc2.Text));
            v3 = new Vector3D(float.Parse(Boxa3.Text), float.Parse(Boxb3.Text), float.Parse(Boxc3.Text));
            labelv1.Visible = true;
            labelv1.Text = "v1="+v1.ToString();
            labelv2.Visible = true;
            labelv2.Text ="v2="+ v2.ToString();
            labelv3.Text ="v3="+ v3.ToString();
            labelv3.Visible = true;
            labelNorma.Visible = true;
            labelNorma.Text = v1.Modul.ToString();
            labelProdus.Visible = true;
            labelProdus.Text = v1.ProdusVectorial(v2).ToString();
            labelProdusMixt.Visible = true;
            labelProdusMixt.Text = v1.ProdusMixt(v2, v3).ToString();
            labelArie.Visible = true;
            labelArie.Text = v1.ArieParalelogram(v2).ToString();

            

        }
    }
}
