using DAl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalfactory
    {

        private static Idal instance = null;
        static dalfactory() { }
        public static Idal Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dal_imp();

                return instance;
            }
        }
    }
}
