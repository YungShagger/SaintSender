using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Xml.Serialization;

namespace SaintSender
{
    public partial class MailSenderForm : Form
    {
        public MailSenderForm()
        {
            InitializeComponent();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void FileAttacherButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.Load("User.xml");
                MailMessage mymessage = new MailMessage();
                SmtpClient gmailsetupsmtp = new SmtpClient("smtp.gmail.com");
                mymessage.From = new MailAddress(recipenttxt.Text);
                mymessage.To.Add(recipenttxt.Text);
                mymessage.Subject = subjecttxt.Text;
                mymessage.Body = bodytxt.Text;
                gmailsetupsmtp.Port = 587;
                gmailsetupsmtp.Credentials = new System.Net.NetworkCredential(user.username, user.password);
                gmailsetupsmtp.EnableSsl = true;
                gmailsetupsmtp.Send(mymessage);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
