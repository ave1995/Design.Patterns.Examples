using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State.LockExercise
{
    public class CombinationLock
    {
        public CombinationLock(int[] combination)
        {
            RightCombination = combination;
        }

        private string status = "LOCKED";
        // you need to be changing this on user input
        public string Status
        {
            get => UserCombination.Count != 0 && RightCombination.Length != UserCombination.Count ? string.Join("", UserCombination) : status;
            private set => status = value;
        }

        private int[] RightCombination { get; set; }

        private List<int> UserCombination { get; } = new List<int>();

        public void EnterDigit(int digit)
        {
            if (Status == "OPEN" || Status == "ERROR") ClearCombination();

            UserCombination.Add(digit);

            if (RightCombination.Length > UserCombination.Count)
                return;

            if (RightCombination.SequenceEqual(UserCombination))
            {
                Status = "OPEN";
            }
            else
            {
                Status = "ERROR";
            }
        }

        public void ClearCombination()
        {
            UserCombination.Clear();
            Status = "LOCKED";
        }
    }
}
