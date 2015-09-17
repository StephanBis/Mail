using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    public class Account
    {
        private string name, username, password, host;
        private bool ssl;
        private int port;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public bool Ssl
        {
            get { return ssl; }
            set { ssl = value; }
        }

        public Account(string name, string username, string password, string host, int port, bool ssl)
        {
            this.Name = name;
            this.Host = host;
            this.Port = port;
            this.Ssl = ssl;
            this.Username = username;
            this.Password = password;
        }

        public void Save()
        {

        }
    }
}
