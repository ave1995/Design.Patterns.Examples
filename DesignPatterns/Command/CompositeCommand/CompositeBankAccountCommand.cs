using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.CompositeCommand
{
    public abstract class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
    {
        public bool Success
        {
            get { return this.All(cmd => cmd.Success); }
            set
            {
                foreach (var cmd in this)
                    cmd.Success = value;
            }
        }

        public virtual void Call()
        {
            ForEach(cmd => cmd.Call());
        }

        public virtual void Undo()
        {
            foreach (var cmd in
                ((IEnumerable<BankAccountCommand>)this).Reverse()) //not mutating
            {
                if (cmd.Success) cmd.Undo();
            }
        }
    }
}
