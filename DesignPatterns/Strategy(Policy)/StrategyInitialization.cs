using DesignPatterns.Strategy_Policy_.DynamicStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns.Strategy_Policy_
{
    public class StrategyInitialization
    {
        public static void DynamicStrategyInit()
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            WriteLine(tp);

            tp.Clear();
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] { "foo", "bar", "baz" });
            WriteLine(tp);
        }
    }
}
