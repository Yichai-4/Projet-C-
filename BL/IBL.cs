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
        bool addhostingunit(HostingUnit hostingUnit);
        bool releasehostingunit(HostingUnit hostingUnit);
        bool HostingUnitModify(HostingUnit hostingUnit);
        void AddOrder(GuestRequest requete);
        bool CheckDate(GuestRequest start, GuestRequest end);
        bool addrequest(GuestRequest getRequest);
        string GetHostingUnit(int prenom);
        string GetGuestRequest(int id);
        string GetOrders(int id);
        string GetBankBranch(int id);
        List<HostingUnit> proposition(GuestRequest a);
        bool Banq_Ishur(GuestRequest client);
        bool sent_mail(GuestRequest a);
        void insert_date(GuestRequest b, HostingUnit c);
        void choose_of_client(int guest, int host);

        bool CheckDate(GuestRequest start, HostingUnit end);

    }
}
