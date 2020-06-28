using System.Text;

namespace DemoLib
{
    public static class LocalProviderContainer
    {
        public static Encoding GetEncoding(string codepageName) =>
            CodePagesEncodingProvider.Instance.GetEncoding(codepageName)
            ?? Encoding.GetEncoding(codepageName);
    }
}
