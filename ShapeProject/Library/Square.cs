using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class Square : Quadrilateral
    {
        public Square(double A) : base(A)
        {
            
        }

        public override double CalculateArea()
        {
            return SideA * SideA;
        }

        public override string GetName()
        {
            return "square";
        }
    }
}
