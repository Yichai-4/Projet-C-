using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class FactoryDAL
    {
        private static IDAL instance = null;
        static FactoryDAL() { }

        public static IDAL Instance
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
