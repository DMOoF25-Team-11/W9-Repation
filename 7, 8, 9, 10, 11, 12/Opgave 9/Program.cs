namespace Opgave_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et årstal og find ud af om det er skudår: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"{year} er et skudår.");
                }
                else
                {
                    Console.WriteLine($"{year} er ikke et skudår.");
                }
            }
            else
            {
                Console.WriteLine($"{year} er ikke et skudår.");
            }
        }
    }
}
