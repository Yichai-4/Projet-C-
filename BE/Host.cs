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
        int HostKey { get; set; }

        string PrivateName { get; set; }

        string FamilyName { get; set; }

        int PhoneNumber { get; set; }

        string MailAddress { get; set; }

        int BankAccountNumber { get; set; }

        bool CollectionClearance { get; set; }
    }
}
