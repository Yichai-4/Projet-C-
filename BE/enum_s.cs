using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class enum_s
    {
       

        
            public enum HostingUnit
            {
                Add,
                Update,
                Delete
            }

            public enum Pool
            {
                Necessary,
                Possible,
                Uninterested
            }

            public enum Area
            {
                All,
                North,
                South,
                Center,
                Jerusalem
            }



            public enum Type
            {
                Zimmer,
                Hotel,
                Camping,
                Villa
            }

            public enum Order
            {
                Add,
                Update
            }
            public enum Status
            {
                Not_yet_treated,
                mail_has_been_sent,
                Closes_for_customer_unresponsiveness,
                Closes_with_customer_response
            }
        

    }
}
