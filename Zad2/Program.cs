using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("InterestRates/InterestRate");
            doc.CreateElement("Description");
            int step = 0;
            foreach (XmlNode node in nodes) {
                if (step == 0)
                {
                    string code = node["Code"].InnerText;
                    node["Description"].InnerText = code;
                    step = 1;
                }
                else {
                    step = 0;
                }  
            }

            doc.Save(Console.Out);
            Console.Read();

        }
    }
}
