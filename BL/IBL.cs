using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    interface IBL
    {

        void StatusModify(GuestRequest status);
        void AddOrder(GuestRequest requete,HostingUnit myHostingUnit);
        bool addhostingunit(HostingUnit hostingUnit);
        bool addrequest(GuestRequest getRequest);
        bool releasehostingunit(HostingUnit hostingUnit);
        bool HostingUnitModify(HostingUnit hostingUnit);
        bool CheckDate(GuestRequest start, GuestRequest end);
        string GetHostingUnit(int prenom);
        string GetGuestRequest(int id);
        string GetOrders(int id);
        string GetBankBranch(int id);
        List<HostingUnit> proposition(GuestRequest a);
        bool Banq_Ishur(GuestRequest client);
        bool sent_mail(GuestRequest a);
        void insert_date(GuestRequest b, HostingUnit c);
        void choose_of_client(int guest, int host);


    }
}
