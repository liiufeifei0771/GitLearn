using GitLearn.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearn.Module
{
    internal class Banana : IFruit
    {   
        /// <summary>
        /// 成长函数
        /// </summary>
        /// <param name="age">成长年限</param>
        /// <returns>收成</returns>
        public int GrowUp(int age)
        {
            return age * 2;
        }
    }
}
