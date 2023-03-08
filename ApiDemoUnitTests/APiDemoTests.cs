namespace ApiDemoUnitTests
{
    public class APiDemoTests
    {
        [Fact]
        public void APiDemo_Test1()
        {
            //Arrange
            var actual = true; 
            var expected = true;

            //Act

            //Assert
            Assert.NotEqual(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void APiDemo_Test2()
        {
            //Arrange
            var actual = true;
            var expected = true;

            //Act

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}