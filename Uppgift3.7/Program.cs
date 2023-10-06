using System;
namespace Uppgift3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition eller en subtraktion");
            string problem = Console.ReadLine();

            char räknesätt = problem.Contains('+') ? '+' : '-';

            float tal1 = float.Parse(problem[..problem.IndexOf(räknesätt)]);
            float tal2 = float.Parse(problem[(problem.IndexOf(räknesätt) + 1)..]);

            if (räknesätt == '+')
            {
                Console.WriteLine($"={tal1 + tal2}");
            }
            else
            {
                Console.WriteLine($"={tal1 - tal2}");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}
