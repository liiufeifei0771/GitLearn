using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// 学生抽象类
    /// </summary>
    abstract class Student
    {
        private string name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 运动方法
        /// </summary>
        public abstract void Sport();
    }
}
