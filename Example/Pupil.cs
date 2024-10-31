using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Pupil : Student
    {
        public override void Sport()
        {
            Console.WriteLine("小学生在跑步！");
        }
    }
}
