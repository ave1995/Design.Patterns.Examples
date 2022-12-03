using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.PrototypeCodingExercise
{
    public class Point
    {
        public int X, Y;
        public Point DeepCopy()
        {
            Point newPoint = new()
            {
                X = X,
                Y = Y
            };
            return newPoint;
        }
    }
}
