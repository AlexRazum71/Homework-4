using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string [] args)
        {
            try
            {
                Box container = new Box(56);

                var shapes = new List<Shape>();

                Box box = new Box(12);
                shapes.Add(box);

                Pyramid pyramid = new Pyramid(56, 4);
                shapes.Add(pyramid);

                Cylinder cylinder = new Cylinder(15, 5);
                shapes.Add(cylinder);

                Ball ball = new Ball(8);
                shapes.Add(ball);

                Console.WriteLine($"Объем контейнеора: {container.Volume()}");

                foreach (var shape in shapes)
                {
                    if (!container.Add(shape))
                    {
                        Console.WriteLine("Контейнер заполнен! \n Фигуры в контейнере:");
                        foreach (var shp in container.Shapes)
                        {
                            Console.WriteLine($"{shp.Name} объемом {shp.Volume()}");

                        }
                        break;
                    }
                    Console.WriteLine($"В консоль добавлена фигура {shape.Name}  \n Оставшийся объем {container.RemainingVolume()}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}") ;
            }
        }
    }
}
