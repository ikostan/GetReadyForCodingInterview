﻿using System;
using System.Diagnostics;

namespace Question4
{
    class Questin4Program
    {
        /// <summary>
        /// 
        /// - [Instructor] Here is sample interview question number four with two dimensional array and time complexity. 
        /// Here's the problem. You're given a two dimensional array with integers which is square shaped which means 
        /// that the number of rules is equal to the number of columns, and this array has a special property that each 
        /// row and each column is sorted. So, if you look at each column from top to bottom, the integers always increase or stay the same. 
        /// If you look at each row from left to right the integers always increase or stay the same, 
        /// and I want you to write a function that takes this 2D array as the input and returns the number of negative numbers in it.
        /// 
        /// -4 -3 -1  1
        /// -2 -2  1  2
        /// -1  1  2  3
        ///  1  2  4  5
        /// 
        /// So, for instance, for this array we should return six because there are six negative numbers.
        /// First, try finding a big O of N squared solution.Then, try finding a more efficient solution with 
        /// linear time complexity or big O of N. For clarifying questions you might ask is the 2D array always square shaped? 
        /// Yes, as I said earlier, the number of columns is equal to the number of rows. What about zero? Zero 
        /// is not counted as a negative number.
        /// 
        /// As usual, try solving this problem and make sure to run your code.
        /// 
        /// </summary>
        /// <param name="args"></param>

        private static int[,] arr2D_one, arr2D_two, arr2D_tree, arr2D_four;

        static void Main(string[] args)
        {
            Console.WriteLine("Question #4:\n");

            //#1:
            arr2D_one = new int[4, 4] {
                { -4, -3, -1, 1 },
                { -2, -2,  1, 2 },
                { -1,  1,  2, 3 },
                {  1,  2,  4, 5 }
            };

            Console.WriteLine($"O(n2): {count_negatives_On2(arr2D_one)}");

            Console.WriteLine($"O(n): {count_negatives_On(arr2D_one)}");

            Console.WriteLine();

            //#2:
            arr2D_two = new int[2, 2] {
                { -1, 0 },
                {  0, 0 }
            };

            Console.WriteLine($"O(n2): {count_negatives_On2(arr2D_two)}");

            Console.WriteLine($"O(n): {count_negatives_On(arr2D_two)}");

            Console.WriteLine();

            //#3:
            arr2D_tree = new int[2, 2] {
                { -2, 0 },
                { -1, 0 }
            };

            Console.WriteLine($"O(n2): {count_negatives_On2(arr2D_tree)}");

            Console.WriteLine($"O(n): {count_negatives_On(arr2D_tree)}");

            Console.WriteLine();

            //#4:
            arr2D_tree = new int[1, 1] {
                { 0 }
            };

            Console.WriteLine($"O(n2): {count_negatives_On2(arr2D_tree)}");

            Console.WriteLine($"O(n): {count_negatives_On(arr2D_tree)}");

            Console.WriteLine();



            Console.ReadKey();
        }


        /// <summary>
        /// Function that takes this 2D array as the input and returns the number of negative numbers in it.
        /// Big O: n2 x O(1) = O(n2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int count_negatives_On2(int[,] arr)
        {
            int negatives = 0;
            int times = 0;

            foreach (var item in arr)
            {
                if (item < 0)
                {
                    negatives++;
                }

                times++;
            }

            Debug.WriteLine($"Times runned: {times}");

            return negatives;
        }

        /// <summary>
        /// Function that takes this 2D array as the input and returns the number of negative numbers in it.
        /// Big O: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int count_negatives_On(int[,] arr)
        {
            int negatives = 0;
            int times = 0;

            int lastIndexInRow = arr.GetLength(0) - 1;
            int lastIndexInColumn = arr.GetLength(1) - 1;

            int col = lastIndexInColumn;
            int row = 0;

            Debug.WriteLine($"Last Index In Column: {lastIndexInColumn}");

            while (row <= lastIndexInRow)
            {
                Debug.WriteLine($"row: {row}, col: {col}");

                if (arr[row, col] < 0) // Negative number found
                {
                    int numOfNegat = col + 1;
                    negatives += numOfNegat;
                    row++; // Row increment
                    col = lastIndexInColumn;
                }

                if (col > 0)
                {
                    col--; // Column decrement
                }
                else if (col == 0)
                {
                    row++; // Row increment
                    col = lastIndexInColumn;
                }

                times++;
            }

            Debug.WriteLine($"Times runned: {times}");

            return negatives;
        }

    }
}
