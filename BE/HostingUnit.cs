using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        public int HostingUnitKey // מספר מזהה של יחידת האירוח
        {
            get { return HostingUnitKey; }
            set { HostingUnitKey = Configuration.key++; }
        }

        public Host Owner;
        public int nomberOfPersons;
        public int numOfRooms;
        public string type;

        public string Status { get; set; } // סטטוס בקשת האירוח 
        public DateTime RegistrationDate { get; set; } // תאריך רישום למערכת 
        public DateTime EntryDate { get; set; } // תאריך רצוי לתחילת  הנופש 
        public string ReleaseDate { get; set; } // תאריך רצוי לסיום הנופש 
        public string Area { get; set; } // אזור הנופש הרצוי בארץ
        public string SubArea { get; set; } //  תת-איזור רצוי
        public string Type { get; set; } // סוג יחידת האירוח הרצוי
        public int NumAdults { get; set; } // מספר המבוגרים
        public int NumChildren { get; set; } // מספר ילדים
        public string Pool { get; set; } // האם מעוניין בבריכה
        public string Jacuzzi { get; set; } // האם מעוניין בגקוזי 
        public string Garden { get; set; } // האם מעוניין בגינה 
        public string ChildrenAttractions { get; set; } // האם מעוניין באטרקציות לילדים 
        public string Synagogue { get; set; }
        public string FitnessRoom { get; set; }

        public string HostingUnitName { get; set; }

        // Creates an initialized boolean matrix in FALSE:
        public bool[,] Diary = new bool[12, 31];
    }
}
