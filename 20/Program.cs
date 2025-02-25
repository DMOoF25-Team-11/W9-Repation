namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirke på radias 22 har areal på " + (int)Areal(22));
            Console.WriteLine("Rektangel på 10x5 har areal på " + Areal(10, 5));
        }

        static double Areal(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double Areal(double width, double height)
        {
            return width * height;
        }
    }
}
