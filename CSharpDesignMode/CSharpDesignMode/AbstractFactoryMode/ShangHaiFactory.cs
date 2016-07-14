using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryMode
{
    public class ShangHaiFactory : AbstractFactory
    {

        public override Product.YaBo CreateYaBo()
        {
            return new ShangHaiYaBo();
        }

        public override Product.YaJia CreateYaJIa()
        {
            throw new NotImplementedException();
        }
    }
}
