using ClassLibraryProductWarehouse.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Monies
{
    public static class MoneyValidator
    {
        public static void Validate(ICurrency currency, int whole, int cents)
        {
            ValidateCurrency(currency);
            ValidateAmount(whole, cents);
        }

        public static void ValidateCurrency(ICurrency currency)
        {
            if (currency == null)
                throw new ArgumentNullException(nameof(currency), "Currency cannot be null.");
        }

        public static void ValidateAmount(int wholePart, int cents)
        {
            if (wholePart < 0 || cents < 0)
                throw new ArgumentException("Amount cannot be negative.");
            if (cents >= MoneyConstants.CentsInOneUnit)
                throw new ArgumentException("Cents must be between 0 and 99.");
        }

        public static void ValidateMoney(Money money)
        {
            if (money == null)
            {
                throw new ArgumentNullException(nameof(money), "Money object cannot be null.");
            }
        }

        public static void ValidateSameCurrency(Money money1, Money money2)
        {
            ValidateMoney(money1);
            ValidateMoney(money2);

            if (money1.Currency.Code != money2.Currency.Code)
            {
                throw new ArgumentException("Currencies must match for the operation.");
            }
        }
    }
}
