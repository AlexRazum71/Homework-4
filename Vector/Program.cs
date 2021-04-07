using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new(4, 5, 6);
            Vector v2 = new(7, 5, 8);
            Console.WriteLine($"Coordinate first vector ({v1.X}, {v1.Y}, {v1.Z})");
            Console.WriteLine($"Coordinate second vector ({v2.X}, {v2.Y}, {v2.Z})");
            Console.WriteLine($"Length first vector {v1.lengthVector(v1)}");
            Console.WriteLine($"Length second vector {v1.lengthVector(v2)}");
            Console.WriteLine($"Scalar product {v1.scalarProduct(v1, v2)}");
            v1.vectorProduct(v1, v2, out double X, out double Y, out double Z);
            Console.WriteLine($"Vector product ({X}, {Y}, {Z})");
            v1.vectorSum(v1, v2, out  X, out  Y, out  Z);
            Console.WriteLine($"Vector sum ({X}, {Y}, {Z})");
            v1.vectorDiff(v1, v2, out  X, out Y, out  Z);
            Console.WriteLine($"Vector difference ({X}, {Y}, {Z})");
            Console.WriteLine($"Cosinus {v1.cos(v1, v2)}");
        }

        class Vector
        {
            public double X { get; }
            public double Y { get; }
            public double Z { get; }

            public Vector (double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public double lengthVector (Vector p1)
            {
                double length = Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2) + Math.Pow(p1.Z, 2));
                return length;
            } 

            public double scalarProduct (Vector p1, Vector p2)
            {
                double scalar = p1.X * p2.X + p1.Y * p2.Y + p1.Z * p2.Z;
                return scalar;
            }

            public void vectorProduct(Vector p1, Vector p2, out double X, out double Y, out double Z)
            {
                X = p1.Y * p2.Z - p1.Z * p2.Y;
                Y = p1.Z * p2.X - p1.X * p2.Z;
                Z = p1.X * p2.Y - p1.Y * p2.X;
            }

            public double cos(Vector p1, Vector p2)
            {
                double cos = scalarProduct(p1, p2) / (lengthVector(p1) * lengthVector(p2));
                return cos;
            }

            public void vectorSum(Vector p1, Vector p2, out double X, out double Y, out double Z)
            {
                X = p1.X + p2.X;
                Y = p1.Y + p2.Y;
                Z = p1.Z + p2.Z;
            }

            public void vectorDiff(Vector p1, Vector p2, out double X, out double Y, out double Z)
            {
                X = p1.X - p2.X;
                Y = p1.Y - p2.Y;
                Z = p1.Z - p2.Z;
            }
        }
    }
}
