using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public abstract class BaseSubscription : ISubscription
    {
        private decimal _monthlyFee;
        private int _minSubscriptionPeriod;
        private List<string> _features;

        protected BaseSubscription(decimal monthlyFee, int minSubscriptionPeriod, List<string> features)
        {
            _monthlyFee = monthlyFee;
            _minSubscriptionPeriod = minSubscriptionPeriod;
            _features = features;
        }

        public decimal MonthlyFee => _monthlyFee;
        public int MinSubscriptionPeriod => _minSubscriptionPeriod;
        public List<string> Features => _features;

        public override string ToString() => $"{GetType().Name} - {_monthlyFee}$/month, Min. period: {_minSubscriptionPeriod} months.\nFeatures: {string.Join(", ", _features)}";
    }
}
