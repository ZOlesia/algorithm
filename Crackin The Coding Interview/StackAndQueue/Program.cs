using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackAndQueue
{
    class Program
    {
        public static void sortStack(Stack<int> s)
        {
            Stack<int> tempStack = new Stack<int>();
            while(s.Count != 0)
            {
                var min = s.Pop();

                while(tempStack.Count != 0 && tempStack.Peek() > min)
                {
                    s.Push(tempStack.Pop());
                }

                tempStack.Push(min);
            }

            while(tempStack.Count != 0)
            {
                s.Push(tempStack.Pop());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
