using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18.QueuesStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the string s.
            string s = Console.ReadLine();
        
            // create the Solution class object p.
            QueueStack obj = new QueueStack();
        
            // push/enqueue all the characters of string s to stack.
            foreach (char c in s) {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }
        
            bool isPalindrome = true;
        
            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++) {
                if (obj.popCharacter() != obj.dequeueCharacter()) {
                    isPalindrome = false;
                
                    break;
                }
            }
        
            // finally print whether string s is palindrome or not.
            if (isPalindrome) {
                Console.Write("The word, {0}, is a palindrome.", s);
            } else {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }

    internal class QueueStack
    {
        private readonly Stack<char> _stack = new Stack<char>();
        private readonly Queue<char> _queue = new Queue<char>();

        private readonly LinkedList<char> _linkedList = new LinkedList<char>();
        
        public void pushCharacter(char c)
        {
            _stack.Push(c);
        }

        public int sizeOfStack()
        {
            return _stack.Count;
        }

        public char popCharacter()
        {
            return _stack.Pop();
        }

        public void enqueueCharacter(char c)
        {
            _linkedList.AddLast(c);
            // _queue.Enqueue(c);
        }

        public char dequeueCharacter()
        {
            var first = _linkedList.First();
            _linkedList.RemoveFirst();
            return first;
            // return _queue.Dequeue();
        }

        public int sizeOfQueue()
        {
            return _queue.Count;
        }
        
    }
}