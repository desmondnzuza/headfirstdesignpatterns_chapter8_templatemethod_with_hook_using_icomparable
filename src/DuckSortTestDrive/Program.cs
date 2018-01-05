using System;

namespace DuckSortTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2),
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);

            Console.ReadLine();
        }

        private static void Display(Duck[] ducks)
        {
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i]);
            }
        }
    }
}
