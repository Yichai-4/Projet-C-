using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Enums
    {
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

        public enum SubArea
        {
            TelAviv,
            Jerusalem,
            Tsfat,
            Tiberiad
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

        public enum Location
        {
            North,
            South,
            Center,
            Jerusalem
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

