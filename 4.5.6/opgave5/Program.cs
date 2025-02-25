namespace opgave5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beregning af areal og omkreds af en cirkel baseret på en given radius


            Console.WriteLine("Beregning af areal og omkreds(circumference) af en cirkel"); 
            Console.Write("Indtast radius: ");
            double radius = Convert.ToDouble(Console.ReadLine()); 

            double area = double.Pi * (radius * radius); 
            double circumference = 2 * double.Pi * radius; 

            Console.Clear();
            Console.WriteLine(" Area: " + area + ", Circumference: " + circumference); 
            Console.ReadLine();
        }
    }
}
