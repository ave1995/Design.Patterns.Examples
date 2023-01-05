using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.BrokerChain
{
    public class Game // mediator pattern
    {
        public event EventHandler<Query> Queries; // effectively a chain

        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}
