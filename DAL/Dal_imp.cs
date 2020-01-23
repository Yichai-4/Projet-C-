using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DS;

namespace DAL
{
    //refair les list: il faut qu'il  return et pas autre 
    public class Dal_imp : Idal
    {
        #region add
        public void AddGuestrequest(GuestRequest guestRequest)
        {
            if (DataSource.lguestRequests == null)
                DataSource.lguestRequests.Add(guestRequest);
            for (int i = 0; i < DataSource.lguestRequests.Count; i++)
                if (DataSource.lguestRequests[i].GuestRequestKey == guestRequest.GuestRequestKey)
                    throw new Exception("guestRequest with the same GuestRequestKey  founded !!!");
                else
                    DataSource.lguestRequests.Add(guestRequest);
        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {

            if (DataSource.lhostingUnits == null)
                DataSource.lhostingUnits.Add(hostingUnit);
            for (int i = 0; i < DataSource.lhostingUnits.Count; i++)
                if (DataSource.lhostingUnits[i].HostingUnitKey == hostingUnit.HostingUnitKey)
                    throw new Exception("hostingUnit with the same hostingUnitKey  founded !!!");
                else
                    DataSource.lhostingUnits.Add(hostingUnit);
        }

        public void AddInvitation(Order orders)
        {
            if (DataSource.lorders == null)
                DataSource.lorders.Add(orders);
            for (int i = 0; i < DataSource.lorders.Count; i++)
                if (DataSource.lorders[i].OrderKey == orders.OrderKey)
                    throw new Exception("Order with the same o" +
                        "rderKey  founded !!!");
                else
                    DataSource.lorders.Add(orders);

        }

        #endregion


        public bool DeleteHostingUnit(int myhostingUnitKey)//linq
        {
            var v = from item in DataSource.lhostingUnits
                    where item.HostingUnitKey == myhostingUnitKey
                    select item;

            HostingUnit myhostingUnit = GetHostingUnit(myhostingUnitKey);
            if (v == null) throw new Exception("HostingUnit with the same HostingUnitKey not found...");
            DataSource.lguestRequests.RemoveAll(sc => sc.GuestRequestKey == myhostingUnitKey);
            return DataSource.lhostingUnits.Remove(myhostingUnit);
        }




        #region GetList

        public List<HostingUnit> GetListOfAllAccommodationUnits(List<HostingUnit> hostingUnits)
        {

            return hostingUnits;

        }





        public List<BankBranch> GetListOfAllExistingBankBranches(List<BankBranch> bankBranches)
        {
            return bankBranches;

        }




        public List<Order> GetListOfAllInvitations(List<Order> orders)
        {
            return orders;


        }


        public List<GuestRequest> ListAllCustomerRequirements(List<GuestRequest> guestRequests)
        {
            return guestRequests;
        }

        #endregion


        #region udapte
        public void GuestrequestUpdate(GuestRequest myguestRequest)//linq
        {

            var v = from item in DataSource.lguestRequests
                    where item.GuestRequestKey == myguestRequest.GuestRequestKey
                    select item;
            if (v == null) throw new Exception("GuestRequest with the same GuestRequestKey not found...");


            int index = DataSource.lguestRequests.FindIndex(g => g.GuestRequestKey == myguestRequest.GuestRequestKey);
            DataSource.lguestRequests[index] = myguestRequest;
        }


        public void HostingUnitUpdate(HostingUnit myhostingUnit)//linq
        {

            var v = from item in DataSource.lhostingUnits
                    where item.HostingUnitKey == myhostingUnit.HostingUnitKey
                    select item;
            if (v == null) throw new Exception("HostingUnit with the same HostingUnitKey not found...");



            int index = DataSource.lhostingUnits.FindIndex(h => h.HostingUnitKey == myhostingUnit.HostingUnitKey);
            DataSource.lhostingUnits[index] = myhostingUnit;

        }


        public void UpdateInvitation(Order myOrder)//linq
        {
            var v = from item in DataSource.lorders
                    where item.OrderKey == myOrder.OrderKey
                    select item;
            if (v == null) throw new Exception("Order with the same OrderKey not found...");


            int index = DataSource.lorders.FindIndex(o => o.OrderKey == myOrder.OrderKey);
            DataSource.lorders[index] = myOrder;

        }
        #endregion


        #region get
        public GuestRequest GetGuestRequest(int myguestrequest)
        {
            return DataSource.lguestRequests.FirstOrDefault(g => g.GuestRequestKey == myguestrequest);
        }

        public HostingUnit GetHostingUnit(int myhostingUnit)
        {
            return DataSource.lhostingUnits.FirstOrDefault(h => h.HostingUnitKey == myhostingUnit);
        }


        #endregion
    }
}
