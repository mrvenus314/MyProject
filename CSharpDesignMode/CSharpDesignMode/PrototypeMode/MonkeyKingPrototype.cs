using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeMode
{
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }

        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        public abstract MonkeyKingPrototype Clone();

        public abstract void Show();

    }
}
