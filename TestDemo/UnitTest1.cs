using UnitTest_xUnit_MVC_Core6;

namespace TestDemo
{
    public class UnitTest1
    {
        [Fact]
        public void EvenNumberTest()
        {
            //Arrange
            var num = 6;
            //Act
            bool result = Mathematics.IsEvenNumber(num);
            //Assert
            Assert.True(result);
        }
        [Theory]
        [InlineData(7)]
        public void OddNumberTest(int num)
        {
            bool result = Mathematics.IsOddNumber(num);
            Assert.True(result);
        }

        [Fact]
        public void SquareOfNumberTest()
        {
            //Arrange
            var num = 10;
            //Act
            var Result = Mathematics.SquareOfNumber(num);
            //Assert
            Assert.Equal(100, Result);
        }
    }
}