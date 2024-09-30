using BusinessLogic;
namespace BusinessLogic.Tests

{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            int x = 2000;
            int y = 137;
            int c = calculator.Add(x, y);
            int expected = 2137;

            Assert.Equal(expected, c);
        }
        [Fact]
        public void TestSub()
        {
            Calculator calculator = new Calculator();
            int x = 20;
            int y = 5;
            int c = calculator.Sub(x, y);
            int expected = 15;

            Assert.Equal(expected, c);
        }
        [Theory]
        [InlineData(2,3,5)]
        public void TestAddPar(int x, int y, int expected)
        {
            Calculator calculator = new Calculator();
            int c = calculator.Add(x, y);

            Assert.Equal(expected, c);
        }
        [Theory]
        [InlineData(5, 3, 2)]
        public void TestSubPar(int x, int y, int expected)
        {
            Calculator calculator = new Calculator();
            int c = calculator.Sub(x, y);

            Assert.Equal(expected, c);
        }
    }
}