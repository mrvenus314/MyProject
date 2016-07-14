using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeMode
{
    public abstract class Graphics
    {
        public string Name;

        public Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }
}
