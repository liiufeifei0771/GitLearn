using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            String ver = "1.0";
            int a = 1;
            int b = 2;
            var result = Add(a, b);
            Console.WriteLine("{0}+{1} result is {2}", a, b, result);
            Console.Read();
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
