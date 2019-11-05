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
        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsEmailCorrect(usernametxt.Text))
                {
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
                    gmailsetupsmtp.Port = 587;
                    gmailsetupsmtp.Credentials = new System.Net.NetworkCredential(usernametxt.Text, passwordtxt.Text);
                    gmailsetupsmtp.EnableSsl = true;
                    User user = new User(usernametxt.Text, passwordtxt.Text);
                    user.username = usernametxt.Text;
                    user.password = passwordtxt.Text;
                    user.Save("User.xml");


                    user = null;


                    MainForm mainform = new MainForm();
                    this.Hide();
                    mainform.Show();
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
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                return regex.IsMatch(email) && !email.EndsWith(".");
            }
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignInButton.PerformClick();
            }
        }

        private void ExitButto_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
