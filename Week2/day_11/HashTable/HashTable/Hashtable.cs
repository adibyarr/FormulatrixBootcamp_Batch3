using System;
using System.Collections.Generic;

namespace TryHash
{
	class KeyValuePair<TKey, TValue>
	{
		public TKey Key {get; set; }
		public TValue Value{get; set;}
		public KeyValuePair(TKey key, TValue value)
		{
			Key = key;
			Value = value;
		}
	}
	class HashTable <TKey, TValue>
	{
		private const int CapacityInitial = 12;
		private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;
		
		public HashTable()
		{
			buckets = new LinkedList<KeyValuePair<TKey, TValue>>[CapacityInitial];
		}
		private int GetHash(TKey key)
		{
			int hash = key.GetHashCode();
			return Math.Abs(hash) % buckets.Length;
		}
		public void Add(TKey key, TValue value)
		{
			int index =  GetHash(key);
			if (buckets[index] == null )
			{
				buckets[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
			}
			foreach(var pair in buckets[index])
			{
				if(pair.Key.Equals(key))
				{
					throw new ArgumentException("Value has been already exist");
				}
			}
			buckets[index].AddLast(new KeyValuePair<TKey, TValue> (key, value));
		}
		public bool Remove(TKey key)
		{
			int index = GetHash(key);
			if(buckets[index] != null)
			{
				var node = buckets[index].First;
					while (node != null)
					
					{
						if (node.Value.Key.Equals(key))
						{
							buckets[index].Remove(node);
							return true;
						}
						node = node.Next;
					}
			}
			return false;
		}
		public bool TryGetValue(TKey key, out TValue value)
		{
			int index = GetHash(key);
			if(buckets[index] != null)
			{
				foreach(var pair in buckets[index])
				{
					if(pair.Key.Equals(key))
					{
						value = pair.Value;
						return true;
					}
				}
			}
			value = default(TValue);
			return false;
		}
		public TValue this[TKey key]
		{
			get
			{
				if(TryGetValue(key, out TValue value))
				{
					return value;
				}
				throw new KeyNotFoundException("Key was Not Found");
			}
			set
			{
				int index =  GetHash(key);
				if(buckets[index] != null)
				{
					foreach(var pair in buckets[index])
					{
						if(pair.Key.Equals(key))
						{
							pair.Value = value;
							return;
						}
					}
				}
				throw new KeyNotFoundException("Key not found");
			}
		}
	}
}