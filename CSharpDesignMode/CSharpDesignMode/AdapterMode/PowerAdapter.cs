using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterMode
{
    public class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}
