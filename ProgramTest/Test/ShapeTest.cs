using CleanCode.GenericFactory;
using CleanCode.Open_Close;

namespace ProgramTest.Test;


[TestClass]
public class ShapeTest
{
    [TestMethod]
    [DynamicData(nameof(SquareTestData), DynamicDataSourceType.Property)]
    public void TestSquareArea_GivenSideLength_ReturnsExpectedArea(float sideLength, float expectedArea)
    {
        var shapeFactory = new GenericFactory<Square>();
        var shape = shapeFactory.CreateShape();
        shape.Side = sideLength;

        var result = shape.CalculateArea();
        Assert.AreEqual(expectedArea, result, 0.01f, $"Failed for side length: {sideLength}");
    }

    [TestMethod]
    [DynamicData(nameof(CircleTestData), DynamicDataSourceType.Property)]
    public void TestCircleArea_GivenRadius_ReturnsExpectedArea(float radius, float expectedArea)
    {
        var shapeFactory = new GenericFactory<Circle>();
        var shape = shapeFactory.CreateShape();
        shape.Radius = radius;

        var result = shape.CalculateArea();
        Assert.AreEqual(expectedArea, result, 0.01f, $"Failed for radius: {radius}");
    }

    [TestMethod]
    [DynamicData(nameof(RectangleTestData), DynamicDataSourceType.Property)]
    public void TestRectangleArea_GivenWidthAndLength_ReturnsExpectedArea(float width, float length, float expectedArea)
    {
        var shapeFactory = new GenericFactory<Rectangle>();
        var shape = shapeFactory.CreateShape();
        shape.Length = length;
        shape.Width = width;

        var result = shape.CalculateArea();
        Assert.AreEqual(expectedArea, result, 0.01f, $"Failed for width: {width}, length: {length}");
    }
    public static IEnumerable<object[]> SquareTestData
    {
        get
        {
            return new[]
            {
                    new object[] { 5, 25 },
                    new object[] { 0.001f, 0.000001f },
                    new object[] { 10000, 100000000 },
                    new object[] { 0, 0 },
                    new object[] { float.MaxValue, float.PositiveInfinity }
                };
        }
    }

    public static IEnumerable<object[]> CircleTestData
    {
        get
        {
            return new[]
            {
                    new object[] { 1, MathF.PI },
                    new object[] { 5, 25 * MathF.PI },
                    new object[] { 0.5f, 0.25f * MathF.PI },
                    new object[] { 0, 0 },
                    new object[] { float.MaxValue, float.PositiveInfinity }
                };
        }
    }

    public static IEnumerable<object[]> RectangleTestData
    {
        get
        {
            return new[]
            {
                    new object[] { 2, 3, 6 },      // Length = 2, Width = 3, Area = 2 * 3 = 6
                    new object[] { 4, 4, 16 },     // Length = 4, Width = 4, Area = 4 * 4 = 16
                    new object[] { 10, 5, 50 },    // Length = 10, Width = 5, Area = 10 * 5 = 50
                    new object[] { 0, 10, 0 },     // Length = 0, Width = 10, Area = 0 * 10 = 0
                    new object[] { float.MaxValue, float.MaxValue, float.PositiveInfinity }
                };
        }
    }
}
