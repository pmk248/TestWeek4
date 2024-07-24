using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestWeek4.Model;

namespace TestWeek4.Services
{
    internal class XMLService
    {
        private List<Dates> LDates = [];
        private string xmlPath = string.Empty;
        private XDocument xDoc;
        private XElement root;
        public XMLService()
        {
            xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\data.xml");
            xDoc = XDocument.Load(xmlPath);
            root = xDoc.Root;
            LDates = GetAll();
        }

        public List<Dates> GetAll()
        {
            List<Dates> temp = [];
            foreach (XElement item in root.Elements())
            {
                temp.Add(new Dates(item.Element("DayOfWeek").Value, item.Element("DayOfMonth").Value, item.Element("Month").Value, item.Element("Year").Value, item.Element("Result").Value));
            }
            return temp;
        }
        public SaveDate()
        {

        }
    }
}
