using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Person:IComparable<Person>
    {
        private string name;

        private int age;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        public Person()
        {

        }

        public Person(string name ,int age)
        {
            this.Name = name;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine("大家好，我是{0}，我今年{1}岁", this.Name, this.Age);
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo( other.Age);
        }
    }
}
