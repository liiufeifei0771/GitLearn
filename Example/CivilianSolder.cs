using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// 文艺兵类
    /// </summary>
    class CivilianSolder : Solder, IPerformance
    {
        public void Show()
        {
            Console.WriteLine("文艺兵在表演舞蹈！");
        }
    }
}
