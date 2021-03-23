using System;

namespace Day15.LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d){
            data=d;
            next=null;
        }
		
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Node head=null;
                // var tr1 = __makeref(head);
                // IntPtr ptr1 = **(IntPtr**) (&tr1);
                // Console.WriteLine($"init : {ptr1}");
                
                int T = Int32.Parse(Console.ReadLine());
                while(T-- > 0){
                    int data = Int32.Parse(Console.ReadLine());
                    head = insert(head,data);
                    TypedReference tr = __makeref(head);
                    IntPtr ptr = **(IntPtr**) (&tr);
                    Console.WriteLine($"Loop at {T} : {ptr}");
                }
                display(head);
            }
        }
        
        public static  Node insert(Node head,int data)
        {
            unsafe
            {
                var tr1 = __makeref(head);
                var ptr1 = **(IntPtr**) (&tr1);
                Console.WriteLine($"Param Head: {ptr1}");
            
                //Complete this method
                var node = new Node(data);

                if (head == null)
                {
                    head = node;
                    return head;
                }

                Node indicator = head;
                var tr2 = __makeref(indicator);
                var ptr2 = **(IntPtr**) (&tr2);
                Console.WriteLine($"Indicator: {ptr2}");
                
                while (indicator.next != null)
                {
                    indicator = indicator.next;
                    var tr3 = __makeref(indicator);
                    var ptr3 = **(IntPtr**) (&tr3);
                    Console.WriteLine($">Indicator: {ptr3}");
                }

                indicator.next = node;
                return head;
            }
        }

        public static void display(Node head)
        {
            Node start=head;
            while(start!=null)
            {
                Console.Write(start.data+" ");
                start=start.next;
            }
        }
    }
}