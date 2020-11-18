using System;

namespace SOLID_LSP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new int[] {5, 7, 9, 10, 3, 2, 6, 4, 8};

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"Summan av alla nummer är: {sum.Calculate()}");

            Console.WriteLine();

            Calculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"Summan av alla jämna tal är: {evenSum.Calculate()}");
            Console.ReadLine();
        }
    }
}
