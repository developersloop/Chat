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

namespace ChatNew
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPar.Enabled = false;
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtServidor.Invoke((MethodInvoker)delegate ()
            {
                txtServidor.Text += e.MessageString;
            });
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            btnCon.Enabled = false;
            btnPar.Enabled = true;
            client.Connect(txtIP.Text, Int32.Parse(txtPorta.Text));
        }

        private void btnEnv_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtCliente.Text, TimeSpan.FromSeconds(3));
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            btnCon.Enabled = true;
            btnPar.Enabled = false;
            client.Disconnect();
        }
    }
}
