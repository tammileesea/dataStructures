using System;
namespace data_structures_2.src.DataStructures
{
	public class ArrayStack
	{
		private int[] stack;
		private int top;
		private int capacity;

		public ArrayStack(int size)
		{
			stack = new int[size];
			top = -1;
			capacity = size;
		}

		public int ReadTopElement()
		{
			return stack.Last();
		}

		public void Push(int newElement)
		{
			if (IsFull())
			{
				stack[stack.Count()] = newElement;
			}
			else
			{
				int newSize = capacity * 2;
				int[] newStack = new int[newSize];

				stack.CopyTo(newStack, 0);
				stack = newStack;
			}
		}

		public void Pop()
		{
			if (stack.Count() > 0)
			{
				stack = stack.Take(stack.Count() - 1).ToArray();
			}
		}

		public int Size()
		{
			return stack.Count();
		}

		public bool IsFull()
		{
            return stack.Count() < capacity ? false : true;
		}
	}
}

