using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerNew
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        SimpleTcpServer server; 

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPar.Enabled = false;
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtServer.Invoke((MethodInvoker) delegate()
            {
                txtServer.Text += e.MessageString;
                e.ReplyLine(string.Format("Resposta do servidor {0}", e.MessageString));
            });
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            txtServer.Text += "Iniciando servidor...";
            var ip = System.Net.IPAddress.Parse(txtIP.Text);
            server.Start(Convert.ToInt32(txtPor.Text));

            if (server.IsStarted)
            {
                txtServer.Text += "Servidor conectado";
                btnCon.Enabled = false;
                btnPar.Enabled = true;
            }
            else
            {
                txtServer.Text += "Servidor não conectado";
            }
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
                btnCon.Enabled = true;
                btnPar.Enabled = false;
            }
        }
    }
}
