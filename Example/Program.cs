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
            Person ma = new Person("马化腾", 22);
            Person lei = new Person("雷军", 21);
            Person chen = new Person("陈天桥", 23);
            List<Person> people = new List<Person>();
            people.Add(ma);
            people.Add(lei);
            people.Add(chen);
            foreach (Person item in people)
            {
                item.Show();
            }

            people.Sort();
            Console.WriteLine("=============排序后===============");
            foreach (Person item in people)
            {
                item.Show();
            }

        }
    }
}
