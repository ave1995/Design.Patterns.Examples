using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Broker
{
    public class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }
    }
}
