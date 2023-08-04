using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.SwitchExpressions
{
    public enum Chest
    {
        Open,
        Closed,
        Locked
    }

    public enum Action
    {
        Open,
        Close
    }
    public class SwitchExpressions
    {
        public static Chest Manipulate(Chest chest,
          Action action, bool haveKey) =>
          (chest, action, haveKey) switch
          {
              (Chest.Closed, Action.Open, _) => Chest.Open,
              (Chest.Locked, Action.Open, true) => Chest.Open,
              (Chest.Open, Action.Close, true) => Chest.Locked,
              (Chest.Open, Action.Close, false) => Chest.Closed,

              _ => chest
          };
    }
}
