using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento pattern!
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // breaks single responsibility principle, moved to a new class
        //public static void SaveToFile(Journal journal, string filename, bool overwrite = false)
        //{
        //    if (overwrite || !File.Exists(filename))
        //        File.WriteAllText(filename, journal.ToString());
        //}
    }
}
