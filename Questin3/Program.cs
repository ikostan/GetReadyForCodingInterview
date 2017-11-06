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
        /// and one means that there's a rook there. Very simple. And the given board could have a smaller size than the real chessboard. 
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

        static void Main(string[] args)
        {
            Console.WriteLine("Question #3:\n");



            Console.ReadKey();
        }
    }
}
