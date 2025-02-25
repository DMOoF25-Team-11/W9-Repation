namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountVokals("Hello, World!"));
        }

        static int CountVokals(string input)
        {
            var vokals = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'æ', 'ø', 'å' };
            return input.Count(c => vokals.Contains(char.ToLower(c)));
        }
    }
}
