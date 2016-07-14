using AbstractFactoryMode.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryMode
{
    public class ShangHaiYaBo :YaBo
    {
        public override void Print()
        {
            Console.WriteLine("上海的鸭脖");
        }
    }
}
