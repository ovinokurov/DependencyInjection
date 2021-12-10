using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalResovle
{
    class USATaxCalculator : ITaxCalculator
    {
        public int Calculate()
        {
            return 18;
        }
    }
}
