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
        string PrivateName { get; set; } // שם פרטי של הלקוח 
        string FamilyName { get; set; } // שם המשפחה 
        string MailAdress { get; set; } // כתובת מייל
        string Status { get; set; } // סטטוס בקשת האירוח 
        string RegistrationDate { get; set; } // תאריך רישום למערכת 
        string EntryDate { get; set; } // תאריך רצוי לתחילת  הנופש 
        string ReleaseDate { get; set; } // תאריך רצוי לסיום הנופש 
        string Area { get; set; } // אזור הנופש הרצוי בארץ
        string SubArea { get; set; } //  תת-איזור רצוי
        string Type { get; set; } // סוג יחידת האירוח הרצוי
        int Adults { get; set; } // מספר המבוגרים
        int Children { get; set; } // מספר ילדים
        bool Pool { get; set; } // האם מעוניין בבריכה
        bool Jacuzzi { get; set; } // האם מעוניין בגקוזי 
        bool Garden { get; set; } // האם מעוניין בגינה 
        bool ChildrenAttractions { get; set; } // האם מעוניין באטרקציות לילדים 

        string ToString;



    }
}
