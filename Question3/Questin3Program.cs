using System;

namespace Questin3
{
    class Program
    {
        /// <summary>
        /// 
        /// - [Instructor] Here is sample interview question number three with two dimensional array. 
        /// Here's the problem. You're given a configuration of a chessboard with some rooks. 
        /// In this chessboard, we want to see if any of the rooks are able to attack any other ones. 
        /// Just in case you've never played chess, rooks are able to move any number of spaces horizontally and vertically. 
        /// So, in this particular state, none of the rooks are able to attach each other. 
        /// However, in this one, the two rooks at the top are able to attack each other.
        ///
        /// The configuration of the board will be given as an input to your function and 
        /// it'll be represented as a two dimensional array. Zero means that there's nothing in that space, 
        /// and one means that there's a rook there. Very simple (see example below):
        /// 
        ///  0  1  0  0
        ///  0  0  1  0
        ///  0  0  0  0
        ///  0  0  0  1
        /// 
        /// And the given board could have a smaller size than the real chessboard. 
        /// For example, a four by four grid you see here. Let's call this function rooks are safe, 
        /// and we're going to return true if none of the rooks are able to attack each other. 
        /// So, in this particular case, this function should return true because none of the rooks are able to attack each other.
        ///
        /// If this was an actual interview, you might want to ask these clarifying questions. 
        /// What's the size of the chessboard? It could be any size. It could be two by two or 99 by 99, for example. 
        /// Let's assume that it's small enough to fit in memory. Is it always square shaped, meaning, 
        /// is the number of columns equal to the number of rows? The answer here is yes. Could the given array be empty? 
        /// No, the size of the chessboard would be at least one by one.
        ///
        /// As usual, try solving this problem using any language you'd like to use, and run your code to make sure it's correct.
        /// If you want, you're welcome to use the test cases in the Jupyter notebook that's provided for this problem as well.
        /// 
        /// </summary>
        /// <param name="args"></param>

        // Test cases:
        private static int[,] test1, test2, test3, test4, test5, test6;

        static void Main(string[] args)
        {
            Console.WriteLine("Question #3:\n");

            // True:
            //Console.WriteLine($"Test #1\n");
            test1 = new int[4, 4] {
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 1 }
            };
            Console.WriteLine($"Test #1: {rooks_are_safe(test1)}");

            // False
            //Console.WriteLine($"Test #2\n");
            test2 = new int[2, 2] {
                { 1, 0 },
                { 1, 0 }
            };
            Console.WriteLine($"Test #2: {rooks_are_safe(test2)}");

            // False:
            //Console.WriteLine($"Test #3\n");
            test3 = new int[3, 3] {
                { 0, 0, 0 },
                { 1, 0, 1 },
                { 0, 0, 0 }
            };
            Console.WriteLine($"Test #3: {rooks_are_safe(test3)}");

            // True:
            //Console.WriteLine($"Test #4\n");
            test4 = new int[4, 4] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 0, 1 },
                { 0, 0, 0, 0 }
            };
            Console.WriteLine($"Test #4: {rooks_are_safe(test4)}");

            // True:
            //Console.WriteLine($"Test #5\n");
            test5 = new int[2, 2] {
                { 1, 0 },
                { 0, 1 }
            };
            Console.WriteLine($"Test #5: {rooks_are_safe(test5)}");

            // False:
            //Console.WriteLine($"Test #6\n");
            test6 = new int[4, 2] {
                { 0, 0 },
                { 0, 0 },
                { 0, 0 },
                { 1, 1 }
            };
            Console.WriteLine($"Test #6: {rooks_are_safe(test6)}");

            Console.ReadKey();
        }

        /// <summary>
        /// Test rows. Big O: O(n2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static bool TestRows(int[,] arr)
        {
            bool isSafe = true;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int rooks = 0;

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    System.Diagnostics.Debug.WriteLine($"Row: {row} col: {col} Length: {arr.GetLength(0)} rooks: {rooks}");

                    if (arr[row, col] == 1)
                    {
                        rooks++;
                    }

                    if (rooks > 1)
                    {
                        isSafe = false;
                        break;
                    }
                }
            }

            return isSafe;
        }

        /// <summary>
        /// Test columns. Big O: O(n2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static bool TestColumns(int[,] arr)
        {
            bool isSafe = true;

            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int rooks = 0;

                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    System.Diagnostics.Debug.WriteLine($"Row: {row} col: {col} Length: {arr.GetLength(0)} rooks: {rooks}");

                    if (arr[row, col] == 1)
                    {
                        rooks++;
                    }

                    if (rooks > 1)
                    {
                        isSafe = false;
                        break;
                    }
                }
            }

            return isSafe;
        }

        /// <summary>
        /// Test if any of the rooks are able to attack any other ones.
        /// Big O: 2O(n2) = O(n2) 
        /// n2 is n square
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static bool rooks_are_safe(int[,] arr)
        {
            if (!TestRows(arr)) // Big O: O(n2)
            {
                System.Diagnostics.Debug.WriteLine("Case #1");
                return false;
            }
            else if (!TestColumns(arr)) // Big O: O(n2)
            {
                System.Diagnostics.Debug.WriteLine("Case #2");
                return false;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Case #3");
                return true;
            }
        }

    }
}
