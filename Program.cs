using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI-beregner");
            Console.WriteLine();
            Console.WriteLine("Indtast vægt (kg)");
            string weightInput = Console.ReadLine();
            double weight;
            

            Console.WriteLine("Indtast højde (meter)");
            string heightInput = Console.ReadLine();
            double height;


            if (double.TryParse(weightInput, out weight) && double.TryParse(heightInput, out height))
            {
                //Beregn BMI
                double bmi = weight / Math.Pow(height, 2);
                Console.WriteLine($"BMI er: + {bmi}");
            }
            

            Console.ReadKey();

        }
    }
}
