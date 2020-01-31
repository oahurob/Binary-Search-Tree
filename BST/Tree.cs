﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Tree
    {
        public Node Root { get; set; }
        public Node NewNode(int data)
        {
            Node temp = new Node();
            temp.key = data;
            temp.left = null;
            temp.right = null;

            return temp;
        }

        public bool Add(int key)
        {
            Node newNode = NewNode(key);

            Node before = null, after = this.Root;

            while(after != null)
            {
                before = after;

                if(key < after.data)
                {
                    after = after.left;
                }
                else if(key > after.data)
                {
                    after = after.right;
                }
                else
                {
                    return false;
                }

                newNode.data = key;
            }
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (key < before.data)
                {
                    before.left = newNode;
                }
                else
                {
                    before.right = newNode;
                }
            }
            return true;

        }
    }
}
