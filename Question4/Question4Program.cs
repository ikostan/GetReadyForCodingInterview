using System;
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

        private static int[,] arr2D;

        static void Main(string[] args)
        {
            Console.WriteLine("Question #4:\n");

            arr2D = new int[4, 4] {
                { -4, -3, -1, 1 },
                { -2, -2,  1, 2 },
                { -1,  1,  2, 3 },
                {  1,  2,  4, 5 }
            };

            Console.WriteLine($"O(n2): {count_negatives_On2(arr2D)}");

            Console.WriteLine($"O(n): {count_negatives_On(arr2D)}");

            Console.ReadKey();
        }


        /// <summary>
        /// Function that takes this 2D array as the input and returns the number of negative numbers in it.
        /// Big O: O(n2)
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

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                if (arr[row, 0] > -1)
                {
                    continue;
                }

                for (int col = 0; col < arr.GetLength(0); col++)
                {
                    times++;

                    if (arr[row, col] > -1)
                    {
                        break;
                    }
                    else 
                    {
                        negatives++;
                    }
                }
            }

            Debug.WriteLine($"Times runned: {times}");

            return negatives;
        }

    }
}
