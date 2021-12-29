using System;

namespace LB_2
{
    class Programm
    {
        static void Main(string[] args)
        {

            B bObject = new B(3, 4, 5, 7);
            B aObject = new B(4, 4, 5, 7);

            if (bObject)
            {
                Console.WriteLine($"d is positive");
            }
            else
            {
                Console.WriteLine($"d is negative");
            }

            if (bObject | aObject)
            {
                Console.WriteLine($"same objects");
            }
            else
            {
                Console.WriteLine($"not same");
            }

            Console.Read();
        }
    }
}
