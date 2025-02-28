using ClassLibraryProductWarehouse.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Monies
{
    public static class MoneyOperations
    {
        public static Money ReducePrice(Money originalPrice, Money reduceAmount)
        {
            MoneyValidator.ValidateSameCurrency(originalPrice, reduceAmount);

            int originalTotalCents = ConvertToCents(originalPrice);
            int reduceAmountInCents = ConvertToCents(reduceAmount);

            int totalCents = originalTotalCents - reduceAmountInCents;
            if (totalCents < 0) totalCents = 0;

            return ConvertToMoney(totalCents, originalPrice.Currency);
        }

        public static Money IncreasePrice(Money originalPrice, Money increaseAmount)
        {
            MoneyValidator.ValidateSameCurrency(originalPrice, increaseAmount);

            int originalTotalCents = ConvertToCents(originalPrice);
            int increaseAmountInCents = ConvertToCents(increaseAmount);

            int totalCents = originalTotalCents + increaseAmountInCents;

            return ConvertToMoney(totalCents, originalPrice.Currency);
        }

        private static int ConvertToCents(Money price)
        {
            return price.WholePart * MoneyConstants.CentsInOneUnit + price.Cents;
        }

        private static Money ConvertToMoney(int totalCents, ICurrency currency)
        {
            int wholePart = totalCents / MoneyConstants.CentsInOneUnit;
            int cents = totalCents % MoneyConstants.CentsInOneUnit;
            return new Money(wholePart, cents, currency);
        }
    }
}
