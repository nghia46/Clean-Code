using Moq;
using PatternLastBeforeHolidays.Commander;

namespace ProgramTest.Test;

[TestClass]
public class FanRemoteTests
{
    [TestMethod]
    public void TurnOnButton_ShouldInvokeTurnOnCommand()
    {
        // Arrange
        var mockTurnOnCommand = new Mock<ICommand>();
        var remote = new FanRemote(mockTurnOnCommand.Object, null);

        // Act
        remote.TurnOnButton();

        // Assert
        mockTurnOnCommand.Verify(c => c.Execute(), Times.Once);
    }

    [TestMethod]
    public void TurnOffButton_ShouldInvokeTurnOffCommand()
    {
        // Arrange
        var mockTurnOffCommand = new Mock<ICommand>();
        var remote = new FanRemote(null, mockTurnOffCommand.Object);

        // Act
        remote.TurnOffButton();

        // Assert
        mockTurnOffCommand.Verify(c => c.Execute(), Times.Once);
    }
}