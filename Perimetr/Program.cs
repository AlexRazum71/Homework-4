using System;


namespace Perimeter
{
    class Program
    {

        static void Main(string[] args)
        {
            Point a = new("a", 4, 5);
            Point b = new("b", 1, -9);
            Point c = new("c", 2, 3);
            Point d = new("d", 6, 2);
            Point e = new("e", 3, 3);

            Polygon polygon1 = new(a, b, c);
            Polygon polygon2 = new(a, b, c, d);
            Polygon polygon3 = new(a, b, c, d, e);

            Console.WriteLine(polygon1.Perimeter());
            Console.WriteLine(polygon2.Perimeter());
            Console.WriteLine(polygon3.Perimeter());
            Console.ReadKey();

        }

        class Point
        {
            //private double x, y;
            //private string _name;
            public double X { get; }
            public double Y { get; }
            public string Name { get; }
            public Point (string name, double x, double y) 
            {
                Name = name;
                X = x;
                Y = y;
            }
             
        }
        class Polygon
        {
            private double _x1, _x2, _x3, _x4, _x5;
            private double _y1, _y2, _y3, _y4, _y5;
            private string _nameP1, _nameP2, _nameP3, _nameP4, _nameP5;
            public Polygon (Point a, Point b, Point c)
            {
                _x1 = a.X;
                _y1 = a.Y;
                _nameP1 = a.Name;

                _x2 = b.X;
                _y2 = b.Y;
                _nameP2 = b.Name;

                _x3 = c.X;
                _y3 = c.Y;
                _nameP3 = c.Name;
                //Perimeter(Distance(a, b), Distance(b, c), Distance(c, a));
            }

            public Polygon (Point a, Point b, Point c, Point d)
            {
                _x1 = a.X;
                _y1 = a.Y;
                _nameP1 = a.Name;

                _x2 = b.X;
                _y2 = b.Y;
                _nameP2 = b.Name;

                _x3 = c.X;
                _y3 = c.Y;
                _nameP3 = c.Name;

                _x4 = d.X;
                _y4 = d.Y;
                _nameP4 = d.Name;
                //Perimeter(Distance(a, b), Distance(b, c), Distance(c, a), Distance(d, a));
            }

            public Polygon (Point a, Point b, Point c, Point d, Point e)
            {

                _x1 = a.X;
                _y1 = a.Y;
                _nameP1 = a.Name;

                _x2 = b.X;
                _y2 = b.Y;
                _nameP2 = b.Name;

                _x3 = c.X;
                _y3 = c.Y;
                _nameP3 = c.Name;

                _x4 = d.X;
                _y4 = d.Y;
                _nameP4 = d.Name;

                _x5 = e.X;
                _y5 = e.Y;
                _nameP5 = e.Name;
                //Perimeter(Distance(a, b), Distance(b, c), Distance(c, a), Distance(d, a), Distance(e, a));
            }

            public double Distance (double x1, double x2, double y1, double y2)
            {
                double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                return distance;
            }
            public double Perimeter ( )
            {
                double perimeter = 0;
                if (_nameP4 == null & _nameP5 == null)
                {
                    perimeter = Distance(_x1, _x2, _y1, _y2) + Distance(_x2, _x3, _y2, _y3) + Distance(_x3, _x1, _y3, _y1); 
                }
                else if (_nameP4 != null & _nameP5 == null)
                {
                    perimeter = Distance(_x1, _x2, _y1, _y2) + Distance(_x2, _x3, _y2, _y3) 
                                + Distance(_x3, _x4, _y3, _y4)+ Distance(_x4, _x1, _y4, _y1);
                }
                else if (_nameP4 != null & _nameP5 != null)
                {
                    perimeter = Distance(_x1, _x2, _y1, _y2) + Distance(_x2, _x3, _y2, _y3)    
                                + Distance(_x3, _x4, _y3, _y4) + Distance(_x4, _x5, _y4, _y5) + Distance(_x5, _x1, _y5, _y1);
                }
                return perimeter;
            }
        }
    }
}
