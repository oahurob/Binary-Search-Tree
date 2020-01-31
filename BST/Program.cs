using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            Tree tree = new Tree();
            tree.Add(6);
            tree.Add(7);
            tree.Add(7);
            tree.Add(8);
            tree.Add(9);
            tree.Add(10);
            tree.Add(12);
            Console.WriteLine(tree.Search(6));
            Console.ReadLine();
        }
    }
}
