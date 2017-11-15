using System;
using System.Collections;
using System.Diagnostics;

namespace Question5
{
    class Question5Program
    {
        /// <summary>
        /// 
        /// - [Narrator] Here's sample interview question number five with Python Dictionary or hash tables. 
        /// Suppose you're given a list or an array of numbers. What we want to do here is we want 
        /// to be able to find a pair of numbers in this array that adds up to ten. In this example, 
        /// one and nine add up to ten. For clarifying questions, you might ask, "What should I return from my function". 
        /// You should just print out the pair of numbers that adds up to ten and return nothing. 
        /// Could the numbers in the array be decimals? No, just assume that we'll only have integers.
        /// 
        /// Could the numbers be negative? Yes, any of the numbers in the array could be negative or zero.
        /// What if I find two or more pairs that add up to ten? Then just print out one of them, and you can choose which one.
        /// What if there's no pair that adds up to ten? Then just print there's no pair that adds 
        /// up to ten and return from the function, and trying solving this problem in O(n).  
        /// Once you solve it, make sure to run a code to check if it's correct.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Question #5:\n");


            // Problem: Find a pair of numbers that add up to 10.
            // You are given a list / array with integers.
            // Write a function, pair10(input), which finds and prints out a pair (any of them) of numbers that add up to 10.


            // [3, 4, 1, 2, 9] => (Should print 1, 9)
            int[] arr1 = new int[] { 3, 4, 1, 2, 9 };
            //pair10(arr1);
            pair10_On(arr1);

            // [-11, -20, 2, 4, 30] => (Should print -20, 30)
            int[] arr2 = new int[] { -11, -20, 2, 4, 30 };
            //pair10(arr2);
            pair10_On(arr2);

            // [1, 2, 9, 8] => (Should print 1, 9 or 2, 8)
            int[] arr3 = new int[] { 1, 2, 9, 8 };
            //pair10(arr3);
            pair10_On(arr3);

            // [1, 1, 1, 2, 3, 9] => (Should print 1, 9)
            int[] arr4 = new int[] { 1, 1, 1, 2, 3, 9 };
            //pair10(arr4);
            pair10_On(arr4);

            // [1, 1, 1, 2, 3, 4, 5] => (Should print "There is no pair that adds up to 10.)
            int[] arr5 = new int[] { 1, 1, 1, 2, 3, 4, 5 };
            //pair10(arr5);
            pair10_On(arr5);

            Console.ReadKey();
        }

        /// <summary>
        /// Finds and prints out a pair (any of them) of numbers that add up to 10
        /// Big O of n in square
        /// </summary>
        private static void pair10(int[] arr)
        {
            int pairs = 0;
            Hashtable numPairs = new Hashtable();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (!numPairs.ContainsKey(arr[i])) //Optimization
                {
                    for (int b = i + 1; b < arr.Length; b++)
                    {
                        Debug.WriteLine($"{arr[i]} {arr[b]}");

                        if (arr[i] + arr[b] == 10)
                        {
                            Console.WriteLine($"{arr[i]}, {arr[b]}");
                            numPairs.Add(arr[i], arr[b]);
                            pairs++;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

            if (pairs == 0)
            {
                Console.WriteLine("There is no pair that adds up to 10.");
            }
        }

        /// <summary>
        /// Big O of n method
        /// </summary>
        /// <param name="arr"></param>
        private static void pair10_On(int[] arr)
        {
            Hashtable testedNumbers = new Hashtable();
            bool pairsExists = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!testedNumbers.ContainsKey(arr[i])) //Check is Key exist => has to be done in order to avoid exceptions
                {
                    if (testedNumbers.ContainsKey(10 - arr[i])) //Pair found
                    {
                        Console.WriteLine($"{arr[i]}, {(10 - arr[i])}");
                        pairsExists = true;
                    }

                    testedNumbers.Add(arr[i], 1);
                }
                else
                {
                    continue; //Skip to the next number
                }
            }

            if (!pairsExists)
            {
                Console.WriteLine("There is no pair that adds up to 10.");
            }
        }

    }
}
