using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Dir = @"\TextFile";
            Console.WriteLine("Hello World!");
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\TextFile");
            File.CreateText(Directory.GetCurrentDirectory() + @"\TextFile\text.txt");
            if (File.Exists(Dir))
            {
                Console.WriteLine("File Found!");
            }
            Console.ReadKey();
            Console.WriteLine("Done...");
        }
    }
}
