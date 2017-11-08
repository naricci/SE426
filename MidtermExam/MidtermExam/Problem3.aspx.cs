using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Net;

namespace MidtermExam
{
    public partial class Problem3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReadData_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\catalog-1.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            //lblVersionDate.Text = "Version Date - " + nav.SelectSingleNode("/ContactManager/VersionDate").Value;
            //lblVersionNumber.Text = "Version Number - " + nav.SelectSingleNode("/ContactManager/VersionNumber").Value;

            //// Select the node and place the results in an iterator.
            NodeIter = nav.Select("//catalog_item[price<40]");

            // Loop through catalog items and display price and gender for all items > $40
            while (NodeIter.MoveNext())
            {
                txtPriceGender.Text += NodeIter.Current.SelectSingleNode("price") + " - ";
                txtPriceGender.Text += NodeIter.Current.GetAttribute("gender", "") + Environment.NewLine;
            }

            //XPathDocument docNav2 = new XPathDocument(strFilename);
            //XPathNavigator nav2 = docNav.CreateNavigator();
            XPathNodeIterator NodeIter2 = nav.Select("//catalog_item/size[@description='Small']");

            // Loop through catalog items and display item number for all items with size description = Small
            while (NodeIter2.MoveNext())
            {
                txtItemNumber.Text += nav.SelectSingleNode("//catalog_item/item_number");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtPriceGender.Text = "";
            txtItemNumber.Text = "";
        }
    }
}