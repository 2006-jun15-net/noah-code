using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for input
            Console.WriteLine("Enter a number: ");
            String num = Console.ReadLine();
            //parse input to integer
            int n = int.Parse(num);

            // Collatz method runs until the number n = 1
            while(n != 1)
            {
                if(n%2 ==0)
                {
                    n /= 2;
                }
                else
                {
                    n = n*3 + 1;
                }
                //print each iteration
                Console.WriteLine(n);
            }
        }
    }
}
