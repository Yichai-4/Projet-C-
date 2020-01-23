﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class Factory
    {
        private static IBL instance = null;
        int x;
        static Factory() { }
        public static IBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BL_imp();
                }
                return instance;
            }
        }

    }
}