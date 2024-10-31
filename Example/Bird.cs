using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Bird : ISing

    {
        public void Sing()
        {
            Console.WriteLine("鸟类在唱歌");
        }
    }
}
