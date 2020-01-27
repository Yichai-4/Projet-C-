﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BE
{
    public class Order
    {

        public int OrderKey                    // מספר מזהה של ההזמנה
        {
            get { return OrderKey; }
            set { OrderKey = Configuration.key1++; }
        }
        public int HostingUnitKey = Configuration.key;
        public int GuestRequestKey = Configuration.code;

        public DateTime CreateDate;             // יצירת תאריך ההזמנה
        public DateTime OrderDate;              // יצירת תאריך משלוח המייל ללקוח   
    }
}
