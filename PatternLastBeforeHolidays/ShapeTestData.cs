namespace ProgramTest.TestData;

public static class ShapeTestData
{
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
}