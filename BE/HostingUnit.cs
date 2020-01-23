using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        public int HostingUnitKey// מספר מזהה של יחידת האירוח
        {
            get { return HostingUnitKey; }
            set { HostingUnitKey = Configuration.key++; }
        }

        public Host Owner;

        public int nomberOfPersons;

        public int numOfRooms;

        public string type;

       // public enum_s.status Status { get; set; } // סטטוס בקשת האירוח 
        public DateTime RegistrationDate { get; set; } // תאריך רישום למערכת 
        public DateTime EntryDate { get; set; } // תאריך רצוי לתחילת  הנופש 
        public string ReleaseDate { get; set; } // תאריך רצוי לסיום הנופש 
       // public enum_s.Areas Area { get; set; } // אזור הנופש הרצוי בארץ
        public string SubArea { get; set; } //  תת-איזור רצוי
       // public enum_s.HostUnitType Type { get; set; } // סוג יחידת האירוח הרצוי
        public int NumAdults { get; set; } // מספר המבוגרים
        public int NumChildren { get; set; } // מספר ילדים
        // public enum_s.choice Jacuzzi { get; set; } // האם מעוניין בגקוזי 
       // public enum_s.choice Garden { get; set; } // האם מעוניין בגינה 
        //public enum_s.choice ChildrenAttractions { get; set; } // האם מעוניין באטרקציות לילדים */

        public string HostingUnitName { get; set; }
        // Creates an initialized boolean matrix in FALSE:
        public bool[,] Diary = new bool[12, 31];
    }
}
