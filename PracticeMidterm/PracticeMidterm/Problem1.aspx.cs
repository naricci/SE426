using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Xml;
using System.Xml.XPath;

namespace PracticeMidterm
{
    public partial class Problem1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFindPlayers_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            //Create Request
            String footballURL = "http://34.229.220.156/FootballWebService/Footballservice.asmx/GetFootballTeam";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(footballURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath
            nav = docNav.CreateNavigator();

            // Select the node and place the results in an iterator
            NodeIter = nav.Select("//Player[weight>250]");
            txtPlayerOutput.Text = "";

            while (NodeIter.MoveNext())
            {
                txtPlayerOutput.Text += "Name:  " + NodeIter.Current.SelectSingleNode("name").Value + "  Weight:  " + NodeIter.Current.SelectSingleNode("weight").Value + Environment.NewLine;
            }
        }
    }
}