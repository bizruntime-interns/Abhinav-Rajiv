using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;

namespace xmlmanu
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("books.xml");
            FirstNode(doc);
            LastNode(doc);
            show(doc);
            UpdateRs(doc);
            Search(doc);
            create();
            Console.ReadKey();

        }
        protected static void LastNode(XmlDocument doc)
        {
            XmlNode last = doc.DocumentElement.LastChild;
            Console.WriteLine("Last Node\n "+last.OuterXml);
        }
        protected static void FirstNode(XmlDocument doc)
        {
            XmlNode first = doc.DocumentElement.FirstChild;
            Console.WriteLine("First Node"+first.OuterXml+"\n\n");
        }
        protected static void show(XmlDocument doc)
        {
            XmlNodeList list = doc.GetElementsByTagName("book");
            Console.WriteLine("THe values in xml");
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i].InnerText);
            }
            Console.WriteLine("The data in first book");
            foreach(XmlNode xmlnode in doc.DocumentElement)
            {
               
                Console.WriteLine(" Category:" + xmlnode.Attributes["category"].Value+"\n");
                foreach(XmlNode xmlnodd in xmlnode)
                {
                     Console.WriteLine(xmlnodd.Name + ":" + xmlnodd.ChildNodes[0].Value);
                }
               
            }
        }
        protected static void UpdateRs(XmlDocument doc)
        {
            XmlNodeList ndlist;
            XmlNode node = doc.DocumentElement;
            ndlist = node.SelectNodes("/bookstore/book[@ category='book']");
            foreach(XmlNode no in ndlist)
            {
                Console.WriteLine(no.SelectSingleNode("author").InnerText);
            }
            Console.WriteLine("Display the modified XML document....");
            doc.Save(Console.Out);
        }
        protected static void Search(XmlDocument doc)
        {
            Console.WriteLine("search");
            XmlNodeList nodelist;
            XmlNode node = doc.DocumentElement;
            nodelist = node.SelectNodes("//book/author[.='abdul kalam']");
            foreach(XmlNode nod in nodelist)
            {
                Console.WriteLine(nod.InnerText);
            }

        }
        protected static void create()
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age","20");
            xmlWriter.WriteString("abhinav");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "15");
            xmlWriter.WriteString("amal");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            Console.WriteLine("done creating");
            XmlDocument doc = new XmlDocument();
            doc.Load("test.xml");
            doc.Save(Console.Out);
        }        
    }
}
