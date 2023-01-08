using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.MementoCodingExercise
{
    public class Token
    {
        public int Value = 0;

        public Token(int value)
        {
            this.Value = value;
        }
    }

    public class Memento
    {
        public List<Token> Tokens = new List<Token>();

        public Memento(List<Token> tokens)
        {
            Tokens = tokens;
        }
    }

    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();

        public Memento AddToken(int value)
        {
            var token = new Token(value);
            Tokens.Add(token);
            return new Memento(Tokens.Select(t => new Token(t.Value)).ToList());
        }

        public Memento AddToken(Token token)
        {
            Tokens.Add(token);
            return new Memento(Tokens.Select(t => new Token(t.Value)).ToList());
        }

        public void Revert(Memento m)
        {
            Tokens = m.Tokens;
        }
    }
}
