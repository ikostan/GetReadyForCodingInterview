﻿using System;
using System.Collections;

namespace HashTableSample
{
    class Program
    {
        /// <summary>
        /// 
        /// - [Instructor] Now here's how a regular paper dictionary works. 
        /// You basically have pairs of words and definitions in the dictionary. 
        /// 
        /// Instead of words and definitions, we have keys and values. 
        /// For example, we have a string apple as a key and we can ask the dictionary what's the corresponding value for the key, 
        /// apple and it'll give us the value, the round, red fruit of a tree which is also a string. 
        /// The values could have any types whether they are strings, numbers, lists or even dictionaries.
        /// 
        /// And the keys could have a number of different types as well but the most common types of keys are strings and numbers. 
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table!");

            Hashtable ages = new Hashtable();
            ages.Add("Emily", 32);
            Console.WriteLine($"Tom's age: {ages["Emily"]}"); // Takes Big O of 1 only

            ages.Add("Tom", 43);
            Console.WriteLine($"Tom's age: {ages["Tom"]}");

            ages.Add("George", 22);
            Console.WriteLine($"Tom's age: {ages["George"]}");

            Console.ReadKey();
        }
    }
}
