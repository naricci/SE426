using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : IOrderService
    {
        public string GetNumberOfOrders(int OrderID)
        {
            XPathDocument docNav;
            XPathNavigator nav;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Evaluate number of orders
            string count = docNav.CreateNavigator().Evaluate("//Order").ToString();

            // Return number of orders
            return string.Format("Number of Orders: {0}", count);
        }


        public string GetTotalCostForAnOrder(int OrderID)
        {
            XPathDocument docNav;
            XPathNavigator nav;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Evaluate total cost for an order
            string total = docNav.CreateNavigator().Evaluate("sum(//Order[@id=1]/Items/Item/TotalCost)").ToString();

            // Return total cost for an order
            return string.Format("Total cost: {0}", total);
        }

        public Item[] GetItemListForOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            string directory = System.Web.HttpContext.Current.Server.MapPath(".");
            string xmlFile = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(xmlFile);

            nav = docNav.CreateNavigator();
            NodeIter = nav.Select("//Order//Item");

            Item[] items = new Item[NodeIter.Count];

            int counter = 0;

            while (NodeIter.MoveNext())
            {
                Item nextItem = new Item();
                nextItem.PartNo = NodeIter.Current.SelectSingleNode("PartNo").Value;
                nextItem.Description = NodeIter.Current.SelectSingleNode("Description").Value;
                nextItem.UnitPrice = NodeIter.Current.SelectSingleNode("UnitPrice").Value;
                nextItem.Quantity = NodeIter.Current.SelectSingleNode("Quantity").Value;
                nextItem.TotalCost = NodeIter.Current.SelectSingleNode("TotalCost").Value;
                // Think something is wrong here...not the right syntax maybe?
                nextItem.customeroptions.Size = NodeIter.Current.SelectSingleNode("Size").Value;
                nextItem.customeroptions.Color = NodeIter.Current.SelectSingleNode("Color").Value;
                items[counter] = nextItem;
                counter++;
            }
            return items;
        }

        public string HowManyOrderedForAPartNum(String sPartsNo)
        {
            XPathNavigator nav;
            XPathDocument docNav;

            string directory = HttpContext.Current.Server.MapPath(".");
            string xmlFile = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(xmlFile);

            nav = docNav.CreateNavigator();
            string sPartNo = docNav.CreateNavigator().Evaluate("count(//Items/Item[PartNo='JETSWEATER'])").ToString();

            return string.Format("Amount of JETSWEATERS: {0}", sPartNo);
        }

        public BillingInformation[] GetBillingAddressForAnOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            string directory = HttpContext.Current.Server.MapPath(".");
            string xmlFile = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(xmlFile);

            nav = docNav.CreateNavigator();
            NodeIter = nav.Select("//BillingInformation");

            BillingInformation[] billinginfo = new BillingInformation[NodeIter.Count];

            int count = 0;

            while (NodeIter.MoveNext())
            {
                BillingInformation nextBillInfo = new BillingInformation();
                nextBillInfo.Name = NodeIter.Current.SelectSingleNode("Name").Value;
                nextBillInfo.Address = NodeIter.Current.SelectSingleNode("Address").Value;
                nextBillInfo.City = NodeIter.Current.SelectSingleNode("City").Value;
                nextBillInfo.State = NodeIter.Current.SelectSingleNode("State").Value;
                nextBillInfo.ZipCode = NodeIter.Current.SelectSingleNode("ZipCode").Value;
                billinginfo[count] = nextBillInfo;
                count++;
            }

            return billinginfo;
        }
    }
}
