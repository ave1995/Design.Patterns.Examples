using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy.ValueProxy
{
    public static class PercentageExtensions
    {
        public static Percentage Percent(this int value)
        {
            return new Percentage(value / 100.0f);
        }

        public static Percentage Percent(this float value)
        {
            return new Percentage(value / 100.0f);
        }
    }
}
