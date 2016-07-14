using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderMode
{
    public abstract class Builder
    {
        public abstract void BuildCPU();

        public abstract void BuildMainBoard();
        
        public abstract Computer GetComputer();

    }
}
