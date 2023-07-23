using System;
using TryHash;

class Program
{
    static void Main()
    {
        HashTable<string, int> hashTable = new();

        // Menambah key, value
        hashTable.Add("apple", 5);
        hashTable.Add("banana", 8);
        hashTable.Add("orange", 3);

        // Access menggunakan key
        Console.WriteLine("Value of 'apple': " + hashTable["apple"]);
        Console.WriteLine("Value of 'banana': " + hashTable["banana"]);

        // Edit dengan key
        hashTable["orange"] = 10;
        Console.WriteLine("Updated value of 'orange': " + hashTable["orange"]);

        // menghapus key value
        hashTable.Remove("banana");

        //Mengecek key yang ada di hashTable
        if (hashTable.TryGetValue("banana", out int value))
        {
            Console.WriteLine("Value of 'banana': " + value);
        }
        else
        {
            Console.WriteLine("'banana' not found in the hash table.");
        }

        // Kalo gaada di throw ke Exception
        try
        {
            int nonExistingValue = hashTable["grape"];
            Console.WriteLine("Value of 'grape': " + nonExistingValue);
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine("KeyNotFoundException: " + ex.Message);
        }
    }
}
