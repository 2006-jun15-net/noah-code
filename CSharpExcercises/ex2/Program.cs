using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for input
            Console.WriteLine("Enter number of stairs: ");
            String num = Console.ReadLine();
            // parse input into an integer
            int numOfStairs = int.Parse(num);

            //Setup the array based on user input
            String[] stair = new String[numOfStairs];
            for(int i = 0; i < numOfStairs; i++)
            {
                stair[i] = " ";
            }

            //for every iteration, print out the array one character at a time
            //then add a "#" to the end of the array
            for(int i = numOfStairs-1; i >= 0; i--)
            {
                for(int j = 0; j < numOfStairs; j++)
                {
                    Console.Write(stair[j]);
                } 
                 stair[i] = "#";
                 Console.WriteLine();
            }
        }
    }
}
