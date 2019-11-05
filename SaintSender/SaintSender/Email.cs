using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SaintSender
{
    [Serializable]
    public class Email
    {
        public string senderName;
        public string senderAdress;
        public string date;
        public string subject;
        public string email;

        public Email(string senderName, string senderAdress, string date,string subject, string email)
        {
            this.senderName = senderName;
            this.senderAdress = senderAdress;
            this.date = date;
            this.subject = subject;
            this.email = email;
        }

        public Email() { }

        public void Save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Email));
                serializer.Serialize(stream, this);
            }
        }
        public static Email Load(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Email));
                return (Email)deserializer.Deserialize(stream);
            }
        }
    }
}
