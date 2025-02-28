using ClassLibraryProductWarehouse.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProductWarehouse.Monies
{
    public class Money
    {
        private int _wholePart;
        private int _cents;
        private ICurrency _currency;

        public Money(int whole, int cents, ICurrency currency)
        {
            MoneyValidator.Validate(currency, whole, cents);

            _wholePart = whole;
            _cents = cents;
            _currency = currency;
        }

        public int WholePart => _wholePart;
        public int Cents => _cents;
        public ICurrency Currency => _currency;

        public void SetAmount(int whole, int cents)
        {
            MoneyValidator.ValidateAmount(whole, cents);
            _wholePart = whole;
            _cents = cents;
        }

        public override string ToString()
        {
            return $"{_wholePart}.{_cents:D2} {_currency.Symbol} ({_currency.Code}) - {_currency.Name}";
        }
    }
}

