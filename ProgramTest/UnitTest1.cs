using Open_Close;
using PatternLastBeforeHolidays.GenericFactory;
using PatternLastBeforeHolidays.Open_Close;

namespace ProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCirCle()
        {
            var shapeFactory = new GenericFactory<Circle>();
            var shape = shapeFactory.CreateShape();
            shape.Radius = 1f;
            var result = shape.CalculateArea();
            Assert.AreEqual(3.14f, result, 0.01f);
        }
        [TestMethod]
        public void TestRectangle()
        {
            var shapeFactory = new GenericFactory<Rectangle>();
            var shape = shapeFactory.CreateShape();
            shape.Lenght = 2f;
            shape.Width = 3f;
            var result = shape.CalculateArea();
            Assert.AreEqual(6f, result, 0.01f);
        }
        [TestMethod]
        public void TestSquare()
        {
            var shapeFactory = new GenericFactory<Square>();
            var shape = shapeFactory.CreateShape();
            shape.Side = 2.3f;
            var result = shape.CalculateArea();
            Assert.AreEqual(5.29f, result, 0.01f);
        }
    }
}