using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace SaintSender
{
    public class User : ISerializable
    {
        private string username = string.Empty;
        private string password = string.Empty;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", username);
            info.AddValue("password", password);
        }
        public User(SerializationInfo info, StreamingContext context)
        {
            username = (string)info.GetValue("username", typeof(string));
            password = (string)info.GetValue("password", typeof(string));
        }
    }
}
