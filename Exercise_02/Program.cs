using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 8;
            string first = num1.ToString();
            string second = num2.ToString();
            Console.WriteLine(first + second);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            int difference = (num1 - num2);
            string differenceString = difference.ToString();
            double a = Math.Sqrt(num1 - num2);
            if (num1 - num2 > 0) 
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Cannot find square root, the value " + differenceString + " is negative.");
            }

            Console.ReadLine();
        }
    }
}
