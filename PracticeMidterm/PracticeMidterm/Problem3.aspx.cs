using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace PracticeMidterm
{
    public partial class Problem3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplayFoodData_Click(object sender, EventArgs e)
        {
            XPathDocument docNav;
            XPathNavigator nav;
            XPathNodeIterator NodeIter;

            // Open the XML File
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\Nutrition.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath
            nav = docNav.CreateNavigator();

            // Select the node and place the results in an iterator
            NodeIter = nav.Select("//nutrition/food[fiber>2]");

            // Iterator through the results showing the element value
            while (NodeIter.MoveNext())
            {
                XPathNavigator FoodInformation = NodeIter.Current;
                String Name = FoodInformation.SelectSingleNode("name").ToString();
                XPathNavigator calories = FoodInformation.SelectSingleNode("calories");

                String total = calories.GetAttribute("total", "");
                txtPart1Output.Text = txtPart1Output.Text + Name + "-" + total + " calories";
            }

        }
    }
}