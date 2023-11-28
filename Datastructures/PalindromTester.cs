using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public static class PalindromTester
    {
        public static bool IsPalindrom(string input)
        {
            var inputLength = input.Length;
            
            Stack<char> myStack = new();
            foreach (var c in input)
                myStack.Push(c);

            for (var i = 0; i < inputLength / 2; i++)
            {
                var charFromStack = myStack.Pop();
                if (input[i] != charFromStack)
                    return false;
            }
            return true;
        }
    }
}