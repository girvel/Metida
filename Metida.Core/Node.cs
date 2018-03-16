using System.Collections.Generic;

namespace Metida.Core
{
    public class Node
    {
        public string Name { get; set; }

        public List<Node> Children { get; set; } = new List<Node>();



        public Node(string name)
        {
            Name = name;
        }
    }
}
