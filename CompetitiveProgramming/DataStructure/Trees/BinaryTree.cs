using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming.DataStructure.Trees
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }
        
        public BinaryTree(int key)
        {
            root = new Node(key);
        }
    }
}
