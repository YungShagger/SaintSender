using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Xml.Serialization;
using Limilabs.Client.IMAP;
using Limilabs.Mail;

namespace SaintSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MailListView.View = View.Details;
            MailListView.GridLines = true;
            MailListView.FullRowSelect = true;

            MailListView.Columns.Add("Sender", 130);
            MailListView.Columns.Add("Date", 130);
            MailListView.Columns.Add("Subject", 100);
            MailListView.Columns.Add("Email", 800);

            User user = User.Load("User.xml");
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.UseBestLogin(user.username, user.password);
                imap.SelectInbox();
                List<long> uids = imap.Search(Flag.All);
                foreach (long uid in uids)
                {
                    var eml = imap.GetMessageByUID(uid);
                    IMail mail = new MailBuilder().CreateFromEml(eml);

                    string[] newMail = new string[5];
                    ListViewItem itm;
                    newMail[0] = mail.Sender.Name.ToString();
                    newMail[1] = mail.Date.ToString();
                    newMail[2] = mail.Subject.ToString();
                    newMail[3] = mail.Text.ToString();
                    newMail[4] = mail.Sender.Address.ToString();
                    itm = new ListViewItem(newMail);
                    MailListView.Items.Add(itm);
                    
                }
                imap.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewMailButton_Click(object sender, EventArgs e)
        {
            MailSenderForm mailSenderForm = new MailSenderForm();
            mailSenderForm.Show();
            this.Hide();
        }

        private void MailListView_Click(object sender, EventArgs e)
        {
            string senderName = null;
            string senderAdress = null;
            string dt = null;
            string sjbct = null;
            string ml = null;

            senderName = MailListView.SelectedItems[0].SubItems[0].Text;
            senderAdress = MailListView.SelectedItems[0].SubItems[4].Text;
            dt = MailListView.SelectedItems[0].SubItems[1].Text;
            sjbct = MailListView.SelectedItems[0].SubItems[2].Text;
            ml = MailListView.SelectedItems[0].SubItems[3].Text;

            Email email = new Email(senderName, senderAdress, dt, sjbct, ml);
            email.Save("Email.xml");

            EmailForm emailform = new EmailForm();
            emailform.Show();
            this.Hide();
        }
    }
}
