using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
