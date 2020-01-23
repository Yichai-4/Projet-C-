using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        static int HostingUnitKey = 10000000; // מספר מזהה ייחודי –יחידת אירוח 
        Host Owner;                           // בעל היחידה מסוג מארח 
        string HostingUnitName { get; set; }  // שם יחידת האירוח 
        // Creates an initialized boolean matrix in FALSE:
        bool[,] Diary = new bool[12, 31];     // מצב יחידת האירוח לטווח של שנה

        string ToString;
    }
}
