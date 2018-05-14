using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise6
{
    [XmlRoot("car")]
    public class Car
    {
        [XmlIgnore]
        const string path = @"C:\Temp\User\CarXML.txt";
        [XmlElement]
        public string brand { get; set; }
        [XmlElement]
        public string model { get; set; }
        [XmlElement]
        public string manufacturingYear { get; set; }
        [XmlElement]
        public int mileage { get; set; }
        [XmlElement]
        public double price { get; set; }
        [XmlElement]
        public bool availability { get; set; }

        public static bool WriteCarDataXmlFormat(List<Car> cars)
        {
            XmlSerializer serializer = new XmlSerializer(cars.GetType());
            XmlWriter writer = XmlWriter.Create(path, new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Auto,
                Indent = true
            });
            serializer.Serialize(writer, cars);
            writer.Close();
            return true;
        }
        public static List<Car> GetAllCars()
        {
            using (var stream = System.IO.File.OpenRead(path))
            {
                var serializer = new XmlSerializer(typeof(List<Car>));
                List<Car> carList = new List<Car>();
                carList = (List<Car>)serializer.Deserialize(stream);
                stream.Close();
                return carList;
            }

        }
    }
}
