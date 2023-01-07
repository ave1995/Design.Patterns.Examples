using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter.InterpreterCodingExercise
{
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public enum Operation
        {
            Plus,
            Minus,
            None
        }
        public int Calculate(string expression)
        {
            Operation operation = Operation.None;

            string left = "";
            string right = "";

            for (int i = 0; i < expression.Length; i++)
            {
                if (!char.IsDigit(expression[i]))
                {
                    switch (expression[i])
                    {
                        case '+':
                            if (operation is Operation.Plus)
                            {
                                left = (int.Parse(left) + int.Parse(right)).ToString();
                                right = "";
                            }
                            else if (operation is Operation.Minus)
                            {
                                left = (int.Parse(left) - int.Parse(right)).ToString();
                                right = "";
                            }
                            operation = Operation.Plus;
                            break;
                        case '-':
                            if (operation is Operation.Plus)
                            {
                                left = (int.Parse(left) + int.Parse(right)).ToString();
                                right = "";
                            }
                            else if (operation is Operation.Minus)
                            {
                                left = (int.Parse(left) - int.Parse(right)).ToString();
                                right = "";
                            }
                            operation = Operation.Minus;
                            break;
                        default:
                            if (Variables.ContainsKey(expression[i]))
                            {
                                if (operation is Operation.None)
                                {
                                    left += Variables[expression[i]].ToString();
                                }
                                else
                                {
                                    right += Variables[expression[i]].ToString();
                                }
                            }
                            else
                            {
                                return 0;
                            }
                            break;
                    }
                    continue;
                }
                if (char.IsDigit(expression[i]) && operation is Operation.None)
                {
                    left += expression[i];
                    continue;
                }
                else
                {
                    right += expression[i];
                    continue;
                }
            }

            if (operation is Operation.Plus)
            {
                left = (int.Parse(left) + int.Parse(right)).ToString();
            }
            else if (operation is Operation.Minus)
            {
                left = (int.Parse(left) - int.Parse(right)).ToString();
            }

            return int.Parse(left);
        }
    }
}

    //public class ExpressionProcessor
    //{
    //    public Dictionary<char, int> Variables = new Dictionary<char, int>();

    //    public enum NextOp
    //    {
    //        Nothing,
    //        Plus,
    //        Minus
    //    }

    //    public int Calculate(string expression)
    //    {
    //        int current = 0;
    //        var nextOp = NextOp.Nothing;

    //        var parts = Regex.Split(expression, @"(?<=[+-])");

    //        foreach (var part in parts)
    //        {
    //            var noOp = part.Split(new[] { "+", "-" }, StringSplitOptions.RemoveEmptyEntries);
    //            var first = noOp[0];
    //            int value, z;

    //            if (int.TryParse(first, out z))
    //                value = z;
    //            else if (first.Length == 1 && Variables.ContainsKey(first[0]))
    //                value = Variables[first[0]];
    //            else return 0;

    //            switch (nextOp)
    //            {
    //                case NextOp.Nothing:
    //                    current = value;
    //                    break;
    //                case NextOp.Plus:
    //                    current += value;
    //                    break;
    //                case NextOp.Minus:
    //                    current -= value;
    //                    break;
    //            }

    //            if (part.EndsWith("+")) nextOp = NextOp.Plus;
    //            else if (part.EndsWith("-")) nextOp = NextOp.Minus;
    //        }
    //        return current;
    //    }
    //}
