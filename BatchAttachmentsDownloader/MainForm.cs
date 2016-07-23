using System.Globalization;
using System;
using System.Linq;
using System.Windows.Forms;
using OpaqueMail;

namespace WindowsFormsApplication3
{
    public partial class MainForm : Form
    {
        private ImapClient imapClient;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;
            tsslStatus.Text = @"Fazendo login...";
            try
            {
                imapClient = new ImapClient("imap-mail.outlook.com", 993, UserNameTextBox.Text, PasswordTextBox.Text,
                    true);
                imapClient.Connect();
                imapClient.Authenticate();
                FoldersComboBox.DataSource = imapClient.ListMailboxNames(true);
                FoldersComboBox.Enabled = true;
                FoldersComboBox.Focus();
                ListAttachmentsButton.Enabled = true;


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                tsslStatus.Text = @"Erro: " + exception.Message;
            }
            finally
            {
                LoginButton.Enabled = true;
                tsslStatus.Text = @"Pronto. Selecione uma pasta, para listar mensagens";
            }

        }

        private async void ListAttachmentsButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ListAttachmentsButton.Enabled = false;
            try
            {
                var count = await imapClient.GetMessageCountAsync(FoldersComboBox.Text);

                tspbProgress.Value = 0;
                tspbProgress.Minimum = 0;
                tspbProgress.Maximum = count;

                tsslStatus.Text = @"Aguarde, verificando mensagens...";

                var mailboxFolder = FoldersComboBox.Text;

                for (var i = 0; i < count; i++)
                {
                    var messages =
                        await imapClient.GetMessagesAsync(mailboxFolder, 3,
                            (i * 3) + 1, false, false, false);
                    foreach (var message in messages)
                    {
                        tspbProgress.Value = i;
                        tsslStatus.Text = @"Verificando: " + message.Subject;
                        var item = new ListViewItem(String.Format("{0} [{1}]",
                            message.From.DisplayName,
                            message.From.Address)
                            .Trim()) { Checked = message.Attachments.Any() };
                        if (message.Attachments.Any())
                            DownloadAttachmentsButton.Enabled = true;
                        item.SubItems.Add(message.Subject);
                        item.SubItems.Add(message.Date.ToShortDateString());
                        item.SubItems.Add(message.Attachments.Count.ToString(CultureInfo.InvariantCulture));
                        AttachmentsListView.Items.Add(item);
                        tsslStatus.Text =
                            $"{AttachmentsListView.Items.Count} mensagem(ns), {AttachmentsListView.CheckedItems.Count} com anexo";
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                tsslStatus.Text = @"Erro: " + exception.Message;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                ListAttachmentsButton.Enabled = true;
            }
        }

        private void DownloadAttachmentsButton_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
