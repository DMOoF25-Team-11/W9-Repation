namespace opgave6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Brug logiske og sammenligningsoperatører til at evaluere udtryk og udskriv resultaterne. 


            int a = 5;
            int b = 10;

            bool isEqual = (a == b); 
            bool isNotEqual = (a != b); 
            bool isGreater = (a > b); 
            bool isLess = (a < b); 
            bool isGreaterOrEqual = (a >= b); 
            bool isLessOrEqual = (a <= b); 

            Console.WriteLine("Is Equal: " + isEqual + ", Is Not Equal: " + isNotEqual + ", Is Greater: " + isGreater + ", Is Less: " + isLess + ", Is Greater or Equal: " + isGreaterOrEqual + ", Is Less or Equal: " + isLessOrEqual); 

        }
    }
}
