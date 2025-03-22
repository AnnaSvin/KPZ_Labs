using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public abstract class SubscriptionFactory
    {
        public abstract ISubscription CreateSubscription(string subscriptionType);
    }
}
