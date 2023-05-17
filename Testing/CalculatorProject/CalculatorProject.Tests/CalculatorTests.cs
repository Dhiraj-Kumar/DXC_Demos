using Newtonsoft.Json.Linq;
using FluentAssertions;
namespace CalculatorProject.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
        {
            Calculator calc = new Calculator();

            var result = calc.Add(2, 3);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 2)]
        public void Max_WhenCalled_ReturnsValueBasedOnInput(int a, int b, int expected)
        {
            Calculator calc = new Calculator();

            var result = calc.Max(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetOddNumbers_WhenCalled_ReturnsOddNumbersUptoRange()
        {
            Calculator calc = new Calculator();
            var result = calc.GetOddNumbers(5);
            //Assert.Equal(result.Count(), 5);
            //Assert.IsAssignableFrom<IEnumerable<int>>(result);
            result.Should().HaveCount(3);
            result.Should().Contain(1);
            result.Should().Contain(3);
            result.Should().Contain(5);
        }



        //[Fact]
        //public void Max_WhenCalled_ReturnsFirstValueAsGreater()
        //{
        //    Calculator calc = new Calculator();

        //    var result = calc.Max(2, 1);

        //    Assert.Equal(2, result);
        //}

        //[Fact]
        //public void Max_WhenCalled_ReturnsSecondValueAsGreater()
        //{
        //    Calculator calc = new Calculator();

        //    var result = calc.Max(1, 2);

        //    Assert.Equal(2, result);
        //}

        //[Fact]
        //public void Max_WhenCalled_ReturnsEqualValue()
        //{
        //    Calculator calc = new Calculator();

        //    var result = calc.Max(2, 2);

        //    Assert.Equal(2, result);
        //}
    }
}
