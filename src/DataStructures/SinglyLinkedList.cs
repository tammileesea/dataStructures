using System;
using System.Runtime.Intrinsics.X86;

namespace data_structures_2.src.DataStructures
{
	public class Node
	{
		public Node? next;
		public int data;
	}

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
				if (target.data == current.data)
				{
					Console.WriteLine("Target node value of {0} exists in this list", current.data);
					return true;
				}
				else if (current.next == null && current.data != target.data)
				{
					Console.WriteLine("The target node does not exist in this list");
					return false;
				}

				current = current.next;
			}

			return false;
		}

		public void InsertAtHead(Node newNode)
		{
			Node current = head;

			newNode.next = current;
			Console.WriteLine("New node has been added to the list");
		}

		public void InsertAtTail(Node newNode)
		{
			Node current = head;

			while (current != null)
			{
				current = current.next;
			}

			current.next = newNode;
		}

		//nodes are already in ascending order, put in right place, even if its a dupe
		//guaranteed to not be the first nor last
		public void InsertInMiddle(Node newNode)
		{
			Node current = head;

			while (current.next != null)
			{
				if ((current.data == newNode.data || current.data < newNode.data)
					&& current.next.data > newNode.data)
				{
					newNode.next = current.next;
					current.next = newNode;
				}

				current = current.next;
			}
		}

		public void RemoveAtHead()
		{
            Node current = head;

			head = current.next;
        }

		public void RemoveAtTail()
		{
            Node current = head;

            while (current.next != null)
            {
				current = current.next;
            }

			current.next = null;
        }

		public void RemoveInMiddle(Node target)
		{
			Node current = head;

			while (current != null)
			{
				if (target.data == current.next.data) //[3][4][5]
				{
					current.next = current.next.next;
					current.next = null;
				}

				current = current.next;
			}
		}
	}
}


//-removal
//    - use 2 traversers: 1 at head, 1 at head.next
//    - use a temp pointer ==> trav1 -> temp -> trav2
//        - point trav1 -> trav2 ==> removes temp bc nothing is pointing to it anymore
//        - memory clean up when needed