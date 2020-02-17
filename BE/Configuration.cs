using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace BE
{
    public static class Configuration
    {
        private static int _code = 100000000;

        private static int _key = 100000000;

        private static int _key1 = 100000000;

        private static int _key2 = 100000000;

        public static int code
        {
            get { return _code++; }
            set { _code = value; }
        }
        public static int key 
        {
            get { return _key++; }
            set { _key = value; }
        }

        public static int key1
        {
            get { return _key1++; }
            set { _key1 = value; }
        }
        public static int key2
        {
            get { return _key2++; }
            set { _key2 = value; }
        }
    }
}
