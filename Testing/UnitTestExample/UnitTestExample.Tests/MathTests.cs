using UnitTestExample;
namespace UnitTestExample.Tests
{
    public class Tests
    {
        private UnitTestExample.Math math;
        [SetUp]
        public void SetUp()
        {
            math = new UnitTestExample.Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            //Act
            var result = math.Add(1, 2);
            //Assert
            //Assert.AreEqual(3, result);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsResultBasedOnValue(int a, int b, int expected)
        {
            var result = math.Max(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SayHello_WhenCalled_ThrowsAnException()
        {
            Message msg = new Message();
            var result = Assert.Throws<NullReferenceException>(() => msg.SayHello(""));
            Assert.That(result.Message, Is.EqualTo("Please mention user name"));
        }

        //[Test]
        //public void Max_WhenCalled_ReturnsGreaterValue()
        //{
        //    var result = math.Max(1, 2);
        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_WhenCalled_ReturnsLowestValue()
        //{
        //    var result = math.Max(3, 4);
        //    Assert.That(result, Is.Not.EqualTo(3));
        //}

        //[Test]
        //public void Max_WhenCalled_ReturnsEqualValue()
        //{
        //    var result = math.Max(3, 3);
        //    Assert.That(result, Is.EqualTo(3));
        //}
    }
}