using System;

namespace Day22.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = Insert(root, data);
            }

            // int height = GetHeight(root);
            int height = MaxHeight(root) - 1; // final resutl should be -1.
            Console.WriteLine(height);
        }

        // my trial
        private static int GetHeight(Node root)
        {
            var current = root;

            var lHeight = 0;
            if (current.Left != null)
            {
                lHeight++;
                current = current.Left;
                lHeight += GetHeight(current);
            }

            current = root;
            var rHeight = 0;
            if (current.Right != null)
            {
                rHeight++;
                current = current.Right;
                rHeight += GetHeight(current);
            }

            return (lHeight > rHeight) ? lHeight : rHeight;
        }
        
        /* reference approach
           - pseudo code
             height(node) = 
             {
                0 <- when node == null
                1 + max(height(node.left), height(node.right)) <- when node != null 
             }
        */
        private static int MaxHeight(Node node)
        {
            return node == null ? 0 : 1 + Math.Max(MaxHeight(node.Left), MaxHeight(node.Right));
        }

        private static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }

            if (data <= root.Data)
            {
                Node current = Insert(root.Left, data);
                root.Left = current;
                return root;
            }

            if (data > root.Data)
            {
                Node current = Insert(root.Right, data);
                root.Right = current;
                return root;
            }
            
            return null;
        }
    }

    internal class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}