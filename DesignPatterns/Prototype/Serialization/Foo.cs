using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Serialization
{
    [Serializable] // this is, unfortunately, required
    public class Foo
    {
        public uint Stuff;
        public string Whatever;

        public override string ToString()
        {
            return $"{nameof(Stuff)}: {Stuff}, {nameof(Whatever)}: {Whatever}";
        }
    }
}
