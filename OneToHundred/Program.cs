using System;

namespace OneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            //program kuvab konsoolis arve 1 kuni 100
            //kasutame for-loopi
            for (int i = 0; i < 100; i++)//int i = 0 - start, i < 10 - end, i++ step 
            {
                Console.WriteLine($"{i + 1}. Eat my shorts. ");
            }
        }
    }
}
