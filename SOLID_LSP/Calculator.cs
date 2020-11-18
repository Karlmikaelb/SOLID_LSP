namespace SOLID_LSP
{
    public abstract class Calculator
    {
        protected readonly int[] Numbers;

        public Calculator(int[] numbers)
        {
            Numbers = numbers;
        }

        public abstract int Calculate();
    }
}