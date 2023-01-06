using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.CompositeCommand
{
    public interface ICommand
    {
        public void Call();
        public void Undo();
        public bool Success { get; set; }
    }
}
