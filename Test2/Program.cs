using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter.Hello();
            Greeter.Goodbye();
            Console.WriteLine("And goodbye!");
            Greeter.Friday();
        }
    }

    static class Greeter
    {
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
        public static void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }
        public static void Friday()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
