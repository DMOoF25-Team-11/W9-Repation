namespace _21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cylender på radias 10 og højde 10 har et volume på " + (int)volumeCylender(10, 10));
            Console.WriteLine("Cube på højde 10, bredde 10 og dybde 10 har et volume på " + volumeCube(10, 10, 10));
        }

        static double volumeCylender(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        static double volumeCube(double height, double width, double debt)
        {
            return height * width * debt;
        }
    }
}
