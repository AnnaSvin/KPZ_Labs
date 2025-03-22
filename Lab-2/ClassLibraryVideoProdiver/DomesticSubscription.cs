using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public class DomesticSubscription : BaseSubscription
    {
        public DomesticSubscription(decimal monthlyFee, int minSubscriptionPeriod, List<string> features)
            : base(monthlyFee, minSubscriptionPeriod, features) { }
    }
}
