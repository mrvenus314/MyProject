using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMode
{
    public class Potato : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆好了！");
        }
    }
}
