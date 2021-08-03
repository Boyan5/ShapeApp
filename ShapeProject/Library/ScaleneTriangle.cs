using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class ScaleneTriangle : Triangle
    {
        private readonly double SemiPerimeter;

        public ScaleneTriangle(double A, double B, double C) : base(A, B, C)
        {
            SemiPerimeter = (A + B + C) / 2;
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(SemiPerimeter * (SemiPerimeter - SideA) 
                * (SemiPerimeter - SideB) * (SemiPerimeter - SideC));
        }

        public override string GetName()
        {
            return "scalene triangle";
        }
    }
}
