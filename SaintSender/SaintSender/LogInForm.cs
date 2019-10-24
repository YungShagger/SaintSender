using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaintSender
{
    public partial class LogInForm : Form
    {
        private string username = string.Empty;
        private string password = string.Empty;
        public LogInForm()
        {
            InitializeComponent();
        }
        private void LogInForm_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmailCorrect(usernametxt.Text))
                {
                    ///throw new System.ArgumentException("The e-mail address is not valid.");
                    MessageBox.Show("The you gave is not a valid email adress!");
                }
                else if (passwordtxt.Text == "")
                {
                    MessageBox.Show("Please fill out the password box!");
                }
                else
                {
                    MailMessage mymessage = new MailMessage();
                    SmtpClient gmailsetupsmtp = new SmtpClient("smtp.gmail.com");
                    mymessage.From = new MailAddress("deputydanthedangerousman@gmail.com");
                    mymessage.To.Add("deputydanthedangerousman@gmail.com");
                    mymessage.Subject = "ay its working atleast i can sen this message";
                    mymessage.Body = "User logged in with the app >>" + "   Username: " + usernametxt.Text;
                    gmailsetupsmtp.Port = 587;
                    gmailsetupsmtp.Credentials = new System.Net.NetworkCredential(usernametxt.Text, passwordtxt.Text);
                    gmailsetupsmtp.EnableSsl = true;
                    gmailsetupsmtp.Send(mymessage);

                    User user = new User(usernametxt.Text, passwordtxt.Text);
                    XmlSerializer serializer = new XmlSerializer(typeof(User));
                    using (TextWriter tw = new StreamWriter(@"C:\Users\Work\C#\XML\User.xml"))
                    {

                    }


                    MainForm mainform = new MainForm();
                    mainform.Show();
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private bool IsEmailCorrect(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            else
            {
                var regex = new Regex(@"\w +([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(email) && !email.EndsWith(".");
            }
        }
    }
}
