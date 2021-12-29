using System;

namespace LB_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            A aObject = new A(17.4F, 4.4F); 
            B bObject = new B(3.4F, 2.4F, 4.4F, 1.4F);

            Console.WriteLine($"Result c: {aObject.c}");
            Console.WriteLine($"Result c from B: {bObject.c}");
            Console.WriteLine($"Result c2: {bObject.c2}");
            bObject.printArr();
            Console.Read();
        }
    }
}
