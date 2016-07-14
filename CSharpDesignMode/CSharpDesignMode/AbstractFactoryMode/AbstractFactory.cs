using AbstractFactoryMode.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryMode
{
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJIa();
    }
}
