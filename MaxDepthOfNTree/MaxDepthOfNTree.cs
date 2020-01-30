using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problems.MaxDepthOfNTree
{
    public class MaxDepthOfNTree
    {
        public static int MaxDepth(Node root)
        {
            //Input: root = [1,null,3,2,4,null,5,6]
            //Output: 3

            /*Graph one = new Graph(1);
            Graph three = new Graph(3);
            Graph two = new Graph(2);
            Graph four = new Graph(4);
            Graph five = new Graph(5);
            Graph six = new Graph(6);

            one.children.Add(three);
            one.children.Add(two);
            one.children.Add(four);
            three.children.Add(five);
            three.children.Add(six);*/

            Queue<Node> searchQueue = new Queue<Node>();
            searchQueue.Enqueue(root);
            

            if (root == null)
            {
                return 0;

            }

            int maxNodes = 1;
            while (searchQueue.Count > 0)
            {
                var node = searchQueue.Dequeue();
                int nodeCount = node.children.Count;

                if (nodeCount > maxNodes)
                {
                    maxNodes = nodeCount;
                }

            }

            return maxNodes;
        }
    }
}
