using System;

namespace BigO
{
    class BigOProgram
    {
        /// <summary>
        /// 
        /// - [Instructor] In this chapter, we're going to talk about something called Time Complexity and Big-O Notation. 
        /// But why do we need them in the first place? Well, let's say in your coding interview you're given a problem and 
        /// you come up with two separate solutions or two separate functions. How do you know which one is a better solution? 
        /// How do you know which function runs faster than the other one? You should be able to ask certain question 
        /// like this because it's very common for the interviewer to ask something like, "How efficient is your solution?" 
        /// And Time Complexity and Big-O Notation are really good tools for answering this type of questions.
        ///
        /// Now, as an example, let's think about this question. In a function, we first initialize X20. 
        /// And for each item in a given list, we add that item to X. After that, we're going to return X so this function 
        /// simply finds us some of the items in the given list.Now, how long does this function take to complete? 
        /// It's actually a really hard question to answer because it depends on many, many factors such as the performance 
        /// of your computer and whether or not you're running other programs at the same time and also, which language you're using.
        ///
        /// Whether it's Python, Java, or C++. One way to find the time a given function takes to run is by running experiments. 
        /// You can do this by running this function with inputs, with different sizes, and measuring how much time it takes 
        /// to complete each time. But of course, this option is usually not available in a coding interview setting. 
        /// Or alternatively, you can get a rough idea of how long it takes to some kind of analysis without running this function on a computer.
        ///
        /// And Time Complexity and Big-O Notation are tools for exactly doing that.
        /// 
        /// Time complexity types:
        /// 
        /// 1. Linear (t => an + b = O(n)) - the time it takes to run this function grows linearly, or like a straight line. And, so, this function is said to have linear time complexity.
        /// 2. Constant (t => constant x 1 = O(1)) - the function takes a constant amount of time regardless of the input. That's why this function is said to have constant time complexity.
        /// 3. Quadratic (t => an2 + c = O(n2)) - the shape of this line is similar to the function n squared, which is a quadratic function. And, so, this function has quadratic time complexity.
        /// 
        /// - [Instructor] Big-O Notation is a way of indicating how complex a function is and how much time 
        /// it takes to run your function. It's also a convenient way to express the time complexity of a function, 
        /// and it comes up a lot in a coding interview.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Time Complexity and Big O:\n");

            // 2O(n) = O(n)
            // nO(n) = n(an + b) = an2 + bn = O(n2) //n2 => n square
            // nO(x) = O(nx)
            // yO(x) = O(yx)


            /*
             
              Example:

                array_2d = {{4, 7}, {1, 1}};
                
                int total(int[,] array_2d)
                {
                    int x = 0;                                                      ==> O(1)
                    
                    for(int row = 0; row < array_2d.GetLength(0); row++)            ==> nO(1) = O(n)
                    {                                                                                  ==>    nO(n) = O(n2)
                        for(int col = 0; col < array_2d.GetLength(0); col++)        ==> nO(1) = O(n)
                        {
                            x += array_2d[row, col]; 
                        }
                    }
            
                    return x;                                                        ==> O(1)
                }
              
             */

            Console.ReadKey();
        }

    }
}
