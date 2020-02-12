using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS;
using DAL;

//comment passer du guestrequest au bankbranch
namespace BL
{
    class BL_imp : IBL
    {
        IDAL instance = FactoryDAL.Instance;

        public bool AddHostingUnit(HostingUnit hostingUnit)
        {
            instance.AddHostingUnit(hostingUnit);
            return true;

        }

        public void AddOrder(GuestRequest request,HostingUnit myHostingUnit )
        {
            List<Order> best = new List<Order>();
            var compatible2 = from g in DataSource.lorders
                              where g.GuestRequestKey == request.GuestRequestKey
                              select g;
            //instance.AddOrder();
        }

        public bool AddRequest(GuestRequest guestRequest)
        {
            instance.AddGuestRequest(guestRequest);
            return true;
        }

        public bool Banq_Ishur(GuestRequest )
        {
           

            return false;
        }
        #region date
        public bool CheckDate(GuestRequest start, GuestRequest end)
        {

            if (Equals(start.EntryDate, end.RegistrationDate))
                return false;
            else
                return true;
        }

        public bool CheckDate(GuestRequest start, HostingUnit end)
        {

            if (Equals(start.EntryDate, end.RegistrationDate))
                return false;
            else
                return true;
        }
        #endregion

        public void choose_of_client(int guest, int host)
        {
            throw new NotImplementedException();
        }
        #region get
        public string GetBankBranch(int id)
        {
            throw new NotImplementedException();
        }

        public string GetGuestRequest(int id)
        {
            throw new NotImplementedException();
        }

        public string GetHostingUnit(int prenom)
        {
            throw new NotImplementedException();
        }

        //public Order GetOrder(int myOrder)
        //{
        //    return DataSource.lorders.FirstOrDefault(o => o.OrderKey == myOrder);
        //}

        public string GetOrder(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        public bool UpdateHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public void insert_date(GuestRequest b, HostingUnit c)
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> proposition(GuestRequest request)//verifi si ce qui est demande exist et le selectionne
        {

            List<HostingUnit> best = new List<HostingUnit>();
            var compatible2 = from g in DataSource.lhostingUnits
                              where g.Area == request.Area && g.NumChildren <= request.Children && g.NumAdults <= request.Adults && g.Pool == request.Pool && g.Jacuzzi == request.Jacuzzi &&
                              g.ChildrenAttractions == request.ChildrenAttractions && g.Garden == request.Garden
                              select g;

            foreach (HostingUnit item in compatible2)
            {
                if (CheckDate(request, item) == true)//verifie les possibilite en fonction de la demande 
                {
                    best.Add(item);
                    AddOrder(request, item);
                }
            }
            return best;
        }

        public bool DeleteHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public bool sent_mail(GuestRequest a)
        {
            //if (a.permission == true)
            //    return true;
            //else
                return false;

        }

        public void UpdateStatus(GuestRequest status)
        {
            throw new NotImplementedException();
        }

    }
}
