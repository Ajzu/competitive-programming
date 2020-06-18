using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.DataStructure.Trees
{
    public class Node
    {
        int key;
        public Node left;
        public Node right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }

        public Node()
        {

        }
    }
}
