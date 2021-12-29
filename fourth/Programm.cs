using System;

namespace LB_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            float length = 2;

            A aObject = new A(17, 3); 
            B bObject = new B(length, 7, 5, 1);
            C<int> intC = new C<int>();
            C<String> stringC = new C<String>();

            Console.WriteLine($"Result c: {aObject.c}");
            Console.WriteLine($"Result c from B: {bObject.c}");
            Console.WriteLine($"Result c2: {bObject.c2}");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"b[{i}]: {bObject[i]}");
            }

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"b[{i},{j}]: {bObject[i,j]}");
                }
            }

            intC.forParam = 5;
            stringC.forParam = "hi!";

            Console.WriteLine();
            Console.WriteLine($"Result param int: {intC.forParam}");
            Console.WriteLine($"Result param string: {stringC.forParam}");
            Console.WriteLine($"Result static field: {C<int>.value}");

            Console.Read();
        }
    }
}
