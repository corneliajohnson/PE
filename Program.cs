using System;

namespace PracticeExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise(51);
        }

        static void exercise(int n)
        {
            if (n > 51)
            {
                Console.WriteLine((n-51) * 3);
            }
            else
            {
                Console.WriteLine(51 -n);
            }

        }
    }
}
