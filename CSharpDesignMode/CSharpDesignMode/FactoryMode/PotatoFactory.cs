using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMode
{
    public class PotatoFactory : Factory
    {
        public override Food CreateFoodFactory()
        {
            return new Potato();
        }
    }
}
