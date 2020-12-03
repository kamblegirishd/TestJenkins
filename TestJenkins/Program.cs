using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(CreateMessage());
            Console.ReadLine();
        }

        private static string CreateMessage()
        {
            return "Hello World";
        }
    }
}
