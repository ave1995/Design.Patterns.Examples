using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight.FlyweighCodingExercise
{
    public class Sentence
    {
        private WordToken[] words;

        public Sentence(string plainText)
        {
            words = plainText.Split(' ').Select(w => new WordToken { Text = w}).ToArray();
        }

        public WordToken this[int index]
        {
            get
            {
                if (index < words.Length)
                    return words[index];
                else
                    return null;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                var c = words[i];
                sb.Append(words[i].Capitalize ? c.Text.ToUpper() : c.Text);
                if (i != words.Length - 1)
                    sb.Append(" ");
            }
            return sb.ToString();
        }

        public class WordToken
        {
            public bool Capitalize;

            public string Text;
        }
    }
}
