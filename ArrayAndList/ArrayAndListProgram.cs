using System;

namespace ArrayAndList
{
    class ArrayAndListProgram
    {

        static string[] a_list, c_list;
        static int[] b_list;

        static void Main(string[] args)
        {

            //Problem 1: Initialize a new list called a_list with the elements ["item1", "item2", "item3"]
            a_list = new string[] { "item 1", "item 2", "item 3" };
            RunByIndex(a_list);
            RunAsList(a_list);

            //Problem 2: Change the second element in b_list(defined below) to 1.
            b_list = new int[] { 0, 0, 0 };
            ChangeElement(b_list, 1, 1);
            RunAsList(b_list);

            //Problem 3: Iterate over each element in c_list and print it using the foreach loop.
            c_list = new string[] { "item0", "item1", "item2" };
            RunAsList(c_list);

            Console.ReadKey();
        }

        /// <summary>
        /// Display array members using index
        /// </summary>
        /// <param name="arr"></param>
        private static void RunByIndex(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        /// <summary>
        /// Display array members using foreach loop
        /// </summary>
        /// <param name="arr"></param>
        private static void RunAsList(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Display array members using foreach loop
        /// </summary>
        /// <param name="arr"></param>
        private static void RunAsList(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Change value by index
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        private static void ChangeElement(int[] arr, int index, int newValue)
        {
            if (index <= arr.Length)
            {
                arr[index] = newValue;
            }
        }

    }
}
