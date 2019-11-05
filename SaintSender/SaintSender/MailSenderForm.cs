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
using System.Net;
using System.IO;
using System.Xml.Serialization;


namespace SaintSender
{
    public partial class MailSenderForm : Form
    {
        OpenFileDialog attachment;
        String filename = "";
        public MailSenderForm()
        {
            InitializeComponent();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void FileAttacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                attachment = new OpenFileDialog();
                attachment.Filter = "Images(.jpg, .png)|*.pgm;*.jpg;|Pdf files|*.pdf";
                if (attachment.ShowDialog() == DialogResult.OK)
                {
                    filename = attachment.FileName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.Load("User.xml");
                MailMessage mymessage = new MailMessage();
                SmtpClient gmailsetupsmtp = new SmtpClient("smtp.gmail.com");
                gmailsetupsmtp.Port = 587;
                gmailsetupsmtp.EnableSsl = true;
                gmailsetupsmtp.UseDefaultCredentials = false;
                gmailsetupsmtp.Credentials = new System.Net.NetworkCredential(user.username, user.password);

                mymessage.From = new MailAddress(recipenttxt.Text);
                mymessage.To.Add(recipenttxt.Text);
                mymessage.Subject = subjecttxt.Text;
                mymessage.IsBodyHtml = HtmlBodyCb.Checked;
                mymessage.Body = bodytxt.Text;

                if (filename.Length > 0)
                {
                    Attachment attachment = new Attachment(filename);
                    mymessage.Attachments.Add(attachment);
                }


                gmailsetupsmtp.Send(mymessage);
                filename = "";
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
                MessageBox.Show("Email Sent!");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
