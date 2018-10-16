using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Domain;

namespace DAL
{
    public class XML_Reader
    {
        public XmlDocument XmlFile { get; set; }
        
        public XML_Reader()
        {
            XmlFile = new XmlDocument();
            XmlFile.Load("./questions.xml");
        }

        public Question GetQuestion(int index)
        {
            Question q;
            foreach (XmlNode node in XmlFile.DocumentElement.ChildNodes)
            {
                string text = node.InnerText; //or loop through its children as well
                Console.WriteLine(text);
            }
            return null;
        }
    }
}
