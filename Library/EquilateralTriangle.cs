using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class EquilateralTriangle : Triangle
    {
        private readonly double Perimeter;
        private readonly double SemiPerimeter;
        
        public EquilateralTriangle(double A) : base(A)
        {
            Perimeter = 3 * A;
            SemiPerimeter = Perimeter / 2;
        }
        public override double CalculateArea()
        {
            return Math.Sqrt(SemiPerimeter * Math.Pow(SemiPerimeter - SideA, 3));
        }

        public override string GetName()
        {
            return "equilateral triangle";
        }
    }
}
