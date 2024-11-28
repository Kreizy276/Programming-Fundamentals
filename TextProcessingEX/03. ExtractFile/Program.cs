using System;
using System.Text;

namespace _03._ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int extensionSep = text.LastIndexOf('.');
            int fileNameSep = text.LastIndexOf('\\');

            string fileName = text.Substring(fileNameSep + 1, extensionSep - fileNameSep - 1);
            string extension = text.Substring(extensionSep + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
