using GitLearn.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn.Module
{
    public class Apple : IFruit
    {
        public int GrowUp(int age)
        {
            return age * 10;
        }
    }
}
