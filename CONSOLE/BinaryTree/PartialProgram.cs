using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    partial class Program
    {
        private static void PreOrder(Node node)
        {
            Console.WriteLine("Значение узла = {0}", node.Value);

            if (node.LeftNode != null)
                PreOrder(node.LeftNode);

            if (node.RightNode != null)
                PreOrder(node.RightNode);
        }

        private static void PostOrder(Node node)
        {
            if (node.LeftNode != null)
                PostOrder(node.LeftNode);

            if (node.RightNode != null)
                PostOrder(node.RightNode);

            Console.WriteLine("Значение узла = {0}", node.Value);

        }

        private static void InOrder(Node node)
        {
            if((node.LeftNode == null) && (node.RightNode == null))
                Console.WriteLine("Значение узла = {0}",node.Value);
            else
            {
                if (node.LeftNode != null)
                {
                    InOrder(node.LeftNode);
                }

                Console.WriteLine("Значение узла = {0}", node.Value);

                if (node.RightNode != null)
                    InOrder(node.RightNode);

            }

        }

    }
}
