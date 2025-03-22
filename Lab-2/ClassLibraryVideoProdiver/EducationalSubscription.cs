using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public class EducationalSubscription : BaseSubscription
    {
        private decimal _studentDiscount;

        public EducationalSubscription(decimal monthlyFee, int minSubscriptionPeriod, List<string> features, decimal studentDiscount)
            : base(monthlyFee, minSubscriptionPeriod, features)
        {
            _studentDiscount = studentDiscount;
        }

        public decimal StudentDiscount => _studentDiscount;

        public override string ToString() => base.ToString() + $"\nStudent discount: {_studentDiscount}%";
    }
}
