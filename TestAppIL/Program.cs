using System;

namespace TestAppIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(10, 20);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
