using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVideoProdiver
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinSubscriptionPeriod { get; }
        List<string> Features { get; }
        string ToString();
    }
}
