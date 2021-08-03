using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
        string Describe();
        string GetName();
    }
}
