using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Xml;
using System.Xml.XPath;


namespace Lab3_AccessingWebServices
{
    public partial class Forecast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            //Create Request
            String weatherURL = "http://api.wunderground.com/api/6e0e2318906be500/forecast/q/MA/Boston.xml";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(weatherURL);
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

            NodeIter = nav.Select("//response//forecastday");
            
            while (NodeIter.MoveNext())
            {
                txtOutput.Text += NodeIter.Current.SelectSingleNode("title").Value + Environment.NewLine;
                txtOutput.Text += NodeIter.Current.SelectSingleNode("fcttext").Value + Environment.NewLine;
            }
        }
    }
}