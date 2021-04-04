using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Day23.BSTLevelOrderTraversal
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

            LevelOrder(root);
        }
        
        private static int MaxHeight(Node node)
        {
            return node == null ? 0 : 1 + Math.Max(MaxHeight(node.Left), MaxHeight(node.Right));
        }

        private static void LevelOrder(Node root)
        {
            if (root == null) return;

            var height = MaxHeight(root);
            // Console.WriteLine($"height: {height}");
            for (var i = 1; i <= height; i++)
            {
                var dataList = GetLevelNodeData(root, i);
                foreach (var data in dataList)
                {
                    if (data != -1) Console.Write($"{data} ");
                }
            }
        }

        private static IEnumerable<int> GetLevelNodeData(Node root, int level)
        {
            if (root == null) return new [] {-1};

            if (level == 1)
            {
                // Console.WriteLine($"level({level}) - {root.Data}");
                return new [] {root.Data};
            }

            var data = new List<int>();
            data.AddRange(GetLevelNodeData(root.Left, level - 1));
            data.AddRange(GetLevelNodeData(root.Right, level - 1));
            return data;
        }

        private static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }

            if (data <= root.Data) root.Left = Insert(root.Left, data);
            else root.Right = Insert(root.Right, data);

            return root;
        }
    }

    internal class Node
    {
        public int Data { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}