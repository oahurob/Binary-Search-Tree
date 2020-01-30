using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Tree
    {

        public Node NewNode(int data)
        {
            Node temp = new Node();
            temp.key = data;
            temp.left = null;
            temp.right = null;

            return temp;
        }

        public Node Add(Node node, int key)
        {
            
        }
    }
}
