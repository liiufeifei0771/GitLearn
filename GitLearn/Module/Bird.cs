﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn.Module
{
    class Bird:Animal
    {
        public Bird():base("喜鹊")
        {
            Console.WriteLine("这是鸟类的构造函数");
        }
    }
}
