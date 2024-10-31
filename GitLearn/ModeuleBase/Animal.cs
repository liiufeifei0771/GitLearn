using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn.Module
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("这是动物类的构造函数");
        }

        public Animal(string name)
        {
            this.Name = name;
            Console.WriteLine("这是动物类的有参构造函数");
        }

        private string name;

        public string Name { get => name; set => name = value; }

        public  void Shout()
        {
            Console.WriteLine("{0}发出了声音",this.Name);
        }
    }
}
