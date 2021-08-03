using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class Triangle : IShape
    {
        protected double SideA;
        protected double SideB;
        protected double SideC;

        public Triangle(double A, double B, double C)
        {
            SideA = A;
            SideB = B;
            SideC = C;
        }

        public Triangle(double A, double C)
        {
            SideA = SideB = A;
            SideC = C;
        }

        public Triangle(double A)
        {
            SideA = SideB = SideC = A;
        }

        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
        public string Describe()
        {
            return "The sides of the " + GetName() + " are " + SideA + ", " +
                 + SideB + ", " + SideC;
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
