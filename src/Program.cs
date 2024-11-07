namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 4-digit number :");
            var number = Convert.ToInt32(Console.ReadLine());
            var ones = number % 10;
            var tens = number / 10 % 10;
            var hundrets = number / 100 % 10;
            var thousands = number / 1000 % 10;
            var result = ones + tens + hundrets + thousands;
            Console.WriteLine(result);
        }

    }
}
