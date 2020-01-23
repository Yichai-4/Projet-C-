using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLWPF
{
    class Enums
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

        public enum Status
        {
            Active,
            Unactive
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
    }
}
