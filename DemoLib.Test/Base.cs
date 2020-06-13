using System;
using System.Text;
using Xunit;

namespace DemoLib.Test
{
    [Collection("Sequential")]
    public class Base
    {
        protected static readonly string s_codepageName = "windows-1252";

        protected static readonly string s_exceptionMessage = string.Concat(
            $"'{s_codepageName}' is not a supported encoding name.",
            " For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.",
            " (Parameter 'name')");

        protected static readonly Func<Encoding> GetEncoding = () => Encoding.GetEncoding(s_codepageName);
    }
}
