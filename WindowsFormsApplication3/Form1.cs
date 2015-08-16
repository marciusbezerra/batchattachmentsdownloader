using OpaqueMail.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Instantiate a new IMAP connection to Gmail using TLS/SSL protection.
            ImapClient imapClient = new ImapClient("imap.gmail.com", 993, "username@gmail.com", "Pass@word1", true);
            imapClient.Connect();
            imapClient.Authenticate();

            // Retrieve up to 50 of the most recent messages from the "Inbox" mailbox.
            List<MailMessage> recentMessages = imapClient.GetMessages("Inbox", 50);

        }
    }
}
