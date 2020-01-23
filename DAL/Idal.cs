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
        void AddGuestrequest(GuestRequest guestRequest); // הוספת דרישת לקוח
        void GuestrequestUpdate(GuestRequest guestRequest); // עדכון דרישת לקוח 

        void AddHostingUnit(HostingUnit hostingUnit); // הוספת יחידת אירוח 
        bool DeleteHostingUnit(int myhostingUnitKey); // מחיקת יחידת אירוח 
        void HostingUnitUpdate(HostingUnit hostingUnit); // עדכון יחידת אירוח 

        void AddInvitation(Order order); // הוספת הזמנה 
        void UpdateInvitation(Order order); // עדכון הזמנה 
        List<HostingUnit> GetListOfAllAccommodationUnits(List<HostingUnit> hostingUnits); // קבלת רשימת כל יחידות האירוח 
        List<GuestRequest> ListAllCustomerRequirements(List<GuestRequest> guestRequests); // קבלת רשימת כל דרישות הלקוחות 
        List<Order> GetListOfAllInvitations(List<Order> orders); // קבלת רשימת כל ההזמנות
        List<BankBranch> GetListOfAllExistingBankBranches(List<BankBranch> bankBranches); // קבלת רשימת כל סניפי הבנק הקיימים בארץ 
    }
}
