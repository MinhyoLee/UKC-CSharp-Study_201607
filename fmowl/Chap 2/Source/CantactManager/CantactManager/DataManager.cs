using System;
using System.Data;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CantactManager
{
    class DataManager
    {
        XmlDocument cantactXml;
        XmlReader xmlReader;
        public DataManager()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\Cantact.xml"))
            {
                cantactXml = new XmlDocument();
                string strXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
                                "   <Cantacts>\n" +
                                        "<Cantact name=\"None\">\n" +
                                                "<Number></Number>\n" +
                                                "<KindOfNumber></KindOfNumber>\n" +
                                        "</Cantact>\n"+
                                     "</Cantacts>\n";

                cantactXml.LoadXml(strXml);               
                cantactXml.Save(Environment.CurrentDirectory +  "\\Cantact.xml");
                xmlReader =  XmlReader.Create(Environment.CurrentDirectory + "\\Cantact.xml", new XmlReaderSettings());
            }
            else
            {
                cantactXml = new XmlDocument();
                cantactXml.Load("Cantact.xml");
                xmlReader = XmlReader.Create(Environment.CurrentDirectory + "\\Cantact.xml", new XmlReaderSettings());
            }
        }


        public List<string> LoadCantact()
        {
            int count;
            count = 0;
            List<string> list = new List<string>();
            for ( ; count < cantactXml.DocumentElement.ChildNodes.Count ; count++)
            {
                XmlNode node = cantactXml.DocumentElement.ChildNodes[count];
                list.Add(node.Attributes[0].Value.ToString());
            }
            return list;
        }

        public void searchingName(ListBox list, string name)
        {
            list.Items.Clear();
            XmlNodeList xmlnodelist = cantactXml.DocumentElement.SelectNodes(string.Format("descendant::Cantact[@name='{0}']",name));
            list.Items.Add(xmlnodelist[0].Attributes[0].Value.ToString());
        }

    }
}
