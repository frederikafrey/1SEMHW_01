using System;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your height:");
            string answer = Console.ReadLine();
            int height = int.Parse(answer);
            if (height < 100)
            {
                Console.WriteLine("Oh dear, you are either a child or a midget.");
            }
            else if (height < 156)
            {
                Console.WriteLine("Not too tall..");
            }
            else if (height < 196)
            {
                Console.WriteLine("Average height");
            }
            else if (height > 195)
            {
                Console.WriteLine("Buying shoes cant be easy for you");
            }
            Console.ReadLine();
        }
    }
}
