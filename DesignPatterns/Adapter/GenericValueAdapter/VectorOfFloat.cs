using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.GenericValueAdapter
{
    public class VectorOfFloat<TSelf, D>
        : Vector<TSelf, float, D>
        where TSelf : Vector<TSelf, float, D>, new()
        where D : IInteger, new()
    {
    }
}
