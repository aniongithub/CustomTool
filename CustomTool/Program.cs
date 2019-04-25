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
            File.WriteAllText(Path.Combine(Path.GetDirectoryName(args[0]), "CustomTool.g.cs"), "public sealed class Test {  }");
        }
    }
}
