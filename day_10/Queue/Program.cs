using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueCollections
{
	class Program
	
	{
		static void Main()
		
		{
			Queue queue = new Queue();
			
			queue.Enqueue(12);
			queue.Enqueue(3.14);
			queue.Enqueue(true);
			queue.Enqueue('A');
			queue.Enqueue("Hello");
			
			Console.WriteLine("Items in the queue");
			foreach(var item in queue)
			
			{
				Console.WriteLine(item);
			}
			
			var removedItem = queue.Dequeue();
			Console.WriteLine($"\nRemoved Item: {removedItem}");
			
			var nextItem = queue.Peek();
			Console.WriteLine($"\nNext item in the queue: {nextItem}");
			
			var isinQueue = queue.Contains(true);
			Console.WriteLine($"\nIs true in the queue? {isinQueue}");
			
			var cloneedQueue = (Queue)queue.Clone();
			
			object[] queueArray = new object[queue.Count];
			queue.CopyTo(queueArray, 0);
			
			Console.WriteLine("\nItems in the cloneed queue: ");
			foreach(var item in cloneedQueue)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("\nItem in queueArray: ");
			foreach(var item in queueArray)
			{
				Console.WriteLine(item);
			}
			
			
		}
	}
}