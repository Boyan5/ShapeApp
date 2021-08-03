using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class Rectangle : Quadrilateral
    {
        public Rectangle(double A, double B) : base(A, B)
        {
            
        }

        public override double CalculateArea()
        {
            return SideA * SideC;
        }

        public override string GetName()
        {
            return "rectangle";
        }
    }
}
