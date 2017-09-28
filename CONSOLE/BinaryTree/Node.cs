﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int Value { get; set;}
        public Node RightNode { get; set; }

        public Node LeftNode { get; set; }

        public Node(int value)
        {
            this.Value = value;
        }
    }
}
