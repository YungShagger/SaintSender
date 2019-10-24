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
    public class User 
    {
        public string username;
        public string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User() {}

        public void Save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(User));
                serializer.Serialize(stream, this);
            }

        }
        public static User Load(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(User));
                return (User)deserializer.Deserialize(stream);
            }
        }

        
    }
}
