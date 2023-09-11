using System.Security.Cryptography.X509Certificates;

namespace _1._3Uzduotis_Ref_Out
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = "    labas   ";
            TrimAndCapitalize(ref text);
            Console.WriteLine(text);
        }
        public static void TrimAndCapitalize(ref string text)
        {
            text = text.Trim();
            text = char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}