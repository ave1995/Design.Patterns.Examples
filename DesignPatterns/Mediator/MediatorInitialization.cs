using Autofac;
using DesignPatterns.Mediator.Broker;
using DesignPatterns.Mediator.ChatRoom;
using DesignPatterns.Mediator.SimpleMediatRDemo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class MediatorInitialization
    {
        public static void ChatRoomInit()
        {
            var room = new ChatRoom.ChatRoom();

            var john = new Person("John");
            var jane = new Person("Jane");

            room.Join(john);
            room.Join(jane);

            john.Say("hi room");
            jane.Say("oh, hey john");

            var simon = new Person("Simon");
            room.Join(simon);
            simon.Say("hi everyone!");

            jane.PrivateMessage("Simon", "glad you could join us!");
        }

        public static void EventBrokerInit()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<EventBroker>().SingleInstance();
            cb.RegisterType<FootballCoach>();
            cb.RegisterType<Ref>();
            cb.Register((c, p) => new FootballPlayer(c.Resolve<EventBroker>(), p.Named<string>("name")));

            using (var c = cb.Build())
            {
                var referee = c.Resolve<Ref>(); // order matters here!
                var coach = c.Resolve<FootballCoach>();
                var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
                var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));
                player1.Score();
                player1.Score();
                player1.Score(); // only 2 notifications
                player1.AssaultReferee();
                player2.Score();
            }
        }

        public static void SimpleMediatRDemo()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MediatR.Mediator>()
              .As<IMediator>()
              .InstancePerLifetimeScope(); // singleton

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(MediatorInitialization).Assembly)
              .AsImplementedInterfaces();

            var container = builder.Build();
            var mediator = container.Resolve<IMediator>();
            var response = mediator.Send(new PingCommand()).Result;
            Console.WriteLine($"We got a pong at {response.Timestamp}");
        }

        public static void MediatorCodingExerciseInit()
        {
            var mediator = new MediatorCodingExercise.Mediator();

            var participant1 = new MediatorCodingExercise.Participant(mediator);
            var participant2 = new MediatorCodingExercise.Participant(mediator);
            var participant3 = new MediatorCodingExercise.Participant(mediator);

            participant1.Say(5);
        }
    }
}
