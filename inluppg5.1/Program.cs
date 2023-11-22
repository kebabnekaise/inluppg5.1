using System;

namespace inluppg4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv fem namn, med enter mellan dem");
            string[] namn = new string[5];

            for (int i = 0; i < 5; i++)
            {
                namn[i] = Console.ReadLine();
            }

            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}