using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        int HostingUnitKey { get; set; }
        int GuestRequestKey { get; set; }
        int OrderKey;
        DateTime CreateDate;
        DateTime OrderDate;
    }
}
