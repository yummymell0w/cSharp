using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Problems.MaxDepthOfNTree
{
    public class MaxDepthOfNTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<Node> cur = new Queue<Node>();
            Queue<Node> next = new Queue<Node>();

            cur.Enqueue(root);

            int depth = 0;
            do
            {
                next = new Queue<Node>();
                depth++;
                while (cur.Count > 0)
                {
                        var node = cur.Dequeue();
                        foreach (var nodeChild in node.children)
                        {
                            next.Enqueue(nodeChild);
                        }
                }
                cur = next;

            } while (next.Count > 0);

            return depth;
        }
    }
}
