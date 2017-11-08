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
    public partial class Problem1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetBankingData_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            //Create Request
            String bankURL = "http://34.229.220.156/BankingService/Bankservice.asmx/GetBankInformation";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(bankURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            //// Select the node and place the results in an iterator.

            NodeIter = nav.Select("//BankInformation");

            while (NodeIter.MoveNext())
            {
                txtBankingResults.Text += "Owner:  " + NodeIter.Current.SelectSingleNode("OwnerName").Value + Environment.NewLine;
                txtBankingResults.Text += "Account ID:  " + NodeIter.Current.SelectSingleNode("AccountID").Value + Environment.NewLine;
                txtBankingResults.Text += "Total Amount:  " + nav.Evaluate("sum(//Amount)").ToString() + Environment.NewLine;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtBankingResults.Text = "";
        }
    }
}