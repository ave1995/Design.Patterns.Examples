using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.HandmadeStateMachine
{
    public static class HandmadeStateMachine
    {
        public static Dictionary<State, List<(Trigger, State)>> rules = new()
        {
              [State.OffHook] = new List<(Trigger, State)>
            {
              (Trigger.CallDialed, State.Connecting)
            },
              [State.Connecting] = new List<(Trigger, State)>
            {
              (Trigger.HungUp, State.OffHook),
              (Trigger.CallConnected, State.Connected)
            },
              [State.Connected] = new List<(Trigger, State)>
            {
              (Trigger.LeftMessage, State.OffHook),
              (Trigger.HungUp, State.OffHook),
              (Trigger.PlacedOnHold, State.OnHold)
            },
              [State.OnHold] = new List<(Trigger, State)>
            {
              (Trigger.TakenOffHold, State.Connected),
              (Trigger.HungUp, State.OffHook)
            }
          };
    }
    public enum State
    {
        OffHook,
        Connecting,
        Connected,
        OnHold
    }

    public enum Trigger
    {
        CallDialed,
        HungUp,
        CallConnected,
        PlacedOnHold,
        TakenOffHold,
        LeftMessage
    }
}
