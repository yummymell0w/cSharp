﻿using System.Collections.Generic;

namespace Problems
{
    public class Graph
    {
        private readonly string name;
        public List<Graph> nodes = new List<Graph>();

        public Graph(string personName)
        {
            name = personName;
        }

        public string personName
        {
            get
            {
                return name;
            }
        }

    }
}

