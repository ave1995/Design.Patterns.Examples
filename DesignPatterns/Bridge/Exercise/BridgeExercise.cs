using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge.Exercise
{
    public abstract class Shape
    {
        public string Name { get; set; }

        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override string ToString() => renderer.WhatToRenderAs(Name);
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) => Name = "Triangle";
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) => Name = "Square";
    }

    public class VectorRenderer : IRenderer
    {
        string IRenderer.WhatToRenderAs(string name) => $"Drawing {name} as lines";
    }

    public class RasterRenderer : IRenderer
    {
        string IRenderer.WhatToRenderAs(string name) => $"Drawing {name} as pixels";
    }


    public interface IRenderer
    {
        string WhatToRenderAs(string name);
    }
}
