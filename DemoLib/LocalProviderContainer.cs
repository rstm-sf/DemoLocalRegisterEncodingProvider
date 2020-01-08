using System.Text;

namespace DemoLib
{
    public class LocalProviderContainer
    {
        static LocalProviderContainer() => Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        public static Encoding GetEncoding(string codepageName) => Encoding.GetEncoding(codepageName);
    }
}
