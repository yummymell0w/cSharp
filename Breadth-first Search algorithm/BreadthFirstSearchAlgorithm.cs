using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Problems
{
    public class BreadthFirstSearchAlgorithm
    {
        public static bool Search()
        {
            // create person's objects
            Graph you = new Graph("you");
            Graph bob = new Graph("bob");
            Graph alice = new Graph("alice");
            Graph claire = new Graph("claire ");
            Graph anuj = new Graph("anuj");
            Graph peggy = new Graph("peggy");
            Graph thom = new Graph("thom");
            Graph jonny = new Graph("jonny");


            // add friends
            you.nodes.Add(alice);
            you.nodes.Add(bob);
            you.nodes.Add(claire);

            bob.nodes.Add(anuj);
            bob.nodes.Add(peggy);

            alice.nodes.Add(peggy);

            claire.nodes.Add(thom);
            claire.nodes.Add(jonny);

            //add people to the queue
            Queue<Graph> searchQueue = new Queue<Graph>();
            searchQueue.Enqueue(you);
            searchQueue.Enqueue(bob);
            searchQueue.Enqueue(alice);
            searchQueue.Enqueue(claire);
            searchQueue.Enqueue(anuj);
            searchQueue.Enqueue(peggy);
            searchQueue.Enqueue(thom);
            searchQueue.Enqueue(jonny);

            while (searchQueue.Count > 0)
            {
                var person = searchQueue.Peek();
                if (!person.checkedNode)
                {
                    if (checkIfThisIsSeller(person.personName))
                    {
                        Console.WriteLine($"{person.personName} is a mango seller!");
                        return true;
                    }
                    else
                    {
                        searchQueue.Dequeue();
                        person.checkedNode = true;
                    }
                }

            }
            return false;
        }

        //checks if name's last letter matches 'm'
        public static bool checkIfThisIsSeller(string personName)
        {
            char[] name = personName.ToCharArray();
            if (name[name.Length - 1] == 'm')
            {
                return true;
            }

            return false;
        }


    }
}



