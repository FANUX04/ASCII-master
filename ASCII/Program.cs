using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("inserisci una frase");
            //string unicodestring = Console.ReadLine();

            string unicodestring =
                "this string has 2 characters outside the" +
                "ASCII range: \n" +
                "radiazione (\u2622) , and sigma (\u03A0).";
            Console.WriteLine("stringa originale/original string");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodestring);
            Console.WriteLine();
        }
    }
}
