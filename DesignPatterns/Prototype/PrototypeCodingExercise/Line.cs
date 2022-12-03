using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.PrototypeCodingExercise
{
    public class Line
    {
        public Point Start, End;
        public Line DeepCopy()
        {
            Line newLine = new()
            {
                Start = Start.DeepCopy(),
                End = End.DeepCopy()
            };
            return newLine;
        }
    }
}
