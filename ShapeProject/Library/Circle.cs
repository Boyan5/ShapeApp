using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    [Serializable()]
    public class Circle : IShape
    {
        private double Radius { get; set; }

        public Circle(double R)
        {
            Radius = R;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public string Describe()
        {
            return "The circle is with radius " + Radius + " and diameter " + 2 * Radius;
        }

        public string GetName()
        {
            return "circle";
        }
    }
}
