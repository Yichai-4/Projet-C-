using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    // שמייצגת מארח ותכלול Host מחלקה בשם
    public class Host
    {
        public int HostKey { get; set; }

        public string PrivateName { get; set; }

        public string FamilyName { get; set; }

        public int PhoneNumber { get; set; }

        public string MailAddress { get; set; }

        public int BankAccountNumber { get; set; }

        public bool CollectionClearance { get; set; }
    }
}
