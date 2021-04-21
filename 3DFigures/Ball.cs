using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Shapes
{
    public class Ball : Shape
    {
        public double Radius { get; }

        public Ball(double r)
        {
            Radius = r;
        }

        public override string Name => "Шар";

        public override double Volume()
        {
            return (4.0 / 3.0) * PI * Pow(Radius, 3);
        }
    }
}
