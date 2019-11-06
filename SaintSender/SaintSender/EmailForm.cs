using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
            Email email = Email.Load("Email.xml");
            Sendertxt.Text = email.senderName;
            Addresstxt.Text = email.senderAdress;
            Datetxt.Text = email.date;
            Subjecttxt.Text = email.subject;
            Bodytxt.Text = email.email;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
