using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factories.BulkReplacement
{
    public class DarkTheme : ITheme
    {
        public string TextColor => "white";

        public string BgrColor => "dark gray";
    }
}
