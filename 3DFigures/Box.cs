using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Box : Shape
    {
        public double High { get; }

        private double _fillVolume;
        public Box(double h)
        {
            High = h;
        }

        public override string Name => "Куб";

        public override double Volume()
        {
            return Math.Pow(High, 3);
        }

        public List<Shape> Shapes { get; } = new List<Shape>();

        public double RemainingVolume()
        {
            return Volume() - _fillVolume;
        }

        public bool Add (Shape shape)
        {
            double remainingVolume = RemainingVolume();
            double shapeVolume = shape.Volume();

            if (remainingVolume >= shapeVolume)
            {
                Shapes.Add(shape);
                _fillVolume += shapeVolume;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
