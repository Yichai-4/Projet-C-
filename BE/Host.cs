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
        public Host()
        {
            this._HostKey = Configuration.key2;
        }
        private int _HostKey { get; set; }
        public int HostKey// מספר מזהה של יחידת האירוח
        {
            get { return _HostKey; }
            set { _HostKey = value; }
        }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        BankBranch BankBranchDetails;
        public int BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }

        public string MsgBoxHost
        {
            get
            {
                return "Your inscription has been successfully registered !" +
                       "\nYour Host key: " + HostKey;
            }
            set { }
        }

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
