using Moq;

namespace AppLibrary.Tests
{
    public class Tests
    {
        [Test]
        public void ReadText_WhenCalled_ReturnsAllTextFromFile()
        {
            //Arrange
            //FileService fileService = new FileService();
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadText()).Returns("Welcome to File Handling");
            var service = new FileService(fileReader.Object);
            //Act
            var result = service.ReadData();
            //Assert
            Assert.That(result, Does.Contain("File"));
        }
    }
}