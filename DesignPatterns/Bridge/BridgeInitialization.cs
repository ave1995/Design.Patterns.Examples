using DesignPatterns.Bridge.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class BridgeInitialization
    {
        public static void BridgeExampleInit()
        {
            var raster = new RasterRenderer();
            var vector = new VectorRenderer();
            var circle = new Circle(vector, 5);
            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}
