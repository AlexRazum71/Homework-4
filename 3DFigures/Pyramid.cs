using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Pyramid  : Shape 
    {
        public double S { get; }

        public double H { get; }

        public Pyramid (double s, double h)
        {
            S = s;
            H = h;
        }

        public override string Name => "Пирамида";

        public override double Volume()
        {
            return S * H / 3;
        }
    }
}
