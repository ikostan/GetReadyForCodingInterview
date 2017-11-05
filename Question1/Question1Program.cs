using System;

namespace Question1
{
    class Question1Program
    {
        /// <summary>
        /// - [Instructor] Here's Sample Interview Question number one with array or a Python list. 
        /// Here's the problem: You're given an array of integers: {1,3,4,5,0,2} 
        /// Please write a function which takes the the given array and finds and returns the second largest number in this array. 
        /// Let's call this function second largest. So second largest of this array on the screen 
        /// should return four because five is the largest number in this array and four is the second largest. 
        /// Now, whenever you get a question in your coding interview, you should always ask clarifying questions 
        /// to make sure you have all the right assumptions.
        /// 
        /// For this question, you might ask, "could this array be empty?". 
        /// The answer is yes, you should return ZERO in that case. 
        /// None in Python, by the way, is like no in some other languages, and it just means that it's an empty value. 
        /// Could this array or Python list have only one element inside it? Yes, in that case, 
        /// second largest should return none as well. What if we had, say, two two one. Then second largest should return two.
        ///
        /// You might say, "well, it doesn't really make sense mathematically, but that's just how we define it here." 
        /// And the interviewer is really the one who decides if your answer is correct, so you should always ask the 
        /// interviewer what the correct thing to do would be if you're not sure. Now pause the video, solve the problem, 
        /// and make sure to run your code to check if it's correct.You can use any language to solve this problem, 
        /// and if you like to use Python, feel free to use the exercise file for this problem with Jupiter Notebook.
        /// </summary>
        /// <param name="args"></param>

        private static int[] arr1, arr2, arr3, arr4;

        static void Main(string[] args)
        {
            Console.WriteLine("Question #1:\n");

            arr1 = new int[]{ 1, 3, 4, 5, 0, 2 };
            Console.WriteLine("The second largest number is: " + SecondLargest(arr1));

            arr2 = new int[] { };
            Console.WriteLine("The second largest number is: " + SecondLargest(arr2));

            arr3 = new int[] { 1 };
            Console.WriteLine("The second largest number is: " + SecondLargest(arr3));

            arr4 = new int[] { 2, 2, 1 };
            Console.WriteLine("The second largest number is: " + SecondLargest(arr4));

            Console.ReadKey();
        }

        /// <summary>
        /// Function which takes the the given array and finds and returns the second largest number in this array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int SecondLargest(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1) //Empty array OR has only one member
            {
                return 0;
            }
            else
            {
                Array.Sort(arr);
                return arr[arr.Length - 2];
            }
        }


    }
}
