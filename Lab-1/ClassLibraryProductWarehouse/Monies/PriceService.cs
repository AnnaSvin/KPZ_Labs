using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Monies
{
    public class PriceService
    {
        public Money ReducePrice(Money price, Money reduceAmount)
        {
            return MoneyOperations.ReducePrice(price, reduceAmount);
        }

        public Money IncreasePrice(Money price, Money increaseAmount)
        {
            return MoneyOperations.IncreasePrice(price, increaseAmount);
        }
    }
}
