using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryMode.Product
{
    public abstract class NanChangYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("南昌的鸭脖");
        }
    }
}
