using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesman salesman = new Salesman();
            Nures nures = new Nures();
            Bird bird = new Bird();

            List<ISing> list = new List<ISing>();
            list.Add(salesman);
            list.Add(nures);
            list.Add(bird);
            foreach (ISing item in list)
            {
                item.Sing();
            }
        }
    }
}
