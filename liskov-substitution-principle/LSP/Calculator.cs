namespace LSP
{
    public abstract class Calculator
    {
        protected int[] _numbers;

        protected Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }
}
