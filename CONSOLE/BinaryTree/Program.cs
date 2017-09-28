using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(4);
            AddNode(node, 2);
            AddNode(node, 5);
            AddNode(node, 1);
            AddNode(node, 3);
            AddNode(node, 7);
            AddNode(node, 6);
            AddNode(node, 8);

            Console.WriteLine("PreOrder");
            PreOrder(node);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("PostOrder");
            PostOrder(node);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("InOrder");
            InOrder(node);
            Console.WriteLine(Environment.NewLine);


            Console.ReadLine();
        }

        private static void AddNode(Node node, int value)
        {
            if (value <= node.Value)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new Node(value);
                }
                else
                {
                    AddNode(node.LeftNode, value);
                }

            }
            else
            {
                if (node.RightNode == null)
                {
                    node.RightNode = new Node(value);
                }
                else
                {
                    AddNode(node.RightNode, value);
                }
            }
        }
    }
}
