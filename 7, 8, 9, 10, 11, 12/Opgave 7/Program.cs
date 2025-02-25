namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et tal og find ud af om det er positivt negative eller 0: ");
            double number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"Tallet {number} er positivt.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Tallet {number} er negativt.");
            }
            else
            {
                Console.WriteLine("Tallet er nul.");
            }
            Console.ReadLine();
            Console.Clear();

            
        }
    }
}
