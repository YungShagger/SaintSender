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
using SaintSender;
using System.IO;
using System.IO.Compression;

namespace SaintSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SmtpClient gmailsetupsmtp = new SmtpClient("smtp.gmail.com");
            gmailsetupsmtp.Port = 993;
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewMailButton_Click(object sender, EventArgs e)
        {
            MailSenderForm mailSenderForm = new MailSenderForm();
            mailSenderForm.Show();
        }
    }
}
