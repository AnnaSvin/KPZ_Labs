using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public class PremiumSubscription : BaseSubscription
    {
        private bool _vipSupport;

        public PremiumSubscription(decimal monthlyFee, int minSubscriptionPeriod, List<string> features, bool vipSupport)
            : base(monthlyFee, minSubscriptionPeriod, features)
        {
            _vipSupport = vipSupport;
        }

        public bool VIPSupport => _vipSupport;

        public override string ToString() => base.ToString() + $"\nPremium support: {(_vipSupport ? "Yes" : "No")}";
    }
}
