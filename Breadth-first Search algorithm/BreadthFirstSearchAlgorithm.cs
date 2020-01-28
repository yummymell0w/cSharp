using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Problems
{
    public class BreadthFirstSearchAlgorithm
    {
        public static bool Search(string name)
        {
            Graph you = new Graph("you");
            Graph bob = new Graph("bob");
            Graph alice = new Graph("alice");
            Graph claire = new Graph("claire ");
            Graph anuj = new Graph("anuj");
            Graph peggy = new Graph("peggy");
            Graph thom = new Graph("thom");
            Graph jonny = new Graph("jonny");

            you.nodes.Add(alice);
            you.nodes.Add(bob);
            you.nodes.Add(claire);

            bob.nodes.Add(anuj);
            bob.nodes.Add(peggy);

            alice.nodes.Add(peggy);

            claire.nodes.Add(thom);
            claire.nodes.Add(jonny);

            Queue<Graph> searchQueue = new Queue<Graph>();
            //to do
            searchQueue.Enqueue(anuj);

            searchQueue.Enqueue(anuj.nodes);

        }

        
    }
}



