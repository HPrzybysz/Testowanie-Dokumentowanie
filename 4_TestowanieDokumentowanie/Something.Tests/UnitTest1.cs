using _4_TestowanieDokumentowanie;
using NSubstitute;
namespace Something.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(-100, -1)]
        [InlineData(-10, -1)]
        [InlineData(10, 1000)]
        [InlineData(0,10)]

        public void Test(int x, int y)
        {
            var ob = new _4_TestowanieDokumentowanie.Class1();
            var result = ob.Something(x);
            Assert.Equal(y, result);
        }

        [Fact]
        public void Test2()
        {
            var obj = Substitute.For<IClass>();

            obj.Something(1).Returns(1);

            Assert.Equal(1, obj.Something(1));
        }
    }
}