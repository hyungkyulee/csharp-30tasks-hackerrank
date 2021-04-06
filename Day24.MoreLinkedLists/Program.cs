using System;
using Microsoft.VisualBasic.FileIO;

namespace Day24.MoreLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            var T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }

            head = RemoveDuplicates(head);
            Display(head);
            
        }

        // 0xaa -> 0xab -> 0xac -> 0xac -> null
        //  4       3       3       1 
        // temp = 0xac
        // 
        private static Node RemoveDuplicates(Node head)
        {
            var indicator = head;
            Node updatedNode = null;
            updatedNode = Insert(updatedNode, indicator.Data);
            while (indicator.Next != null)
            {
                if (!indicator.Data.Equals(indicator.Next.Data))
                {
                    updatedNode = Insert(updatedNode, indicator.Next.Data);
                }
                
                indicator = indicator.Next;
            }

            return updatedNode;
        }

        private static Node Insert(Node head, int data)
        {
            var node = new Node(data);
            if (head == null)
            {
                head = node;
                return head;
            }

            var indicator = head;
            while (indicator.Next != null)
            {
                indicator = indicator.Next;
            }

            indicator.Next = node;
            return head;
        }
        
        private static void Display(Node head)
        {
            var indicator = head;
            while(indicator != null)
            {
                Console.Write(indicator.Data + " ");
                indicator = indicator.Next;
            }
        }
    }

    internal class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    
}