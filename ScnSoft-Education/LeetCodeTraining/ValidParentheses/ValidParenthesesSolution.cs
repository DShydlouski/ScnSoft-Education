using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTraining.ValidParentheses
{
    public static class ValidParenthesesSolution
    {
        public static bool IsValid(string s)
        {
            if (s == null || s.Length == 1)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> map = new Dictionary<char, char>();

            map.Add(')', '(');
            map.Add(']', '[');
            map.Add('}', '{');

            foreach (char letter in s)
            {
                if (!map.ContainsKey(letter))
                {
                    stack.Push(letter);
                }

                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char open = stack.Pop();
                    char value = map[letter];
                    if (value != open)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
