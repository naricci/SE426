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
using System.IO;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\contacts.xml";
            XmlTextReader objXMLTextReader = new XmlTextReader(strFilename);
            string sName = "";
            StringBuilder results = new StringBuilder();
            StringBuilder vresults = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(strFilename))
            {
                xmlDoc.Load(strFilename);
                XmlElement elm = xmlDoc.DocumentElement;
                XmlNodeList currentVersion = xmlDoc.GetElementsByTagName("CurrentVersion");
                XmlNodeList contactInfo = elm.ChildNodes;

                for (int iCount = 0; iCount < contactInfo.Count; iCount++)
                {
                    Console.WriteLine(contactInfo[0].Name);
                    Console.WriteLine(contactInfo[0].FirstChild.Name + " - " + contactInfo[0].FirstChild.InnerText);

                    XmlNodeList contactProperties = contactInfo[0].ChildNodes;
                    for (int jCount = 0; jCount < contactProperties.Count; jCount++)
                    {
                        //todo FIX THIS PART!!!
                        txtContacts.Text = contactProperties.ToString();
                    }
                }

                // Check for each node of the list
                foreach (XmlNode node in currentVersion)
                {
                    Console.WriteLine(node.InnerText);
                    vresults.AppendLine(node.InnerText);
                }

                txtVersionNumber.Text = vresults.ToString();
            }

            while (objXMLTextReader.Read())
            {
                switch (objXMLTextReader.NodeType)
                {
                    case XmlNodeType.Element:
                        sName = objXMLTextReader.Name;
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(sName + "-" + objXMLTextReader.Value);
                        results.AppendLine(sName + "-" + objXMLTextReader.Value);
                        break;

                }
            }

            txtFile.Text = results.ToString();


        }
    }
}
