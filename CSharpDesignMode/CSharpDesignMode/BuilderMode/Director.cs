using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderMode
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildCPU();
            builder.BuildMainBoard();
        }
    }
}
