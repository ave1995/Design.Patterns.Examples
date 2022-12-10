using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Example
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing pixels for circle of radius {radius}");
        }
    }
}
