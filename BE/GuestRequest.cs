using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        public int GuestRequestKey { get; set; } // מספר הבקשה לאירוח
        public string PrivateName { get; set; } // שם פרטי של הלקוח 
        public string FamilyName { get; set; } // שם המשפחה 
        public string MailAdress { get; set; } // כתובת מייל
        public string Status { get; set; } // סטטוס בקשת האירוח 
        public string RegistrationDate { get; set; } // תאריך רישום למערכת 
        public string EntryDate { get; set; } // תאריך רצוי לתחילת  הנופש 
        public string ReleaseDate { get; set; } // תאריך רצוי לסיום הנופש 
        public string Area { get; set; } // אזור הנופש הרצוי בארץ
        public string SubArea { get; set; } //  תת-איזור רצוי
        public string Type { get; set; } // סוג יחידת האירוח הרצוי
        public int Adults { get; set; } // מספר המבוגרים
        public int Children { get; set; } // מספר ילדים
        public bool Pool { get; set; } // האם מעוניין בבריכה
        public bool Jacuzzi { get; set; } // האם מעוניין בגקוזי 
        public bool Garden { get; set; } // האם מעוניין בגינה 
        public bool ChildrenAttractions { get; set; } // האם מעוניין באטרקציות לילדים 
         
       // public string Object.ToString;



    }
}
