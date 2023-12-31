﻿using System;
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
				top = newNode;
			}
        }

		public Node Pop()
		{
			if (top != null && top.Next != null)
			{
                top = top.Next;

                return top.Next; //return new head
            }

			return null;
		}

        public int Size()
        {
            int size = 0;

            while (top != null)
            {
                size++;
                top = top.Next;
            }

            return size;
        }

        public bool IsEmpty()
		{
			return top == null;
		}
	}
}

