using System;

 namespace LB_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            A aObject = new A(18, 3); 
            B bObject = new B(2, 9, 60);

            Console.WriteLine($"Result: {aObject.c}");
            Console.WriteLine($"Result: {bObject.c2}");
            Console.Read();
        }
    }
}
