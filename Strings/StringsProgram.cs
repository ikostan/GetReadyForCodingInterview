using System;

namespace Strings
{
    class StringsProgram
    {
        /// <summary>
        /// - [Instructor] Here's a quick review of string in C#. 
        /// String is one of the most commonly used topics in coding interviews so let's get right into it. 
        /// You can think of it sort of like a list that only stores characters instead of storing items of any types.
        /// The first thing to keep in mind is that string in C# is some how similar to Array.
        /// One key difference here is a list is mutable in C# whereas a string is immutable which means once a string is initialized, 
        /// we won't be able to edit its content in the same way as we can edit list's content.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //string str = "Hello World!";

            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str.Substring(i, 1));
            //}


            //Problem 1: Initialize a new string, "ABC", and store it in a new variable called a_string.
            string a_string = "ABC";
            Console.WriteLine(a_string);

            //Problem 2: From the string called b_string, defined below, retrieve and print the second character.
            string b_string = "DEF";
            Console.WriteLine(b_string.Substring(1, 1));

            //Problem 3: Iterate over each character in c_string and print it using the FOREACH syntax.
            string c_string = "GHI";

            foreach (char item in c_string)
            {
                Console.WriteLine(item);
            }

            //Problem 4: Iterate over each character in d_string and print it using the FOR syntax.
            string d_string = "PQR";

            for (int i = 0; i < d_string.Length; i++)
            {
                Console.WriteLine(d_string.Substring(i, 1));
            }

            //Problem 5: Write a function that takes two strings and returns True if they are reverses of each other.
            //For example, "ABC" and "CBA" are reverses of each other.  
            //Assume that the two strings are not empty and have the same length
     
            string a = "abc", b = "cba", c = "sdf";
            Console.WriteLine($"{a} and {b} are reversed: " + IsReverse(a, b));
            Console.WriteLine($"{a} and {c} are reversed: " + IsReverse(a, c));

            Console.ReadKey();
        }

        /// <summary>
        /// A function that takes two strings and returns True if they are reverses of each other
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool IsReverse(string a, string b)
        {
            bool isReverse = true;

            if (a.Length != b.Length)
            {
                isReverse = false;
            }
            else
            {
                char[] chrArr = b.ToCharArray();
                Array.Reverse(chrArr);
                b = new String(chrArr);
                //Console.WriteLine($"Reversed: {b}");

                if (!a.Equals(b))
                {
                    isReverse = false;
                }
            }

            return isReverse;
        }

    }
}
