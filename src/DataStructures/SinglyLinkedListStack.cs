using System;
namespace data_structures_2.src.DataStructures
{
	public class SinglyLinkedListStack
	{
        private Node top;

        public SinglyLinkedListStack()
		{
			top = null;
		}

		public Node ReadTopElement()
		{
			if (top != null)
			{
				return top;
			}

			return null;
		}

		public void Push(Node newNode)
		{
			if (top != null)
			{
				newNode.Next = top;
			}
        }

		public Node Pop()
		{
			top = top.Next;

			return top.Next;
		}

		public bool IsEmpty()
		{
			return top == null;
		}
	}
}

