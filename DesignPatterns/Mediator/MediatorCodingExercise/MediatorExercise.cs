using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.MediatorCodingExercise
{
    public class Participant
    {
        public int Value { get; set; } = 0;

        public Mediator Mediator { get; set; }

        public Participant(Mediator mediator)
        {
            Mediator = mediator;
            Mediator.AddParticipant(this);
        }

        public void Say(int n)
        {
            Mediator.Broadcast(this, n);
        }
        public void Receive(int n)
        {
            Value = n;
        }

    }

    public class Mediator
    {
        private List<Participant> Participants = new List<Participant>();

        public void Broadcast(Participant source, int value)
        {
            foreach (var p in Participants)
                if (p != source)
                    p.Receive(value);
        }

        public void AddParticipant(Participant participant)
        {
            Participants.Add(participant);
        }
    }

    //public class Participant
    //{
    //    private readonly Mediator mediator;
    //    public int Value { get; set; }

    //    public Participant(Mediator mediator)
    //    {
    //        this.mediator = mediator;
    //        mediator.Alert += Mediator_Alert;
    //    }

    //    private void Mediator_Alert(object sender, int e)
    //    {
    //        if (sender != this)
    //            Value += e;
    //    }

    //    public void Say(int n)
    //    {
    //        mediator.Broadcast(this, n);
    //    }
    //}

    //public class Mediator
    //{
    //    public void Broadcast(object sender, int n)
    //    {
    //        Alert?.Invoke(sender, n);
    //    }

    //    public event EventHandler<int> Alert;
    //}
}
