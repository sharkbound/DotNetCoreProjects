using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visual_Studio_2015_CoreTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dirList = new List<string> { "bob", "jim", "billy" };
            var Dir = new DirectoryHelper();
            var dirName = "bob";

            var t = Task.Run(() =>
            {
                var sleepTime = 5;
                var start = DateTime.Now;
                Console.WriteLine($"Task sleeping for {sleepTime}!");

                var waitT = Task.Delay(sleepTime * 1000);
                Task.WaitAny(waitT);

                //Pre-C# 6.0 way to initialize a dictionary with values
                //var endTime = new Dictionary<string, float> {
                //    { "ms", (float)(DateTime.Now - start).TotalMilliseconds },
                //    { "s", (float)(DateTime.Now - start).TotalSeconds }
                //};

                //C# 6.0+ way to initialize a dictionary with values
                var endTime = new Dictionary<string, float> {
                     ["ms"] = (float)(DateTime.Now - start).TotalMilliseconds,
                     ["s"] = (float)(DateTime.Now - start).TotalSeconds
                };
                Console.WriteLine($"Task slept for {endTime["ms"]} Milliseconds! Or {endTime["s"]} Seconds!");
            }
            );

            Task.WaitAll(t);

            foreach (var dir in dirList)
            {
                Dir.CreateDirectory(dir, log: true);
            }

            foreach (var dir in dirList)
            {
                Dir.DeleteDirectory(dir, log: true);
            }

            //Console.ReadKey(true);
        }
    }
}
