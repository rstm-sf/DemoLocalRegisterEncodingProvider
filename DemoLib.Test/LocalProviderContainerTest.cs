using System;
using System.Text;
using Xunit;

namespace DemoLib.Test
{
    public class LocalProviderContainerTest
    {
        private static readonly string s_codepageName = "windows-1252";

        private static readonly string s_exceptionMessage = string.Concat(
            $"'{s_codepageName}' is not a supported encoding name.",
            " For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.",
            " (Parameter 'name')");

        [Fact]
        public void TestLocalGetEncoding()
        {
            var encoding = LocalProviderContainer.GetEncoding(s_codepageName);
            Assert.NotNull(encoding);
        }

        [Fact]
        public void TestGlobalGetEncoding()
        {
            var action = new Action(() => Encoding.GetEncoding(s_codepageName));
            var exception = Assert.Throws<ArgumentException>(action);
            Assert.Equal(s_exceptionMessage, exception.Message);
        }
    }
}
