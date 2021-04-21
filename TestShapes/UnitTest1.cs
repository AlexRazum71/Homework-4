
using Shapes;
using System;
using Xunit;


namespace TestShapes
{
    public class UnitTestShapes
    {
        [Fact]
        public void TestBallVolume()
        {
            Ball ball = new Ball(7);
           
            double result = ball.Volume();

            Assert.Equal(1436.755, result, 3);

        }

        [Fact]
        public void TestBoxVolume()
        {
            Box box = new Box(123);

            double result = box.Volume();

            Assert.Equal(1860867, result, 1);

        }

        [Fact]
        public void TestCylinderVolume()
        {
            Cylinder cylinder = new Cylinder(4,5);

            double result = cylinder.Volume();

            Assert.Equal(251.3, result, 1);

        }

        [Fact]
        public void TestPyramidVolume()
        {
            Pyramid pyramid = new Pyramid(45, 23.3);

            double result = pyramid.Volume();

            Assert.Equal(349.5, result, 1);

        }

        [Theory]

        [InlineData(13, 13,3)]

        public void TestShapeAdd (double conteinerHigh, double radiusCylinder, double highCylinder)
        {
            Box box = new Box(conteinerHigh);

            Cylinder cylinder = new Cylinder(radiusCylinder, highCylinder);

            Assert.True(box.Add(cylinder));
        }   
    }
}
