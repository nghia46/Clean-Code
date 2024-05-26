using CleanCode.Commander;
using Moq;

namespace ProgramTest.Test
{
    [TestClass]
    public class FanRemoteTests
    {
        [TestMethod]
        public void TurnOnButton_ShouldInvokeTurnOnCommand()
        {
            // Arrange
            var mockTurnOnCommand = new Mock<ICommand>();
            var mockTurnOffCommand = new Mock<ICommand>(); // Create a mock for the turn off command to pass as a parameter
            var remote = new FanRemote(mockTurnOnCommand.Object, mockTurnOffCommand.Object);

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
            var mockTurnOnCommand = new Mock<ICommand>(); // Create a mock for the turn on command to pass as a parameter
            var remote = new FanRemote(mockTurnOnCommand.Object, mockTurnOffCommand.Object);

            // Act
            remote.TurnOffButton();

            // Assert
            mockTurnOffCommand.Verify(c => c.Execute(), Times.Once);
        }
    }
}
