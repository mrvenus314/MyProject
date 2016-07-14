using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeMode
{
    public class ComplexGraphics : Graphics
    {
        private List<Graphics> list = new List<Graphics>();

        public ComplexGraphics(string name)
            : base(name)
        {

        }

        public override void Draw()
        {
            foreach (Graphics item in list)
            {
                item.Draw();
            }
        }

        public void Add(Graphics g)
        {
            list.Add(g);
        }

        public void Remove(Graphics g)
        {
            if (list.Contains(g))
                list.Remove(g);
        }
    }
}
