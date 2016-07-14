using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMode
{
    public class Egg : Food
    {
        public override void Print()
        {
            Console.WriteLine("鸡蛋好了！");
        }
    }
}
