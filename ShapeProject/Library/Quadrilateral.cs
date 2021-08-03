using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class Quadrilateral : IShape
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        protected double SideC { get; set; }
        protected double SideD { get; set; }

        public Quadrilateral(double A, double B, double C, double D)
        {
            SideA = A;
            SideB = B;
            SideC = C;
            SideD = D;
        }

        public Quadrilateral(double A, double B)
        {
            SideA = SideB = A;
            SideC = SideD = B;
        }

        public Quadrilateral(double A)
        {
            SideA = SideB = SideC = SideD = A;
        }

        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }

        public string Describe()
        {
            return "The " + GetName() + " is with sides " + SideA + ", " + SideB + ", " +
                SideC + ", " + SideD; 
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
