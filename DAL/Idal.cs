using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    interface Idal
    {
        void AddGuestRequest(GuestRequest guestRequest); // הוספת דרישת לקוח
        void UpdateGuestRequest(GuestRequest guestRequest); // עדכון דרישת לקוח 

        void AddHostingUnit(HostingUnit hostingUnit); // הוספת יחידת אירוח 
        void DeleteHostingUnit(HostingUnit hostingUnit); // מחיקת יחידת אירוח 
        void UpdateHostingUnit(); // עדכון יחידת אירוח 

        void AddInvitation(Order order); // הוספת הזמנה 
        void UpdateInvitation(); // עדכון הזמנה 
        void GetListOfAllAccommodationUnits(List<HostingUnit> lhostingUnits); // קבלת רשימת כל יחידות האירוח 
        void ListAllCustomerRequirements(List<GuestRequest> lguestRequests); // קבלת רשימת כל דרישות הלקוחות 
        void GetListOfAllInvitations(List<Order> lorders); // קבלת רשימת כל ההזמנות
        void GetListOfAllExistingBankBranches(List<BankBranch> lbankBranches); // קבלת רשימת כל סניפי הבנק הקיימים בארץ 
    }
}
