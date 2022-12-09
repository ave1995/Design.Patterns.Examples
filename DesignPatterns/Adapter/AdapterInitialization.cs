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

    }
}
