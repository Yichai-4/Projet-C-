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
    public class Dal_imp : IDAL
    {
        #region add
        public void AddGuestRequest(GuestRequest guestRequest)
        {
            if (DataSource.lguestRequests.Exists(x => guestRequest.GuestRequestKey == x.GuestRequestKey))
                throw new Exception("guestRequest with the same GuestRequestKey founded !!!");

            else
                DataSource.lguestRequests.Add(guestRequest);

        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {

            if (DataSource.lhostingUnits.Exists(x => hostingUnit.HostingUnitKey == x.HostingUnitKey))
                throw new Exception("HostingUnit with the same HostingUnitKey founded !!!");

            else
                DataSource.lhostingUnits.Add(hostingUnit);

        }

        public void AddOrder(Order orders)
        {
            if (DataSource.lorders.Exists(x => orders.OrderKey == x.OrderKey))
                throw new Exception("Order with the same OrderKey founded !!!");

            else
                DataSource.lorders.Add(orders);
        }
        public void AddHost(Host host)
        {
            if (DataSource.lhost.Exists(x => host.HostKey == x.HostKey))
                throw new Exception("Host with the same HostKey founded !!!");

            else
                DataSource.lhost.Add(host);
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

        public List<HostingUnit> ListOfHostingUnits(List<HostingUnit> hostingUnits)
        {
            return hostingUnits;
        }

        public List<BankBranch> ListOfBankBranches(List<BankBranch> bankBranches)
        {
            return bankBranches;
        }

        public List<Order> ListOfOrders(List<Order> orders)
        {
            return orders;
        }


        public List<GuestRequest> ListOfGuestRequests(List<GuestRequest> guestRequests)
        {
            return guestRequests;
        }


        public List<Host> ListOfHosts(List<Host> host)
        {
            return host;
        }
        #endregion


        #region udapte
        public void UpdateGuestRequest(GuestRequest myguestRequest)//linq
        {
            if (DataSource.lguestRequests.Exists(x => myguestRequest.GuestRequestKey == x.GuestRequestKey))
            {
                var myvar = DataSource.lguestRequests.Find(x => myguestRequest.GuestRequestKey == x.GuestRequestKey);
                Console.WriteLine("faite votre mise a jour pour cette requette:");
                GuestRequest tmp = new GuestRequest();
                tmp.GuestRequestKey = myguestRequest.GuestRequestKey;
                myguestRequest = tmp;
            }
            else
                throw new Exception("GuestRequest with the same GuestRequestKey not found...");

            /* var v = from item in DataSource.lguestRequests
                     where item.GuestRequestKey == myguestRequest.GuestRequestKey
                     select item;
             if (v == null) throw new Exception("GuestRequest with the same GuestRequestKey not found...");


             int index = DataSource.lguestRequests.FindIndex(g => g.GuestRequestKey == myguestRequest.GuestRequestKey);
             DataSource.lguestRequests[index] = myguestRequest;*/
        }


        public void UpdateHostingUnit(HostingUnit myhostingUnit)//linq
        {

            if (DataSource.lhostingUnits.Exists(x => myhostingUnit.HostingUnitKey == x.HostingUnitKey))
            {
                var myvar = DataSource.lhostingUnits.Find(x => myhostingUnit.HostingUnitKey == x.HostingUnitKey);
                Console.WriteLine("faite votre mise a jour pour cette requette:");
                HostingUnit tmp = new HostingUnit();
                tmp.HostingUnitKey = myhostingUnit.HostingUnitKey;
                myhostingUnit = tmp;
            }
            else
                throw new Exception("HostingUnit with the same HostingUnitKey not found...");





            /* var v = from item in DataSource.lhostingUnits
                     where item.HostingUnitKey == myhostingUnit.HostingUnitKey
                     select item;
             if (v == null) throw new Exception("HostingUnit with the same HostingUnitKey not found...");



             int index = DataSource.lhostingUnits.FindIndex(h => h.HostingUnitKey == myhostingUnit.HostingUnitKey);
             DataSource.lhostingUnits[index] = myhostingUnit;*/

        }


        public void UpdateOrder(Order myOrder)//linq
        {

            if (DataSource.lorders.Exists(x => myOrder.OrderKey == x.OrderKey))
            {
                var myvar = DataSource.lorders.Find(x => myOrder.OrderKey == x.OrderKey);
                Console.WriteLine("faite votre mise a jour pour cette order:");
                Order tmp = new Order();
                tmp.OrderKey = myOrder.OrderKey;
                myOrder = tmp;
            }
            else
                throw new Exception("Order with the same OrderKey not found...");


            /* var v = from item in DataSource.lorders
                     where item.OrderKey == myOrder.OrderKey
                     select item;
             if (v == null) throw new Exception("Order with the same OrderKey not found...");


             int index = DataSource.lorders.FindIndex(o => o.OrderKey == myOrder.OrderKey);
             DataSource.lorders[index] = myOrder;
             */
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
