using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal
    {
        void AddGuestRequest(GuestRequest guestRequest); // הוספת דרישת לקוח
        void GuestRequestUpdate(GuestRequest guestRequest); // עדכון דרישת לקוח 

        void AddHostingUnit(HostingUnit hostingUnit); // הוספת יחידת אירוח 
        bool DeleteHostingUnit(int myhostingUnitKey); // מחיקת יחידת אירוח 
        void UpdateHostingUnit(HostingUnit hostingUnit); // עדכון יחידת אירוח 

        void AddOrder(Order order); // הוספת הזמנה 
        void UpdateOrder(Order order); // עדכון הזמנה 
        List<HostingUnit> ListOfHostingUnits(List<HostingUnit> hostingUnits); // קבלת רשימת כל יחידות האירוח 
        List<GuestRequest> ListOfGuestRequests(List<GuestRequest> guestRequests); // קבלת רשימת כל דרישות הלקוחות 
        List<Order> ListOfOrders(List<Order> orders); // קבלת רשימת כל ההזמנות
        List<BankBranch> ListOfBankBranches(List<BankBranch> bankBranches); // קבלת רשימת כל סניפי הבנק הקיימים בארץ 
    }
}
