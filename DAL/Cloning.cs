using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public static class Cloning
    {

        public static BankBranch Clone(this BankBranch original)
        {
            BankBranch target = new BankBranch
            {
                BankNumber = original.BankNumber,

                BankName = original.BankName,

                BranchNumber = original.BranchNumber,

                BranchAddress = original.BranchAddress,

                BranchCity = original.BranchCity

            };
            return target;
        }
        public static GuestRequest Clone(this GuestRequest original)
        {
            GuestRequest target = new GuestRequest
            {
                PrivateName = original.PrivateName,

                FamilyName = original.FamilyName,

                MailAddress = original.MailAddress,

                Status = original.Status,

                RegistrationDate = original.RegistrationDate,

                EntryDate = original.EntryDate,

                ReleaseDate = original.ReleaseDate,

                Area = original.Area,

                SubArea = original.SubArea,

                Type = original.Type,

                Adults = original.Adults,

                Children = original.Children,

                Pool = original.Pool,

                Jacuzzi = original.Jacuzzi,

                Garden = original.Garden,

                ChildrenAttractions = original.ChildrenAttractions

            };
            return target;
        }
        public static Host Clone(this Host original)
        {
            Host target = new Host
            {
                HostKey = original.HostKey,

                PrivateName = original.PrivateName,

                FamilyName = original.FamilyName,

                PhoneNumber = original.PhoneNumber,

                MailAddress = original.MailAddress,

                BankAccountNumber = original.BankAccountNumber,

                CollectionClearance = original.CollectionClearance

            };
            return target;
        }

        public static HostingUnit Clone(this HostingUnit original)
        {
            HostingUnit target = new HostingUnit
            {
                HostingUnitKey = original.HostingUnitKey,

                Owner = original.Owner,

                nomberOfPersons = original.nomberOfPersons,

                Area = original.Area,

                numOfRooms = original.numOfRooms,

                Pool = original.Pool,

                type = original.type,

                HostingUnitName = original.HostingUnitName,

                Diary = original.Diary

            };
            return target;
        }

        public static Order Clone(this Order original)
        {
            Order target = new Order
            {
                HostingUnitKey = original.HostingUnitKey,

                GuestRequestKey = original.GuestRequestKey,

                OrderKey = original.OrderKey,

                CreateDate = original.CreateDate,

                OrderDate = original.OrderDate


            };
            return target;
        }


    }
}