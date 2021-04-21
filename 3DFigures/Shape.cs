using System;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract string Name { get; }

        public abstract double Volume();
    }
}
