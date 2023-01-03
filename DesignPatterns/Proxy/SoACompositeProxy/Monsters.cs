using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.SoACompositeProxy
{
    public class Monsters
    {
        private readonly int size;
        private byte[] age;
        private int[] x, y;

        public Monsters(int size)
        {
            this.size = size;
            age = new byte[size];
            x = new int[size];
            y = new int[size];
        }

        public struct CreatureProxy
        {
            private readonly Monsters monsters;
            private readonly int index;

            public CreatureProxy(Monsters monsters, int index)
            {
                this.monsters = monsters;
                this.index = index;
            }

            public ref byte Age => ref monsters.age[index];
            public ref int X => ref monsters.x[index];
            public ref int Y => ref monsters.y[index];
        }

        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for (int pos = 0; pos < size; ++pos)
                yield return new CreatureProxy(this, pos);
        }
    }
}
