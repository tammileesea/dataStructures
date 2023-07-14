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
		}

		public void Pop()
		{
			if (!IsEmpty())
			{
				stack = stack.Take(stack.Count() - 1).ToArray();
			}
		}

		public bool IsEmpty()
		{
			if (stack.Count() < 1)
			{
				return true;
			}

			return false;
		}

		public bool IsFull()
		{
            return stack.Count() < capacity ? false : true;
		}
	}
}

