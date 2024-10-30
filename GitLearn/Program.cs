using GitLearn.Module;
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
            Banana banana = new Banana();
            var a= banana.GrowUp(10);
            Console.WriteLine("Banana 成长{0}年后，收获了{1}斤",10,a);
            Console.Read();
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
