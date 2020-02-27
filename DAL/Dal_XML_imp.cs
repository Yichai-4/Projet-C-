using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;

namespace DAL
{
    class Dal_XML_imp
    {
        XElement guestRequestRoot;
        string guestRequestPath = @"GuestRequestXml.xml";
    }

    //public void SaveGuestRequestList(List<GuestRequest> guestRequestList)
    //{
        //guestRequestRoot = new XElement("guest requests");

        //foreach (GuestRequest item in guestRequestList)
        //{
        //    XElement PrivateName = new XElement("PrivateName", item.PrivateName);
        //    XElement FamilyName = new XElement("FamilyName", item.FamilyName);
        //    XElement MailAddress = new XElement("MailAddress", item.MailAddress);
        //     guestRequestRoot.Addd
        //}

        //guestRequestRoot.Save(guestRequestPath);
    //}
}
