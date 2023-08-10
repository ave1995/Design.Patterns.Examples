using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy_Policy_.DynamicStrategy
{
    public class HtmlListStrategy : IListStrategy
    {
        public void Start(StringBuilder sb)
        {
            sb.AppendLine("<ul>");
        }

        public void End(StringBuilder sb)
        {
            sb.AppendLine("</ul>");
        }

        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($"  <li>{item}</li>");
        }
    }
}
