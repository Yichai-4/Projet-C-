using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        void UpdateStatus(GuestRequest status);
        void AddOrder(GuestRequest request,HostingUnit myHostingUnit);
        bool AddHostingUnit(HostingUnit hostingUnit);
        bool AddRequest(GuestRequest getRequest);
        bool AddHost(Host host);

        bool DeleteHostingUnit(HostingUnit hostingUnit);
        bool UpdateHostingUnit(HostingUnit hostingUnit);
        bool CheckDate(GuestRequest start, GuestRequest end);
        string GetHostingUnit(int prenom);
        string GetGuestRequest(int id);
        string GetOrder(int id);
        string GetBankBranch(int id);
        List<HostingUnit> proposition(GuestRequest a);
        bool Banq_Ishur(GuestRequest client);
        bool sent_mail(GuestRequest a);
        void insert_date(GuestRequest b, HostingUnit c);
        void choose_of_client(int guest, int host);
    }
}
