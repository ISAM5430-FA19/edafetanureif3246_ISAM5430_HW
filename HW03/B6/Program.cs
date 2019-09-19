using System;
using static System.Console;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int previous = 0;
            int min = int.MaxValue;
            bool ans = false;
            while (true)
            {
                WriteLine("enter number");
                int currnumber = int.Parse(ReadLine());
                if (currnumber <= 0)
                {
                    break;
                }
                else
                {
                    
                    count++;
                    if (currnumber < min)
                    {
                        min = currnumber;
                    }
                }
                previous = currnumber;
            }
            int a = min * min;
            if (a < previous)
            {
                previous++;
            }
            WriteLine($"last number greater than the square of the smallest is{previous}");
        }
    }
}
