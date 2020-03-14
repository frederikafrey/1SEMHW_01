using System;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("What is the capital city of Spain?");
            string answer1 = Console.ReadLine();
            string correctanswer1 = "Madrid";
            if (answer1 == correctanswer1)
            {
                i = i + 1;
            }
            Console.WriteLine("How many days are in January?");
            string answer2 = Console.ReadLine();
            int a = int.Parse(answer2);
            if (a == 31)
            {
                i = i + 1;
            }

            Console.WriteLine("Which of them is an animal? Enter the number for correct answer.");
            Console.WriteLine("1. Computer");
            Console.WriteLine("2. Fork");
            Console.WriteLine("3. Lion");
            string answer3 = Console.ReadLine();
            string correctanswer3 = "3";
            if (answer3 == correctanswer3)
            {
                i = i + 1;
            }
            if (i == 3)
            {
                Console.WriteLine("Good job! You had all correct answers!");
            }
            if (i == 2)
            {
                Console.WriteLine("You had 2 correct answers.");
            }
            if (i == 1)
            {
                Console.WriteLine("You had 1 corret answer.");
            }
            if (i == 0)
            {
                Console.WriteLine("You had no correct answers.");
            }
            if (answer1 != correctanswer1)
            {
                Console.WriteLine("The capital city of Spain is Madrid.");
            }
            if (a != 31)
            {
                Console.WriteLine("There are 31 days in January.");
            }
            if (answer3 != correctanswer3)
            {
                Console.WriteLine("Lion is an animal.");
            }
                Console.ReadLine();

        }
    }
}
