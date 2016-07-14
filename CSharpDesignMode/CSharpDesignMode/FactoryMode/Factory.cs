using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMode
{
    public abstract class Factory
    {
        public abstract Food CreateFoodFactory();
    }
}
