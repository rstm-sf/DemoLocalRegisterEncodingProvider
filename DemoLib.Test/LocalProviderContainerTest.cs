using Xunit;

namespace DemoLib.Test
{
    public class LocalProviderContainerTest : Base
    {
        [Fact]
        public void TestA_LocalGetEncoding()
        {
            var encoding = LocalProviderContainer.GetEncoding(s_codepageName);
            Assert.Equal(s_codepageName, encoding.WebName);
        }

        [Fact]
        public void TestB_GlobalGetEncoding()
        {
            var encoding = GetEncoding.Invoke();
            Assert.Equal(s_codepageName, encoding.WebName);
        }
    }
}
