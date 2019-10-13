using System;
using System.Collections.Generic;
using System.Linq;

namespace Huiswerk2
{
    public static class BracketChecker
    {

        public static bool CheckBrackets(string s)
        {
            string leftBracketString = "(";
            char leftBracket = leftBracketString[0];

            bool valid = true;
            int count = 0;

            MyStack<string> stack = new MyStack<string>();
            
            foreach(char c in s)
            {
                if (c.Equals(leftBracket))
                {
                    stack.Push(c.ToString());
                    count++;
                } else
                {
                    if (!stack.IsEmpty())
                    {
                        if (stack.Top().Equals(leftBracketString))
                        {
                            stack.Pop();
                            count--;
                        }
                        else
                        {
                            valid = false;
                        }
                    } else
                    {
                        valid = false;
                    }
                }
            }
            
            if (count != 0)
            {
                valid = false;
            }

            return valid;
        }

        public static bool CheckBrackets2(string s)
        {
            var stack = new MyStack<char>();
            
            var allowedChars = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };

            var wellFormated = true;
            foreach (var chr in s)
            {
                if (allowedChars.ContainsKey(chr))
                {
                    stack.Push(chr);
                }
                
                else if (allowedChars.ContainsValue(chr))
                {
                    var startingChar = stack.Pop();
                    wellFormated = allowedChars.Contains(new KeyValuePair<char, char>(startingChar, chr));
                   
                    if (!wellFormated)
                    {
                        break;
                    }
                }
            }
            return wellFormated;
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
