using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {

        public GuestRequest()
        {
            this._GuestRequestKey = Configuration.code;
        }

        // מספר הבקשה לאירוח
        private int _GuestRequestKey;
        public int GuestRequestKey
        {
            get { return _GuestRequestKey; }
            set { _GuestRequestKey =value;  }
        }
        public string PrivateName { get; set; } // שם פרטי של הלקוח 
        public string FamilyName { get; set; } // שם המשפחה 
        public string MailAddress { get; set; } // כתובת מייל
        public Enums.Status Status { get; set; } // סטטוס בקשת האירוח 
        public string RegistrationDate { get; set; } // תאריך רישום למערכת 
        public string EntryDate { get; set; } // תאריך רצוי לתחילת  הנופש 
        public string ReleaseDate { get; set; } // תאריך רצוי לסיום הנופש 
        public Enums.Area Area { get; set; } // אזור הנופש הרצוי בארץ
        public Enums.SubArea SubArea { get; set; } //  תת-איזור רצוי
        public Enums.Type Type { get; set; } // סוג יחידת האירוח הרצוי
        public int Adults { get; set; } // מספר המבוגרים
        public int Children { get; set; } // מספר ילדים
        public Enums.Pool Pool { get; set; } // האם מעוניין בבריכה
        public Enums.Pool Jacuzzi { get; set; } // האם מעוניין בגקוזי 
        public Enums.Pool Garden { get; set; } // האם מעוניין בגינה 
        public Enums.Pool ChildrenAttractions { get; set; } // האם מעוניין באטרקציות לילדים 
        public Enums.Pool Synagogue { get; set; }
        public Enums.Pool FitnessRoom { get; set; }
        public string PhoneNumber { get; set; }

        public string MsgBoxGR
        {
            get
            {
                return @"Your request has been successfully registered !
                         Guest request key: " + GuestRequestKey +
                       @"Your registration date: " + RegistrationDate;
            }
            set { }
        }

        public void ToString()
        {
            Console.WriteLine("Guest request key: " + GuestRequestKey);
            Console.WriteLine("Private name: " + PrivateName);
            Console.WriteLine("Family name: " + FamilyName);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Mail address: " + MailAddress);
            Console.WriteLine("Registration date: " + RegistrationDate);
            Console.WriteLine("Entry date: " + EntryDate);
            Console.WriteLine("Release date: " + ReleaseDate);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("SubArea: " + SubArea);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Adults: " + Adults);
            Console.WriteLine("Children: " + Children);
            Console.WriteLine("Pool: " + Pool);
            Console.WriteLine("Jacuzzi: " + Jacuzzi);
            Console.WriteLine("Garden: " + Garden);
            Console.WriteLine("Children attractions: " + ChildrenAttractions);
            Console.WriteLine("Synagogue: " + Synagogue);
            Console.WriteLine("Fitness room: " + FitnessRoom);
            Console.WriteLine("Phone number: " + PhoneNumber);
        }
    }
}
