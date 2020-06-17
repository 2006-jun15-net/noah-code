//in C#, a project is compiled as on unit and deployed or run as one unit
// a namespace is for "logical" organization of classes/stuff

using System;

namespace ReverseString
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();
            String result = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                
                result += str[i].ToString();
            }

            Console.WriteLine("Reversed String: " + result);
        }
    }
}