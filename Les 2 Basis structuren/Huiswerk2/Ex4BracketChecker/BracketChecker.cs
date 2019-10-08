using System;

namespace Huiswerk2
{
    public static class BracketChecker
    {

        public static bool CheckBrackets(string s)
        {
            string leftBracketString = "(";
            char leftBracket = leftBracketString[0];

            bool valid = true;

            MyStack<char> stack = new MyStack<char>();
            
            foreach(char c in s)
            {
                if (c.Equals(leftBracket))
                {
                    stack.Push(c);
                } else
                {
                    if(stack.Top().Equals(leftBracket))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }
                 
            }

            return valid;
        }

        public static bool CheckBrackets2(string s)
        {
            throw new System.NotImplementedException();
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
