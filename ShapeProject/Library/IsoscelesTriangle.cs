using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class IsoscelesTriangle : Triangle
    {
        private readonly double SemiPerimeter;

        public IsoscelesTriangle(double A, double B) : base(A, B)
        {
            SemiPerimeter = (A + 2 * B ) / 2;
        }
        public override double CalculateArea()
        {
            return Math.Sqrt(SemiPerimeter * (SemiPerimeter - SideA)
                * (SemiPerimeter - SideB) * (SemiPerimeter - SideB));
        }       

        public override string GetName()
        {
            return "isosceles triangle";
        }

    }
}
