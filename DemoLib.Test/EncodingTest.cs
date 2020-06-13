using System;
using Xunit;

namespace DemoLib.Test
{
    public class EncodingTest : Base
    {
        [Fact]
        public void Test_GlobalGetEncoding()
        {
            var exception = Assert.Throws<ArgumentException>(GetEncoding);
            Assert.Equal(s_exceptionMessage, exception.Message);
        }
    }
}
