using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.Broker
{
    public class FootballPlayer : Actor
    {
        private IDisposable sub;
        public string Name { get; set; } = "Unknown Player";
        public int GoalsScored { get; set; } = 0;

        public void Score()
        {
            GoalsScored++;
            broker.Publish(new PlayerScoredEvent { Name = Name, GoalsScored = GoalsScored });
        }

        public void AssaultReferee()
        {
            broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = "violence" });

        }

        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;

            broker.OfType<PlayerScoredEvent>()
              .Where(ps => !ps.Name.Equals(name))
              .Subscribe(ps => Console.WriteLine($"{name}: Nicely scored, {ps.Name}! It's your {ps.GoalsScored} goal!"));

            sub = broker.OfType<PlayerSentOffEvent>()
              .Where(ps => !ps.Name.Equals(name))
              .Subscribe(ps => Console.WriteLine($"{name}: See you in the lockers, {ps.Name}."));
        }
    }
}
