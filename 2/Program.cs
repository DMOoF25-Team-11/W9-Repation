namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit (˚F) til Celsius (˚C)");
            int fahrenheit = 32;
            int celsius = 40;
            double convert = celsius * (9f / 5f) + 32;
            Console.WriteLine((9 / 5) + 32);
            Console.WriteLine($"Celsius til Fahrenheit {convert}");


            Console.WriteLine("Celsius (˚C) til Fahrenheit (˚F)");
            int celsius2 = 20;
            int fahrenheit2 = -32;
            double convert2 = fahrenheit2 -32 * (5f / 9f);
            Console.WriteLine(-32 + (5/9));
            Console.WriteLine($"Fahrenheit til Celsius {convert2}");

            Console.ReadKey();
        }
    }
}
