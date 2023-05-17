using UnitTestingDemo;

namespace TestProject
{
    public class Tests
    {
        private Calculator calculator;

        [OneTimeSetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestSum()
        {
            int result = calculator.Sum(10, 20);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void SumShouldReturnInteger()
        {
            var result = calculator.Sum(40, 50);
            Assert.IsAssignableFrom<int>(result);
        }


    }
}