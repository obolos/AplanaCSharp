using System.Text;

namespace AplanaCSharp
{
    public class Helper
    {
        public static void Init()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.InputEncoding = enc1251;
        }
        
    }
}