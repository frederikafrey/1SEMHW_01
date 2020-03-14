using System;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Frey";
            Console.WriteLine("{0}{0}{0}{0}", name);
            Console.WriteLine("{0}        {0}", name);
            Console.WriteLine("{0}        {0}", name);
            Console.WriteLine("{0}{0}{0}{0}", name);
            Console.ReadLine();
        }
    }
}
