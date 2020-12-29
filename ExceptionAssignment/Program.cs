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
            
            try
            {
                int numResult = Convert.ToInt32(Console.ReadLine());
                foreach (int num in newNum)
                {
                    int divNum = num / numResult;
                    Console.WriteLine(divNum);
                    Console.ReadLine();
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Unable to divide these numbers by Zero.");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Cannot divide letter format.");
            }
            Console.WriteLine("The program has finished the try/catch block.");
        }
    }
}
