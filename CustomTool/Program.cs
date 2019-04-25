using System;
using System.IO;
using System.Linq;

namespace CustomTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Arguments: {string.Join(' ', args)}");
            File.WriteAllText(args[1], "public sealed class Test {  }");
        }
    }
}
