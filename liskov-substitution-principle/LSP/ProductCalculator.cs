using System.Linq;

namespace LSP
{
    public class ProductCalculator: Calculator
    {
        public ProductCalculator(int[] numbers)
            :base(numbers)
        {
        }

        public override int Calculate()
        {
            var prod = 1;
            foreach(var num in _numbers)
            {
                prod = prod * num;
            }
            return prod;
        }
    }
}
