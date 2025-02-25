namespace _22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double triangleArea = Areal(7, 10);
            double rectangleArea = Areal(4, 10, true);

            Console.WriteLine($"Arealet af trekanten er: {triangleArea}");
            Console.WriteLine($"Arealet af rektanglen er: {rectangleArea}");

        }

        static double Areal(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double Areal(double width, double height, bool isRectangle)
        {
            return width * height;
        }
    }
}
