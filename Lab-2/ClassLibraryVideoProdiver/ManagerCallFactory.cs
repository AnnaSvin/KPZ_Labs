using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public class ManagerCall : SubscriptionFactory
    {
        public override ISubscription CreateSubscription(string subscriptionType)
        {
            if (subscriptionType == "Domestic")
                return new DomesticSubscription(15.99m, 3, new List<string> { "HD Quality", "5 Devices" });
            else if (subscriptionType == "Educational")
                return new EducationalSubscription(11.99m, 6, new List<string> { "Offline Mode", "Quiz Support" }, 15m);
            else if (subscriptionType == "Premium")
                return new PremiumSubscription(29.99m, 12, new List<string> { "4K Quality", "Unlimited Devices", "Exclusive Content" }, true);
            else
                throw new ArgumentException("Subscription type not found.");
        }
    }

}
