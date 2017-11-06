using System;

namespace TwoDArray
{
    class TwoDArrayProgram
    {
        /// <summary>
        /// 
        /// - [Narrator] Here's a quick overview of two-dimensional array. 
        /// Two dimensional arrays are often used in coding interviews, so let's examine how it works. 
        /// Conceptually, a two-dimensional array is a collection of items, for example, a collection of numbers, 
        /// that's laid out in a two-dimensional table. For example, this table on the screen has two rows and four 
        /// columns with the items, one, three, nine, four, five, zero, eight, and negative three. 
        /// A two-dimensional array like this one is usually implemented as an array of arrays.
        ///
        /// So this two-dimensional array would be typically represented as an array of two arrays, 
        /// the first one containing the first row, one, three, nine, four, and the second array containing the second row, 
        /// five, zero, eight, and negative three.One common assumption here is that a two-dimensional array has a rectangular shape. 
        /// What that means is, each row has the same number of items as all the other rows. You might want to clarify this by asking 
        /// something like, "can we assume that each row has the same number of items?" 
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.WriteLine("2D Arrays:\n");

            // Problem 1: Initialize a new 2D array with[1, 2, 3] in the first row 
            // and [5, 6, 7] in the second row.
            // Store it in a new variable called a_2d.
            int[,] a_2d = new int[2, 3] {
                { 1, 2, 3 },
                { 5, 6, 7 }
            };

            // Problem 2: From the 2D array called b_2d, defined below, replace the number 6 with the number 99.
            a_2d[1, 1] = 99;

            //Problem 3: Iterate over each item in c_2d and print it using the FOREACH syntax.
            foreach (var item in a_2d)
            {
                Console.WriteLine(item);
            }

            // Problem 4: Iterate over each item in d_2d and print it using the FOR syntax.
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine(a_2d[row, col]);
                }
            }

            // Problem 5: You're given a 2D array with the same number of rows and columns.  
            // Write a function that adds up the diagonal elements and returns the sum.
            // For example, you're given the following 2D array:
            //
            // [[1, 2, 3],  
            //  [4, 5, 6],  
            //  [7, 8, 9]]
            //
            // "The diagonal elements are 1, 5, and 9, so your function should return 15."
            int[,] b_2d = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine($"Sum of the diagonal elements: {SumDiagonal(b_2d)}");

            //Console.WriteLine($"Length: {b_2d.Length}");
            //Console.WriteLine($"Long Length: {b_2d.LongLength}");
            //Console.WriteLine($"Long Length: {b_2d.GetLength(1)}");


            Console.ReadKey();
        }

        /// <summary>
        /// Function that adds up the diagonal elements and returns the sum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int SumDiagonal(int[,] arr)
        {
            int rowIndx = 0;
            int indx = 0;
            int sum = 0;

            while (true)
            {
                try
                {
                    sum += arr[rowIndx, indx];

                    //Debug only:
                    System.Diagnostics.Debug.WriteLine(
                        $"rowIndx: {rowIndx} colIndx: {indx} number:{arr[rowIndx, indx]} sum: {sum}");

                    indx++;
                    rowIndx++;
                }
                catch (System.IndexOutOfRangeException)
                {
                    break;
                }
            }

            return sum;
        }

    }
}
