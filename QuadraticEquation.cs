using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    class QuadraticEquation
    {
        public QuadraticEquation()
        {

        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A  //property
        {
            get { return a; }
            set { a = value; }
        }
        public double B  //property
        {
            get { return b; }
            set { a = value; }
        }
        public double C  //property
        {
            get { return c; }
            set { a = value; }
        }

        public double Y(double x)
        {
            return a * x * x + b * x + c;
        }

        public double Discriminant
        {
            get { return b * b - 4 * a * c; }
        }

        public double[] Roots
        {
            get
            {
                if (a == 0)
                {
                    return new double[] { -c / b, -c, b };
                }
                double sqrtDisc = Math.Sqrt(Discriminant);
            
                return new double[] { (-b - sqrtDisc) / 2 / a, (-b + sqrtDisc) / 2 / a };
            }
        }
        private double a;
        private double b;
        private double c;


    }
}
