using System.Linq;

namespace LSP
{
    internal class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(n => n % 2 == 0).Sum();
    }
}
