using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape
    {
        public double Radius { get; }
        public double High { get; }

        public Cylinder (double r, double h)
        {
            Radius = r;
            High = h;
        }

        public override string Name => "Цилиндр";
        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * High; 
        }
    }
}
