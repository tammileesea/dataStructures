using System;
using System.Xml.Linq;

namespace data_structures_2.src.DataStructures
{
	public class BinaryTree
	{
		public BinaryTree()
        {
        }

        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public string Value { get; set; }
        }

        public Node Root { get; set; }

        public void DepthFirstValues(Node root)
        {
            var stack = string[]();

            while (stack.length > 0)
            {
                if (current.Right.Value != null)
                {
                    stack.Add(current.Right);
                }

                if (current.Left.Value != null)
                {
                    stack.Add(current.Left);
                }
            }
        }
    }
}

