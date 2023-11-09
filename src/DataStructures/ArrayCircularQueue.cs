using System;
namespace data_structures_2.src.DataStructures
{
	public class ArrayCircularQueue
	{
		public int[] Queue { get; set; }
		public int Front { get; set; }
		public int Rear { get; set; }
		public int Capacity { get; set; }

		public ArrayCircularQueue(int size)
		{
			Queue = new int[size];
			Front = -1; //array index
			Rear = -1; //array index
			Capacity = size;
		}

		public void Enqueue(int n, int newElement)
		{
			ArrayCircularQueue queue = new ArrayCircularQueue(n);

			if (IsFull(queue))
			{
				Console.WriteLine("This queue is full so maybe make a new one or just forget about queues and go frolic in a flower field!");
				return;
			}

			//if queue is empty, front will be at 0 index
			if (queue.Front == -1)
			{
				queue.Front = 0;
				queue.Queue[queue.Front] = n;
				queue.Rear = queue.Front++;
			}

			if (queue.Rear == n)
			{
				queue.Rear = 0; //moving the rear index to the front of the array
			}
			else
			{
				queue.Rear++;
			}


		}

		public int Size(ArrayCircularQueue queue)
		{
			return queue.Capacity;
		}

		public bool IsFull(ArrayCircularQueue queue)
		{
            //if the front index is 0 and last is final index
            if ((queue.Front == 0 && queue.Rear == queue.Capacity - 1)
				//if the front and rear have moved and the front is the index following the rear.
				//Another way of writing this I think is Rear + 1 % Maxsize = Front
                || (queue.Rear == queue.Front - 1)) 
            {
				return true;
			}

			return false;
		}
    }
}

