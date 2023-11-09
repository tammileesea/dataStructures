using System;
using System.Xml.Linq;

namespace data_structures_2.src.DataStructures
{
	public class BinarySearchTree
	{
        public BstNode Root { get; set; }

		public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(int newValue)
        {
            Root = new BstNode(newValue);
        }

        public void Insert(int value)
        {
            Root = InsertRecursively(Root, value);
        }

        private BstNode InsertRecursively(BstNode root, int newValue)
        {
            if (root == null)
            {
                root = new BstNode(newValue);
                return root;
            }

            if (root.Data > newValue)
            {
                root.Left = InsertRecursively(root.Left, newValue);
            }
            else if (root.Data < newValue)
            {
                root.Right = InsertRecursively(root.Right, newValue);
            }

            return root;
            //if (newValue <= Root.Data)
            //{
            //    if (Root.Left == null)
            //    {
            //        Root.Left = new BstNode(newValue);
            //    }
            //    else
            //    {
            //        Root.Left.Data = newValue;
            //    }
            //}
            //else
            //{
            //    if (Root.Right == null)
            //    {
            //        Root.Right = new BstNode(newValue);
            //    }
            //    else
            //    {
            //        Root.Right.Data = newValue;
            //    }
            //}
        }

        public bool Contains(int value)
        {
            return ContainsRecursively(Root, value);
        }

        private bool ContainsRecursively(BstNode root, int value)
        {
            if (root.Data == value)
            {
                return true;
            }
            else if (root.Data > value)
            {
                if (root.Left == null)
                {
                    return false;
                }
                else
                {
                    return ContainsRecursively(root.Left, value);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    return false;
                }
                else
                {
                    return ContainsRecursively(root.Right, value);
                }
            }
        }

        public void InOrderTraversal()
        {
            InOrderTraversalRecursive(Root);
        }

        private void InOrderTraversalRecursive(BstNode root)
        {
            if (root != null)
            {
                InOrderTraversalRecursive(root.Left);
                Console.WriteLine(root.Data);
                InOrderTraversalRecursive(root.Right);
            }
        }
    }
}

