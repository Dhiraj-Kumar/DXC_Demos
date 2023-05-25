using BookStore;
using Moq;

namespace BookStore.Tests
{
    public class Tests
    {
        [Test]
        public void AddBook_WhenRecordInserted_ReturnsNoOfRowsAffected()
        {
            //Arrange
            var repo = new Mock<IBookRepository>();
            repo.Setup(x => x.AddBook("Harry Potter", "Author", 750)).Returns(1);
            var program = new Program(repo.Object);
            //Act
            var result = program.Run("Harry Potter", "Author", 750);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
    }
}