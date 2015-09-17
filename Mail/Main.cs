using Email.Net.Imap;
using Email.Net.Imap.Collections;
using Email.Net.Imap.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail
{
    public partial class Main : Form
    {
        private string db = Application.StartupPath + "/db";
        private List<Account> accounts = new List<Account>();
        private List<iTalk.iTalk_TabControl> tabs = new List<iTalk.iTalk_TabControl>();

        public Main()
        {
            InitializeComponent();
            
            if (Directory.Exists(db))
            {
                int index = 0;

                if (Directory.GetFiles(db).Length > 0)
                {
                    foreach(string file in Directory.GetFiles(db))
                    {
                        StreamReader reader = new StreamReader(file);
                
                        string[] line = reader.ReadLine().Split(';');

                        Account account = new Account(line[0], line[1], line[2], line[3], Convert.ToInt32(line[4]), Convert.ToBoolean(line[5]));
                        accounts.Add(account);

                        iTalk.iTalk_TabControl tab = new iTalk.iTalk_TabControl();
                        tab.Dock = DockStyle.Fill;
                        tab.SelectedIndexChanged += tab_SelectedIndexChanged;
                        tabs.Add(tab);

                        iTalk_TabControl.TabPages.Add(account.Name);
                        iTalk_TabControl.TabPages[index].Controls.Add(tab);
                        
                        index++;
                    }

                    GetFolders();
                }
            }
            else
            {
                Directory.CreateDirectory(db);
            }  
        }

        private void iTalk_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFolders();
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetMessages();
        }

        private void GetMessages()
        {
            Mailbox folders = _client.GetMailboxTree();

            iTalk.iTalk_TabControl tab = tabs[iTalk_TabControl.SelectedIndex];
            tab.TabPages[tab.SelectedIndex].Controls.Clear();

            iTalk.iTalk_ProgressIndicator prog = new iTalk.iTalk_ProgressIndicator();
            tab.TabPages[tab.SelectedIndex].Controls.Add(prog);

            Mailbox box = Mailbox.Find(folders, tab.TabPages[tab.SelectedIndex].Text.Substring(0, tab.TabPages[tab.SelectedIndex].Text.IndexOf("-") - 1));

            _client.BeginGetAllMessageHeaders(box, callback);
        }

        private void callback(IAsyncResult ar)
        {
            //This is method, which will be called after receiving
            MessageCollection tmp = _client.EndGetAllMessageHeaders(ar);
            
            ListView test = new ListView();
            test.Dock = DockStyle.Fill;

            for (int i = 0; i < tmp.Count; i++)
            {
                string a = decodeCollection(tmp[i].Flags);
                MethodInvoker invoker = delegate
                {
                    ListViewItem item = new ListViewItem(String.Format("{0}.{1} *** flags: {2}", tmp[i].UID, tmp[i].Header.Subject, a));
                    test.Items.Add(item);
                };
                Invoke(invoker);
            }

            MethodInvoker invoker2 = delegate
            {
                iTalk.iTalk_TabControl tab = tabs[iTalk_TabControl.SelectedIndex];
                tab.TabPages[tab.SelectedIndex].Controls.Clear();
                tab.TabPages[tab.SelectedIndex].Controls.Add(test);
            };
            Invoke(invoker2);
        }

        private string decodeCollection(MessageFlagCollection a)
        {
            string b = "";
            for (int i = 0; i < a.Count; i++)
            {
                b += a[i].ToString();
                b += "; ";
            }
            return b;
        }

        private void GetFolders()
        {
            this.Cursor = Cursors.WaitCursor;           

            Account account = accounts[iTalk_TabControl.SelectedIndex];

            try
            {
                _client.Logout();
                Console.WriteLine("Logout succeeded!");
            }
            catch
            {
                Console.WriteLine("Logout failed!");
            }

            _client = new ImapClient();

            //Create POP3 client with parameters needed
            //URL of host to connect to
            _client.Host = account.Host;
            //TCP port for connection
            _client.Port = (ushort)account.Port;
            //Username to login to the POP3 server
            _client.Username = account.Username;
            //Password to login to the POP3 server
            _client.Password = account.Password;

            _client.SSLInteractionType = Email.Net.Common.Configurations.EInteractionType.SSLPort;

            try
            {
                //Login to the server
                CompletionResponse response = _client.Login();
                if (response.CompletionResult != ECompletionResponseType.OK)
                {
                    MessageBox.Show("Error", String.Format("Connection error:\n {0}", response.Message), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Get all messages to know the uid
                    Mailbox folders = _client.GetMailboxTree();

                    iTalk.iTalk_TabControl tab = tabs[iTalk_TabControl.SelectedIndex];
                    tab.TabPages.Clear();

                    for (int i = 0; i <= folders.Children.Count - 1; i++)
                    {
                        tab.TabPages.Add(folders.Children[i].DisplayName + " - " + _client.GetMessageCount(folders.Children[i]));
                    }

                    GetMessages();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            this.Cursor = Cursors.Default;
        }
    }
}
