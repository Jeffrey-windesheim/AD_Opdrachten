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
            throw new System.NotImplementedException();
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
