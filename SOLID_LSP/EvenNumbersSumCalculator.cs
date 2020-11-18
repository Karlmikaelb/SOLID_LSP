using System.Linq;

namespace SOLID_LSP
{
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {

        }

        public override int Calculate()
        {
            return Numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}