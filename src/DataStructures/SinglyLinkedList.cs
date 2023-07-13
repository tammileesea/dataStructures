using System;
using System.Runtime.Intrinsics.X86;

namespace data_structures_2.src.DataStructures
{
	public class SinglyLinkedList
	{
		private Node head;

		public SinglyLinkedList()
		{ }

		public bool RetrieveHead(Node target)
		{
			Node current = head;

			while (current != null)
			{
				if (target.Data == current.Data)
				{
					Console.WriteLine("Target node value of {0} exists in this list", current.Data);
					return true;
				}
				else if (current.Next == null && current.Data != target.Data)
				{
					Console.WriteLine("The target node does not exist in this list");
					return false;
				}

				current = current.Next;
			}

			return false;
		}

		public void InsertAtHead(Node newNode)
		{
			Node current = head;

			newNode.Next = current;
			Console.WriteLine("New node has been added to the list");
		}

		public void InsertAtTail(Node newNode)
		{
			Node current = head;

			while (current != null)
			{
				current = current.Next;
			}

			current.Next = newNode;
		}

		//nodes are already in ascending order, put in right place, even if its a dupe
		//guaranteed to not be the first nor last
		public void InsertInMiddle(Node newNode)
		{
			Node current = head;

			while (current.Next != null)
			{
				if ((current.Data == newNode.Data || current.Data < newNode.Data)
					&& current.Next.Data > newNode.Data)
				{
					newNode.Next = current.Next;
					current.Next = newNode;
				}

				current = current.Next;
			}
		}

		public void RemoveAtHead()
		{
            Node current = head;

			head = current.Next;
        }

		public void RemoveAtTail()
		{
            Node current = head;

            while (current.Next != null)
            {
				current = current.Next;
            }

			current.Next = null;
        }

		public void RemoveInMiddle(Node target)
		{
			Node current = head;

			while (current != null)
			{
				if (target.Data == current.Next.Data) //[3][4][5]
				{
					current.Next = current.Next.Next;
					current.Next = null;
				}

				current = current.Next;
			}
		}
	}
}


//-removal
//    - use 2 traversers: 1 at head, 1 at head.next
//    - use a temp pointer ==> trav1 -> temp -> trav2
//        - point trav1 -> trav2 ==> removes temp bc nothing is pointing to it anymore
//        - memory clean up when needed