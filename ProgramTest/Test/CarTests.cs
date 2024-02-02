using Moq;
namespace ProgramTest;
[TestClass]
public class CarTests
{
    [TestMethod]
    public void Start_ShouldInvokeEngineStart()
    {
        // Arrange
        Mock<IEngine> mockEngine = new Mock<IEngine>();
        Car car = new Car(mockEngine.Object);

        // Act
        car.Start();

        // Assert
        mockEngine.Verify(e => e.Start(), Times.Once);
    }

    [TestMethod]
    public void Stop_ShouldInvokeEngineStop()
    {
        // Arrange
        Mock<IEngine> mockEngine = new Mock<IEngine>();
        Car car = new Car(mockEngine.Object);

        // Act
        car.Stop();

        // Assert
        mockEngine.Verify(e => e.Stop(), Times.Once);
    }
}
