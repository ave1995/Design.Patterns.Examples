using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.SimpleMediatRDemo
{
    public class PingCommand : IRequest<PongResponse>
    {
        // nothing here
    }
}
