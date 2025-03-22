using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public class MobileApp : SubscriptionFactory
    {
        public override ISubscription CreateSubscription(string subscriptionType)
        {
            if (subscriptionType == "Domestic")
                return new DomesticSubscription(14.99m, 1, new List<string> { "Basic Quality", "1 Device", "Mobile Access Only" });
            else if (subscriptionType == "Educational")
                return new EducationalSubscription(7.99m, 6, new List<string> { "Offline Mode", "Mobile Learning", "Access to Educational Content" }, 25m);
            else if (subscriptionType == "Premium")
                return new PremiumSubscription(24.99m, 6, new List<string> { "HD Quality", "Unlimited Devices", "Exclusive Mobile Content" }, false);
            else
                throw new ArgumentException("Subscription type not found.");
        }
    }
}
