using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.MaxDepthOfNTree
{
    public class Node
    {
        public int val;
        public List<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, List<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
