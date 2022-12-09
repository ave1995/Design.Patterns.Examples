using DesignPatterns.Adapter.GenericValueAdapter;
using DesignPatterns.Adapter.LineToPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class AdapterInitialization
    {
        #region LineToPoint
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
        {
            new VectorRectangle(1, 1, 10, 10),
            new VectorRectangle(3, 3, 6, 6)
        };

        // the interface we have
        private static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ToList().ForEach(DrawPoint);
                    Console.WriteLine();
                }
            }
        }

        public static void LineToPointInit()
        {
            Draw();
            Console.WriteLine();
            Draw();
        }
        #endregion

        #region GenericValueAdapter

        public static void GenericValueAdapterInit()
        {
            var v = new Vector2i(1, 2);
            v[0] = 0;

            var vv = new Vector2i(3, 2);

            var result = v + vv;

            Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
        }
        #endregion

    }
}
