using System;
using System.Numerics;

namespace repetition
{
    internal class Program
    {
        //public class Students
        //{
        //    public int age = 25;
        //    public double height = 1.75;
        //    public double weight = 70.5;
        //    public char initial = 'A';
        //    public string name = "Alice";
        //    public bool student = true;
        //}

        private static void temperature()
        {
            Console.WriteLine("Input Celsius");
            double Fahrenheit = Double.Parse(Console.ReadLine()) * (9f / 5f) + 32;
            Console.WriteLine("The temperature in Fahrenheit is: " + Fahrenheit);

            Console.WriteLine("Input Fahrenheit");
            double Celsius = Convert.ToInt32((Console.Read()) - 32 * (5f / 9f));
            Console.WriteLine("The temperature in Celsius is: " + Celsius);
        }

        private static void bmi()
        {
            //BMI = vægten / højden^2
            Console.WriteLine("Indtast vægt");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast højde");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("BMI er");
            Console.WriteLine(height / Math.Pow(weight, 2));

        }

        private static void circle()
        {
            Console.WriteLine("Input radius");
            double r = Double.Parse(Console.ReadLine());
            double A = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(A);

            double O = 2 * Math.PI * r;
            Console.WriteLine(O);

        }

        private static void opgave7()
        {
            Console.WriteLine("Input number");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb > 0)
            {

                Console.WriteLine("Tallet er positivt");
            }
            if (numb == 0)
            {

                Console.WriteLine("Tallet er nul");
            }
            if (numb < 0) { Console.WriteLine("Tallet er negativt"); }
        }

        private static bool opgave8()
        {
            Console.WriteLine("Input A, B, C, D , or F");

            switch (Console.ReadLine())
            {
                case "A":
                    passed();
                    return true;
                case "B":
                    passed();
                    return true;
                case "C":
                    passed();
                    return true;
                case "D":
                    failed();
                    return true;
                case "F":
                    failed();
                    return true;
                default:
                    return true;
            }
        }

        private static void passed()
        {
            Console.WriteLine("You have passed");
        }

        private static void failed()
        {
            Console.WriteLine("You have failed try again");
        }

        private static void opgave9()
        {
            Console.WriteLine("Indtast årstal");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Det er skudår");
            }
            else
            {
                Console.WriteLine("Det er ikke skudår");
            }

        }

        private static bool opgave10()
        {
            Console.WriteLine("Indtast et til mellem 1-7");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("mandag");
                    return true;
                case "2":
                    Console.WriteLine("tirsdag");
                    return true;
                case "3":
                    Console.WriteLine("onsdag");
                    return true;
                case "4":
                    Console.WriteLine("torsdag");
                    return true;
                case "5":
                    Console.WriteLine("fredag");
                    return true;
                case "6":
                    Console.WriteLine("lørdag");
                    return true;
                case "7":
                    Console.WriteLine("søndag");
                    return true;
                default:
                    return true;

            }
        }

        private static bool opgave11()
        {
            Console.WriteLine("Indtast et til mellem 1-12");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Januar: Årets første måned, ofte kold og med sne i mange lande. Navnet kommer fra den romerske gud Janus, der havde to ansigter – et der så fremad, og et der så tilbage.");
                    return true;
                case "2":
                    Console.WriteLine("Februar: Den korteste måned, kendt for fastelavn og valentinsdag. Navnet kommer fra det latinske ord \"februa\", der betyder renselse.");
                    return true;
                case "3":
                    Console.WriteLine("Marts: Forårets komme begynder så småt. Navnet kommer fra den romerske krigsgud Mars.");
                    return true;
                case "4":
                    Console.WriteLine("April: Kendt for påske og for at være en måned med omskifteligt vejr. Navnet kommer fra det latinske ord \"aperire\", der betyder at åbne (blomsterne springer ud).");
                    return true;
                case "5":
                    Console.WriteLine("Maj: Foråret er i fuld gang, og naturen blomstrer. Navnet kommer fra den romerske gudinde Maia.");
                    return true;
                case "6":
                    Console.WriteLine("Juni: Sommerens begyndelse, ofte med varmt vejr og lange dage. Navnet kommer fra den romerske gudinde Juno.");
                    return true;
                case "7":
                    Console.WriteLine("Juli: Højsommer, mange holder ferie. Navnet kommer fra Julius Cæsar.");
                    return true;
                case "8":
                    Console.WriteLine("August: Stadig sommer, men dagene begynder at blive kortere. Navnet kommer fra kejser Augustus.");
                    return true;
                case "9":
                    Console.WriteLine("September: Efterårets begyndelse, bladene begynder at skifte farve. Navnet kommer fra det latinske ord \"septem\", der betyder syv (september var den syvende måned i den gamle romerske kalender).");
                    return true;
                case "10":
                    Console.WriteLine("Oktober: Efteråret er i fuld gang, og det kan være blæsende og regnfuldt. Navnet kommer fra det latinske ord \"octo\", der betyder otte.");
                    return true;
                case "11":
                    Console.WriteLine("November: En mørk og ofte trist måned, hvor mange tænker på de døde. Navnet kommer fra det latinske ord \"novem\", der betyder ni.");
                    return true;
                case "12":
                    Console.WriteLine("December: Årets sidste måned, kendt for jul og nytår. Navnet kommer fra det latinske ord \"decem\", der betyder ti.");
                    return true;
                default:
                    return true;

            }
        }

        private static void opgave12()
        {
            for (int i = 1; i < 11; i++) { Console.WriteLine(i); }
        }

        private static void opgave13()
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
        }

        private static void opgave14() 
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine(i);
            }
            while (i < 10);
        }

        private static void opgave15()
        {
            Console.WriteLine("Input number");
            int numb = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= numb; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
        }

        private static void opgave16()
        {
            Console.WriteLine("Input number");
            int numb = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = numb; i > 0; i--)
                result *= i;

            Console.WriteLine(result);
        }

        private static void opgave17()
        {
            Console.WriteLine("Input integer");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input integer");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total is " + (int1 + int2));
        }

        private static void opgave18()
        {
            Console.WriteLine("Indtast et ord");
            string word = Console.ReadLine();
            string[] wordArry = new string[] { word };

            string reversedWord = new string(wordArry[0].Reverse().ToArray());

            string[] wordArryReversed = new string[] { reversedWord };

            Console.WriteLine("Reversed word: " + wordArryReversed[0]);
        }

        private static void opgave19()
        {
            {
                Console.WriteLine(CountVokals("Hello, World!"));
            }

            static int CountVokals(string input)
            {
                var vokals = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'æ', 'ø', 'å' };
                return input.Count(c => vokals.Contains(char.ToLower(c)));
            }
        }

        private static void opgave20()
        {
            Console.WriteLine("Indtast sidelængden på A");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast sidelængden på B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(A * B);

            Console.WriteLine("Indtast radius");
            int Radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.PI * Math.Pow(Radius, 2));
        }



        //Forstår ikke overload
        private static void opgave21()
        {
            //Console.WriteLine("Indtast højden på cylinderen");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Indtast radius af cylinderen");
            //int Radius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Math.PI * Math.Pow(Radius, 2) * A);

            //Console.WriteLine("Indtast sidelængden på B af kuben");
            //int B = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Indtast sidelængden på C af kuben");
            //int C = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Indtast sidelængden på D af kuben");
            //int D = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kuben har rumfang " + (B * C * D));

            double total = Multiply(2, 3);

            static double Multiply(double A, double Radius)
            {
                return Math.PI * Math.Pow(Radius, 2) * A;
            }

            static double Multiply(double B, double C, double D)
            {
                return (B * C * D);
            }

            Console.WriteLine(total);
        }


        //Forstår ikke overload
        private static void opgave22()
        {
            int total = Multiply(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            static int Multiply(int A, int B, int C)
            {
                return A * B / C;
            }

            static int Multiply(int A, int B)
            {
                return A * B;
            }

            Console.WriteLine(total);
        }

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
                {
                showMenu = MainMenu();
                }

            temperature();
            bmi();
            circle();
            opgave7();
            opgave8();
            opgave9();
            opgave10();
            opgave11();
            opgave12();
            opgave13();
            opgave14();
            opgave15();
            opgave16();
            opgave17();
            opgave18();
            opgave19();
            opgave20();
            opgave21();
            opgave22();
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) temperature");
            Console.WriteLine("2) bmi");
            Console.WriteLine("4) circle");
            Console.WriteLine("5) opgave7");
            Console.WriteLine("6) opgave8");
            Console.WriteLine("7) opgave9");
            Console.WriteLine("8) opgave10");
            Console.WriteLine("9) opgave11");
            Console.WriteLine("10) opgave12");
            Console.WriteLine("11) opgave13");
            Console.WriteLine("12) opgave14");
            Console.WriteLine("13) opgave15");
            Console.WriteLine("14) opgave16");
            Console.WriteLine("15) opgave17");
            Console.WriteLine("16) opgave18");
            Console.WriteLine("17) opgave19");
            Console.WriteLine("18) opgave20");
            Console.WriteLine("19) opgave21");
            Console.WriteLine("20) opgave22");

            Console.WriteLine("22) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    temperature();
                    return true;
                case "2":
                    bmi();
                    return true;
                case "3":
                    circle();
                    return true;
                case "4":
                    opgave7();
                    return true;
                case "5":
                    opgave8();
                    return true;
                case "6":
                    opgave9();
                    return true;
                case "7":
                    opgave10();
                    return true;
                case "8":
                    opgave11();
                    return true;
                case "9":
                    opgave12();
                    return true;
                case "10":
                    opgave13();
                    return true;
                case "11":
                    opgave14();
                    return true;
                case "12":
                    opgave15();
                    return true;
                case "13":
                    opgave16();
                    return true;
                case "14":
                    opgave17();
                    return true;
                case "15":
                    opgave18();
                    return true;
                case "16":
                    opgave18();
                    return true;
                case "17":
                    opgave19();
                    return true;
                case "18":
                    opgave20();
                    return true;
                case "19":
                    opgave21();
                    return true;
                case "20":
                    opgave22();
                    return true;
                case "21":
                    return false;
                default:
                    return true;
            }
        }
    }
}

