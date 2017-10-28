using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Lab2_XPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetBilling_Click(object sender, EventArgs e)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            doc = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = doc.CreateNavigator();

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("//Order/BillingInformation/*");

            // TODO - create loop to fill out billing info in listbox
            // lbxBillingInfo.Items.Add();

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                lbxBillingInfo.Items.Add(NodeIter.Current.Value);
                // if you use  /bookstore/book, then child
                XPathNodeIterator KidNodeIter;
                KidNodeIter = NodeIter.Current.Select("Name");
                while (KidNodeIter.MoveNext())
                { 
                    lbxBillingInfo.Items.Add(KidNodeIter.Current.Value);
                }
            };
        }

        private void btnGetShipping_Click(object sender, EventArgs e)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            doc = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = doc.CreateNavigator();

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("//Order/ShippingInformation/*");

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                lbxShippingInfo.Items.Add(NodeIter.Current.Value);
                // if you use  /bookstore/book, then child
                XPathNodeIterator KidNodeIter;
                KidNodeIter = NodeIter.Current.Select("Name");
                while (KidNodeIter.MoveNext())
                {
                    lbxShippingInfo.Items.Add(KidNodeIter.Current.Value);
                }
            };

            //while (NodeIter.MoveNext())
            //{
            //    lbxShippingInfo.Items.Add()
            //}
        }

        public void btnGetItemInfo_Click(object sender, EventArgs e)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            doc = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = doc.CreateNavigator();

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("//Order/Items/Item/*");

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                lbxItemInfo.Items.Add(NodeIter.Current.Value);
                // if you use  /bookstore/book, then child
                XPathNodeIterator KidNodeIter;
                KidNodeIter = NodeIter.Current.Select("PartNo");
                while (KidNodeIter.MoveNext())
                { 
                    lbxItemInfo.Items.Add(KidNodeIter.Current.Value);
                }
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear ALL Listboxes
            lbxBillingInfo.Items.Clear();
            lbxShippingInfo.Items.Clear();
            lbxItemInfo.Items.Clear();

            // Clear Textboxes
            txtNumOfItemsBought.Text = "";
            txtTotalCostOfOrder.Text = "";
        }

        private void btnGetItemsBought_Click(object sender, EventArgs e)
        {
            XPathDocument doc;
            XPathNavigator nav;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            doc = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = doc.CreateNavigator();

            // Use the Evaluate method to return the evaluated expression.
            txtNumOfItemsBought.Text = nav.Evaluate("sum(/Order/Items/Item/Quantity)").ToString();
        }

        private void btnGetTotalCostOfOrder_Click(object sender, EventArgs e)
        {
            XPathDocument doc;
            XPathNavigator nav;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            doc = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = doc.CreateNavigator();

            // Use the Evaluate method to return the evaluated expression.
            txtTotalCostOfOrder.Text = nav.Evaluate("sum(/Order//TotalCost)").ToString();
        }

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            // Call each function to generate full Invoice
            btnGetBilling_Click(sender, e);
            btnGetShipping_Click(sender, e);
            btnGetItemInfo_Click(sender, e);
            btnGetItemsBought_Click(sender, e);
            btnGetTotalCostOfOrder_Click(sender, e);
        }
    }
}
