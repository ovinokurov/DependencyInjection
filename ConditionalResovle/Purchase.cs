using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalResovle
{
    public class Purchase
    {
        private readonly Func<UserLocations, ITaxCalculator> _accessor;

        public Purchase(Func<UserLocations, ITaxCalculator> accessor)
        {
            _accessor = accessor;
        }

        public int CheckOut(UserLocations location)
        {
            var tax = _accessor(location);
            var total = tax.Calculate() + 100;

            return total;
        }
    }
}
