using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newNum = new List<int> { 33, 44, 50, 100 };
            Console.WriteLine("Enter a number to divide by.");
            int numResult = Convert.ToInt32(Console.ReadLine());

            foreach(int num in newNum)
            {
                int divNum = newNum / numResult;

            }
        }
    }
}
