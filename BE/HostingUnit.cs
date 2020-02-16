using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        private int _HostingUnitKey;
        public int HostingUnitKey// מספר מזהה של יחידת האירוח
        {
            get { return _HostingUnitKey; }
            set { _HostingUnitKey = value; }
        }
        public Host Owner;
        public string HostingUnitName { get; set; }
        public Enums.Area Area { get; set; } // אזור הנופש הרצוי בארץ
        public Enums.SubArea SubArea { get; set; } //  תת-איזור רצוי
        public Enums.Type Type { get; set; } // סוג יחידת האירוח הרצוי
        public int NumAdults { get; set; } // מספר המבוגרים
        public int NumChildren { get; set; } // מספר ילדים
        public bool Pool { get; set; } // האם מעוניין בבריכה
        public bool Jacuzzi { get; set; } // האם מעוניין בגקוזי 
        public bool Garden { get; set; } // האם מעוניין בגינה 
        public bool ChildrenAttractions { get; set; } // האם מעוניין באטרקציות לילדים 
        public bool Synagogue { get; set; }
        public bool FitnessRoom { get; set; }
        public bool[,] Diary = new bool[12, 31]; // Creates an initialized boolean matrix in FALSE:

        public int nomberOfPersons;
        public int numOfRooms;
        public string type;
        public Enums.Status Status { get; set; } // סטטוס בקשת האירוח 
        public string RegistrationDate { get; set; } // תאריך רישום למערכת 
        public DateTime EntryDate { get; set; } // תאריך רצוי לתחילת  הנופש 
        public DateTime ReleaseDate { get; set; } // תאריך רצוי לסיום הנופש 

        HostingUnit()
        {
            this._HostingUnitKey=Configuration.key
        }
        public void ToString()
        {
            Console.WriteLine("Hosting unit key: " + HostingUnitKey);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Entry date: " + EntryDate);
            Console.WriteLine("Release date: " + ReleaseDate);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("SubArea: " + SubArea);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Adults: " + NumAdults);
            Console.WriteLine("Children: " + NumChildren);
            Console.WriteLine("Pool: " + Pool);
            Console.WriteLine("Jacuzzi: " + Jacuzzi);
            Console.WriteLine("Garden: " + Garden);
            Console.WriteLine("Children attractions: " + ChildrenAttractions);
            Console.WriteLine("Synagogue: " + Synagogue);
            Console.WriteLine("Fitness room: " + FitnessRoom);
        }
    }
}
