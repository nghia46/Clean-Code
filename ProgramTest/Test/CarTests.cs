using CleanCode.Techniques.DependencyInjection;
using Moq;

namespace ProgramTest.Test;

[TestClass]
public class CarTests
{
    [TestMethod]
    public void Start_ShouldInvokeEngineStart()
    {
        // Arrange
        var mockEngine = new Mock<IEngine>();
        var car = new Car(mockEngine.Object);

        // Act
        car.Start();

        // Assert
        mockEngine.Verify(e => e.Start(), Times.Once);
    }

    [TestMethod]
    public void Stop_ShouldInvokeEngineStop()
    {
        // Arrange
        var mockEngine = new Mock<IEngine>();
        var car = new Car(mockEngine.Object);

        // Act
        car.Stop();

        // Assert
        mockEngine.Verify(e => e.Stop(), Times.Once);
    }
}