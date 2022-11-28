using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.BuilderCodingExercise
{
    //  You are asked to implement the Builder design pattern for rendering simple chunks of code.

    //  Sample use of the builder you are asked to create:

    //      var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
    //      Console.WriteLine(cb);

    //  The expected output of the above code is:

    //      public class Person
    //      {
    //          public string Name;
    //          public int Age;
    //      }

    //  Please observe the same placement of curly braces and use two-space indentation.
    public class CodeBuilder
    {
        private readonly string rootName;
        CodeElement root = new();

        public CodeBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public CodeBuilder AddField(string childName, string childText)
        {
            var e = new CodeElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }

    public class CodeElement
    {
        public string Name;
        public string Type = "class";
        public List<CodeElement> Elements = new List<CodeElement>();
        private const int indentSize = 2;

        private const string publicString = "public";
        private const string semicolon = ";";


        public CodeElement()
        {

        }
        public CodeElement(string name, string type)
        {
            Name = name;
            Type = type;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{publicString} {Type} {Name}\n");
            sb.Append('{');
            sb.Append("\n");
            foreach (var e in Elements)
            {
                if (!string.IsNullOrWhiteSpace(e.Name))
                {
                    sb.Append(i);
                    sb.Append($"{publicString} {e.Type} {e.Name}{semicolon}\n");
                    
                }
            }
            sb.Append('}');
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(2);
        }
    }
}
