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
        #region Add
        public void AddGuestRequest(GuestRequest guestRequest)
        {
            if (DataSource.lguestRequests == null)
                DataSource.lguestRequests.Add(guestRequest);
            for (int i = 0; i < DataSource.lguestRequests.Count; i++)
                if (DataSource.lguestRequests[i].GuestRequestKey == guestRequest.GuestRequestKey)
                    throw new Exception("guest request with the same guest request key founded !!");
                else
                    DataSource.lguestRequests.Add(guestRequest);
        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {

            if (DataSource.lhostingUnits == null)
                DataSource.lhostingUnits.Add(hostingUnit);
            for (int i = 0; i < DataSource.lhostingUnits.Count; i++)
                if (DataSource.lhostingUnits[i].HostingUnitKey == hostingUnit.HostingUnitKey)
                    throw new Exception("hosting unit with the same hosting unit key founded !!");
                else
                    DataSource.lhostingUnits.Add(hostingUnit);
        }

        public void AddOrder(Order orders)
        {
            if (DataSource.lorders == null)
                DataSource.lorders.Add(orders);
            for (int i = 0; i < DataSource.lorders.Count; i++)
                if (DataSource.lorders[i].OrderKey == orders.OrderKey)
                    throw new Exception("Order with the same order key founded !!");
                else
                    DataSource.lorders.Add(orders);

        }

        #endregion

        #region Delete
        public bool DeleteHostingUnit(int myhostingUnitKey)
        {
            // Link
            var v = from item in DataSource.lhostingUnits
                    where item.HostingUnitKey == myhostingUnitKey
                    select item;

            HostingUnit myhostingUnit = GetHostingUnit(myhostingUnitKey);
            if (v == null)
                throw new Exception("Hosting unit with the same hosting unit key not found...");
            DataSource.lguestRequests.RemoveAll(sc => sc.GuestRequestKey == myhostingUnitKey);
            return DataSource.lhostingUnits.Remove(myhostingUnit);
        }
        #endregion

        #region GetList

        public List<HostingUnit> GetListAllHostingUnits(List<HostingUnit> hostingUnits)
        {
            return hostingUnits;
        }

        public List<BankBranch> GetListAllBankBranches(List<BankBranch> bankBranches)
        {
            return bankBranches;
        }

        public List<Order> GetListAllOrders(List<Order> orders)
        {
            return orders;
        }

        public List<GuestRequest> GetListAllGuestRequests(List<GuestRequest> guestRequests)
        {
            return guestRequests;
        }

        #endregion

        #region Update
        public void UpdateGuestRequest(GuestRequest myguestRequest)//linq
        {

            var v = from item in DataSource.lguestRequests
                    where item.GuestRequestKey == myguestRequest.GuestRequestKey
                    select item;
            if (v == null) throw new Exception("GuestRequest with the same GuestRequestKey not found...");


            int index = DataSource.lguestRequests.FindIndex(g => g.GuestRequestKey == myguestRequest.GuestRequestKey);
            DataSource.lguestRequests[index] = myguestRequest;
        }


        public void UpdateHostingUnit(HostingUnit myhostingUnit)//linq
        {

            var v = from item in DataSource.lhostingUnits
                    where item.HostingUnitKey == myhostingUnit.HostingUnitKey
                    select item;
            if (v == null) throw new Exception("HostingUnit with the same HostingUnitKey not found...");



            int index = DataSource.lhostingUnits.FindIndex(h => h.HostingUnitKey == myhostingUnit.HostingUnitKey);
            DataSource.lhostingUnits[index] = myhostingUnit;

        }


        public void UpdateOrder(Order myOrder)//linq
        {
            var v = from item in DataSource.lorders
                    where item.OrderKey == myOrder.OrderKey
                    select item;
            if (v == null) throw new Exception("Order with the same OrderKey not found...");


            int index = DataSource.lorders.FindIndex(o => o.OrderKey == myOrder.OrderKey);
            DataSource.lorders[index] = myOrder;

        }
        #endregion

        #region Get
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
