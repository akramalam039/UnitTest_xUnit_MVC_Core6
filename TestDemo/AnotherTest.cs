using UnitTest_xUnit_MVC_Core6;

namespace TestDemo
{
    public class AnotherTest
    {
        [Theory]
        [InlineData(1, 3)]
        public void Sum(int a, int b)
        {
            var result = Mathematics.Add(a, b);
            Assert.Equal(4, result);
        }
        [Fact]
        public void Subtract()
        {
            var a = 1;
            var b = 2;
            var result = Mathematics.Subtract(a, b);
            Assert.Equal(-1, result);


            var c = 3;
            var d = 2;
            var result2 = Mathematics.Subtract(c, d);
            Assert.Equal(1, result2);
        }
        [Fact]
        public void Multiply()
        {
            var a = 1;
            var b = 2;
            var result = Mathematics.Multiply(a, b);
            Assert.Equal(2, result);
        }
    }
}
