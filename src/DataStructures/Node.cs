using System;
namespace data_structures_2.src.DataStructures
{
	public class Node
	{
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data, Node next)
		{
			Data = data;
			Next = next;
		}
	}
}

