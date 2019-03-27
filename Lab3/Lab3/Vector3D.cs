using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Vector3D
    {
       public float A1 { get; set; }
        public float B1 { get; set; }
        public float C1 { get; set; }
        public Vector3D(float A1,float B1,float C1)
        {
            this.A1 = A1;
            this.B1 = B1;
            this.C1 = C1;
        }
        public Vector3D()
        {
            A1 = B1 = C1 = 0;
        }
        public double Modul
        {
            get
            {
                return Math.Sqrt(A1*A1+B1*B1+C1*C1);
            }
        }
        public Vector3D ProdusVectorial(Vector3D v2)
        {
            Vector3D produs = new Vector3D();
            produs.A1 = B1 * v2.C1 - v2.B1 * C1;
            produs.B1 = A1 * v2.C1 - B1 * A1;
            produs.C1 = A1 * v2.B1 - B1 * v2.A1;
            return produs;
        }
        public double  ProdusScalar(Vector3D v2)
        {
            return A1 * v2.A1 + B1 * v2.B1 + C1 * v2.C1;
        }
        public double  ArieParalelogram(Vector3D  v2)
        {
            double cosPhi = this.ProdusScalar(v2) / (Modul * v2.Modul);
            return Modul * v2.Modul * cosPhi;
        }
        public double ProdusMixt(Vector3D v2, Vector3D v3)
        {
            return ProdusScalar( v2.ProdusVectorial(v3));
        }
        public override string ToString()
        {
            string s = "";
         
            s = s + A1 + "i";
            if (B1 >= 0) s = s + "+";
            s = s + B1.ToString() + "j";
            if (C1 >= 0) s = s + "+";
            s = s + C1.ToString() + "k";
             return s;



        }


    }
}
