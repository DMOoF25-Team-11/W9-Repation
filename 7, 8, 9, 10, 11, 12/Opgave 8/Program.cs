namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen og tillykke med din karakter!");
            Console.Write("Skriv hvad din karater er blevet for at få en bekræftigelse (A, B, C, D & F): ");
            char karakter = char.Parse(Console.ReadLine());
            
if (karakter == 'A' || karakter == 'B' || karakter == 'C' || karakter == 'D')
            {
                Console.WriteLine("Tillykke du har bestået!!!");
            }
            else
            {
                Console.WriteLine("Desvære du har ikke bestået");
            }
        }
    }
}
