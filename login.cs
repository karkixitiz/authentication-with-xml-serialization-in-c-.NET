using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise6
{
    [XmlRoot("login")]
    public class login
    {
        [XmlIgnore]
        const string path = @"C:\Temp\User\login.txt";
        [XmlElement("id")]
        public  int userId { get; set; }
        [XmlElement]
        public string name { get; set; }
        [XmlElement]
        public string password { get; set; }

        public login()
        {

        }
        public login(int id,string name,string password)
        {
            this.userId = id;
            this.name = name;
            this.password = password;
        }

        public static void WriteLoginDatatoXml(login login)
        {
            XmlSerializer serializer = new XmlSerializer(login.GetType());
            XmlWriter xmlWriter = XmlWriter.Create(path, new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                ConformanceLevel = ConformanceLevel.Auto,
                Indent = true
            });
            serializer.Serialize(xmlWriter, login);
            xmlWriter.Close();
        }
        public static login GetLoginDate()
        {
            using (var stream = System.IO.File.OpenRead(path))
            {
                var serializer = new XmlSerializer(typeof(login));
               login user = new login();
                user = (login)serializer.Deserialize(stream);
                stream.Close();
                return user;
            }
        }
        public  static bool authenticateUser(login user)
        {
            var data = GetLoginDate();
            if(data.name==user.name && data.password==user.password)
            {
                return true;
            }
            return false;
        }
    }
}
