using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Visual_Studio_2015_CoreTestApp
{
    public class DirectoryHelper
    {
        public void CreateDirectory(string path, bool log = false)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                if (log)
                {
                    var prevColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Created directory {path}!");
                    Console.ForegroundColor = prevColor;
                }
            }
        }

        public void DeleteDirectory(string path, bool log = false)
        {
            if (Exist(path))
            {
                Directory.Delete(path);
                if (log)
                {
                    var prevColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Deleted directory {path}!");
                    Console.ForegroundColor = prevColor;
                }
            }
        }

        public bool Exist(string path)
        {
            return Directory.Exists(path);
        }
    }
}
