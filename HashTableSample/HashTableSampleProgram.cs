using System;
using System.Collections;
using System.Collections.Generic;

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

            Intro();

            // Exercise Problems => 

            // Problem 1: 
            // Initialize a dictionary with the key, 'Amy', and the value, 28.  Call it a_dict.
            Hashtable a_dict = new Hashtable();
            a_dict.Add("Amy", 28);

            // Problem 2: From the dictionary called b_dict, defined below, retrieve and print the 
            // value that corresponds to the key 'Tom'.
            Hashtable b_dict = new Hashtable();
            b_dict.Add("Amy", 30);
            b_dict.Add("Tom", "AGE UNKNOWN");
            Console.WriteLine("{0}, {1}", "Tom", b_dict["Tom"]);

            // Problem 3: Given the dictionary c_dict, defined below, add a new key called 'George' with the value 44.
            Hashtable c_dict = new Hashtable();
            c_dict.Add("Amy", 30);
            c_dict.Add("Tom", "AGE UNKNOWN");
            c_dict.Add("George", 44);
            Console.WriteLine($"{"George"}, {c_dict["George"]}");

            // Problem 4: Given a list of names, write a function that finds a value that appears twice in the list.
            // For example, if you're given ['George', 'Tom', 'Emily', 'Jenny', 'Peter'].
            // **Just assume that there's only one value that appears twice.**
            Hashtable d_dict = new Hashtable();
            d_dict.Add("George", 30);
            d_dict.Add("Tom", 23);
            d_dict.Add("Emily", 44);
            d_dict.Add("Jenny", 21);
            d_dict.Add("Peter", 30);

            List<int> set = new List<int>();

            foreach (DictionaryEntry item in d_dict)
            {
                int age = (int)item.Value;

                if (!set.Contains(age))
                {
                    set.Add(age);
                }
                else
                {
                    Console.WriteLine($"Following age appears twice: {item.Value}, the name is: {item.Key}");
                    break;
                }
            }

            Console.ReadKey();
        }


        /// <summary>
        /// Introduction
        /// </summary>
        private static void Intro()
        {
            Hashtable ages = new Hashtable();
            ages.Add("Emily", 32);
            //Console.WriteLine($"Tom's age: {ages["Emily"]}"); // Takes Big O of 1 only

            ages.Add("Tom", 43);
            //Console.WriteLine($"Tom's age: {ages["Tom"]}");

            ages.Add("George", 22);
            //Console.WriteLine($"Tom's age: {ages["George"]}");

            ages.Add("Roi", 22);
            //Console.WriteLine($"Tom's age: {ages["Roi"]}");

            foreach (DictionaryEntry entry in ages)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }

            if (ages.ContainsKey("John")) // Takes Big O of 1 only
            {
                Console.WriteLine($"Tom's age: {ages["John"]}");
            }
            else
            {
                Console.WriteLine($"There is no \"John\" in the list.");
            }

            if (ages.ContainsValue(22)) // Takes Big O of 1 only
            {
                Console.WriteLine($"Age of 22 found in the list.");
            }
            else
            {
                Console.WriteLine($"There is no one with the age of 22.");
            }
        }

    }
}
