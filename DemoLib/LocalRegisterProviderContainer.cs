using System.Text;

namespace DemoLib
{
    public static class LocalRegisterProviderContainer
    {
        static LocalRegisterProviderContainer() => Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        public static Encoding GetEncoding(string codepageName) => Encoding.GetEncoding(codepageName);
    }
}
