using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise6
{
    [XmlRoot("company")]
    public class Company
    {
        [XmlIgnore]
        const string path = @"C:\Temp\User\company.txt";
        [XmlElement]
        public string name { get; set; }
        [XmlElement]
        public string address { get; set; }
        [XmlElement]
        public string phoneNumber { get; set; }
        public Company()
        {

        }
        public static bool WriteCompanyDatatoXml(Company company)
        {
            XmlSerializer serializer = new XmlSerializer(company.GetType());
            XmlWriter xmlWriter = XmlWriter.Create(path, new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Auto,
                Indent = true
            });
            serializer.Serialize(xmlWriter, company);
            xmlWriter.Close();
            return true;
        }
        public static Company GetCompanyData()
        {
            using (var stream = System.IO.File.OpenRead(path))
            {
                var serializer = new XmlSerializer(typeof(Company));
                Company com = new Company();
                com = (Company)serializer.Deserialize(stream);
                stream.Close();
                return com;
            }
        }
    }
}
