using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up string array 
            String[] stair = new String[8];
            for(int i = 0; i < 8; i++)
            {
                stair[i] = " ";
            }
            //for every iteration, print out the array one character at a time
            //then add a "#" to the end of the array
            for(int i = 7; i >= 0; i--)
            {
                for(int j = 0; j < 8; j++)
                {
                    Console.Write(stair[j]);
                } 
                 stair[i] = "#";
                 Console.WriteLine();
            }
        }
    }
}
