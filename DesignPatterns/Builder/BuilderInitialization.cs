using DesignPatterns.Builder.BuilderInheritance;
using DesignPatterns.Builder.FacetedBuilder;
using DesignPatterns.Builder.FunctionalBuilder;
using DesignPatterns.Builder.Html;
using DesignPatterns.Builder.StepwiseBuilder;
using System.Text;
using static System.Console;

namespace DesignPatterns.Builder
{
    public class BuilderInitialization
    {
        public static void HtmlBuilderIni()
        {
            // if you want to build a simple HTML paragraph using StringBuilder
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            WriteLine(sb);

            // now I want an HTML list with 2 words in it
            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            WriteLine(sb);

            // ordinary non-fluent builder
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            WriteLine(builder.ToString());

            // fluent builder
            sb.Clear();
            builder.Clear(); // disengage builder from the object it's building, then...
            builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
            WriteLine(builder);

        }

        public static void BuilderInheritenceInit()
        {
            var me = Person.New
                .Called("Ales")
                .WorksAsA("Coder")
                .Born(DateTime.Now)
                .Build();
            WriteLine(me);
        }

        public static void StepwiseBuilderInit()
        {
            var car = CarBuilder.Create()
                .OfType(CarType.Sedan)
                .WithWheels(16)
                .Build();
            WriteLine(car);
        }

        public static void FunctionalBuilderInit()
        {
            var employee = new EmployeeBuilder()
                .Called("Ales")
                .WorksAsA("Coder")
                .Build();

            WriteLine(employee);
        }

        public static void FacetedBuilderInit()
        {
            var pb = new StaffBuilder();
            Staff staff = pb
              .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
              .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);

            WriteLine(staff);
        }
    }
}
