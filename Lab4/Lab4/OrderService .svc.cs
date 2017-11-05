using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Lab4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IOrderService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int GetNumberOfOrders()
        {
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            int num = 0;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("/OrderFeed/Order@id");

            while (NodeIter.MoveNext())
            {
                num++;
            }

            return num;
        }


        double GetTotalCostForAnOrder(double OrderID)
        {
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;
            //int num = 0;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("");

            while (NodeIter.MoveNext())
            {

            }
        }

        public ItemList GetItemListForOrder(ItemList items)
        {

        }

        public string HowManyOrderedForAPartNo(String sPartNo)
        {

        }

        public BillingAddress GetBillingAddressForAnOrder(BillingAddress address)
        {

        }
    }
}
