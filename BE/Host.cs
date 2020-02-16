using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    // שמייצגת מארח  Host מחלקה בשם
    public class Host
    {
        public int HostKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public int PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public int BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }

        public void ToString()
        {
            Console.WriteLine("Host key: " + HostKey);
            Console.WriteLine("Private name: " + PrivateName);
            Console.WriteLine("Family name: " + FamilyName);
            Console.WriteLine("Phone number: " + PhoneNumber);
            Console.WriteLine("Mail address: " + MailAddress);
            Console.WriteLine("Bank account number: " + BankAccountNumber);
            Console.WriteLine("Collection clearance: " + CollectionClearance);
        }
    }
}
