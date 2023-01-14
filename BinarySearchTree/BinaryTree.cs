using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinarySearchTree
{
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    class BinarySearchTree
    {
        Node root;

        // A utility function to insert a new key to BST

        public bool Search(int key)//UC3
        {
            return SearchRec(root, key);
        }

        bool SearchRec(Node root, int key)
        {
            // Base Cases: root is null or key is present at root
            if (root == null || root.key == key)
                return root != null;

            // val is greater than root's key
            if (root.key < key)
                return SearchRec(root.right, key);

            // val is less than root's key
            return SearchRec(root.left, key);
        }

        public int Size()//UC2
        {
            return SizeRec(root);
        }

        int SizeRec(Node root)
        {
            if (root == null) return 0;
            else return (SizeRec(root.left) + 1 + SizeRec(root.right));
        }
        public void Insert(int key)//UC1
        {
            root = InsertRec(root, key);
        }

        /* A recursive function to insert a new key in BST */
        Node InsertRec(Node root, int key)
        {
            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);

            /* return the (unchanged) node pointer */
            return root;
        }
    }

}
