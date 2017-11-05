using System;

namespace Question2
{
    class Question2Program
    {
        /// <summary>
        /// - [Instructor] Here is sample interview question number two with string. 
        /// Here's the problem. You're given two strings which represent two integers, 
        /// for example, these two on the screen, 1,232 and 201. And the problem is 
        /// writing a function that compares these two strings as numbers. 
        /// Let's say we want to write a function that's called larger than which takes 
        /// these two strings as inputs and it turns true if the first number is larger than the second one.
        /// 
        /// If the first number is less than the second one, for example, 202 is less than 232, 
        /// then we should return false from this function.If this question is asked in your actual interview, 
        /// you might want to ask these clarifying questions. Could the strings be empty? No, just assume that 
        /// they are never empty for convenience sake. Could the numbers be negative? No, they are always non-negative, 
        /// so they are always either zero or positive.
        /// 
        /// Can I use the int function to convert the strings to numbers so we can compare them more easily? 
        /// No, in this case, try solving this problem without converting them to numbers first.Converting 
        /// them to numbers is not the most efficient solution and it wouldn't work with very large numbers 
        /// either but in Python you can use a simple comparison operator if you're comparing single digit 
        /// numbers in strings.The string three larger than the string two returns true because the number 
        /// three is larger than the number two, but this doesn't necessarily work with strings with more than one character.
        /// 
        /// What if they're the same number? For example, 22 and 22? Then, larger than 22 and 22 should return false, 
        /// so we're doing a strict comparison here. Now try solving this problem with Python or any other language you 
        /// like to use and make sure to run your code when you're done. Feel free to use our exercise file for this 
        /// problem with Jupyter Notebook.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
