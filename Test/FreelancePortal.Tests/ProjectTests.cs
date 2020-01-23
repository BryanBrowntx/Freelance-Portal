using System;
using Xunit;

namespace FreelancePortal.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FooTest()
        {
            // arrange
            var x = 5;
            var y = 2;
            var expected = 7;

            // act
            var actual = x * y;

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
