using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeMode
{
    public class Cloned : MonkeyKingPrototype
    {
        public Cloned(string id)
            : base(id)
        {

        }

        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }

        public override void Show()
        {
            Console.WriteLine(this.Id);
        }
    }
}
