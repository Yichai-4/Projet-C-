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
        Idal instance = dalfactory.Instance;

        public bool addhostingunit(HostingUnit hostingUnit)
        {
            instance.AddHostingUnit(hostingUnit);
            return true;

        }

        public void AddOrder(GuestRequest requete,HostingUnit myHostingUnit )
        {
            List<Order> best = new List<Order>();
            var compatible2 = from g in DataSource.lorders
                              where g.GuestRequestKey == requete.GuestRequestKey
                              select g;
                        //  instance.AddOrder();
        }
        public void AddOrder( )
        {
          //  instance.AddOrder();
        }

        public bool addrequest(GuestRequest getRequest)
        {
            instance.AddGuestRequest(getRequest);
            return true;
        }

        public bool Banq_Ishur(GuestRequest client)
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

        public Order GetOrder(int myOrder)
        {
            return DataSource.lorders.FirstOrDefault(o => o.OrderKey == myOrder);
        }

        public string GetOrders(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        public bool HostingUnitModify(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public void insert_date(GuestRequest b, HostingUnit c)
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> proposition(GuestRequest requete)//verifi si ce qui est demande exist et le selectionne
        {

            List<HostingUnit> best = new List<HostingUnit>();
            var compatible2 = from g in DataSource.lhostingUnits
                              where g.Area == requete.Area && g.NumChildren <= requete.Children && g.NumAdults <= requete.Adults && g.Pool == requete.Pool && g.Jacuzzi == requete.Jacuzzi &&
                              g.ChildrenAttractions == requete.ChildrenAttractions && g.Garden == requete.Garden
                              select g;

            foreach (HostingUnit item in compatible2)
            {
                if (CheckDate(requete, item) == true)//verifie les possibilite en fonction de la demande 
                {
                    best.Add(item);
                    AddOrder(requete, item);
                }
            }
            return best;
        }

        public bool releasehostingunit(HostingUnit hostingUnit)
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

        public void StatusModify(GuestRequest status)
        {
            throw new NotImplementedException();
        }

    }
}
