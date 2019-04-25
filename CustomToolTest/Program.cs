using System;
using System.Linq;
using System.Reflection;

namespace CustomToolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var allTypes = from type in Assembly.GetExecutingAssembly().GetTypes()
                           select type.FullName;
            foreach (var type in allTypes)
                Console.WriteLine(type);
        }
    }
}
