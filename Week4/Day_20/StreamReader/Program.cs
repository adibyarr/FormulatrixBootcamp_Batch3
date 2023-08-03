﻿using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = @"C:\Users\Batch 3\Bootcamp\day_Two\FormulatrixBootcamp_Batch3\Week4\Day_20\StreamReader/MyFile.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }	
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}