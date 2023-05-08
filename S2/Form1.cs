using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace S2
{
    public partial class Form1 : Form
    {


        private TcpClient Client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string textToSend;
        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIPtextBox.Text = address.ToString();
                }
            }

        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(serverPORTtextBox.Text));
            listener.Start();
            Client = listener.AcceptTcpClient();
            STR = new StreamReader(Client.GetStream());
            STW = new StreamWriter(Client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }
        private void Connectbutton_Click(object sender, EventArgs e)
        {
            Client = new TcpClient();
            IPEndPoint iP_End = new IPEndPoint(IPAddress.Parse(clientIPtextBox.Text), int.Parse(clientPORTtextBox.Text));

            try
            {
                Client.Connect(iP_End);
                if (Client.Connected)
                {
                    chatScreentextBox.AppendText("connected to server" + Environment.NewLine);
                    STW = new StreamWriter(Client.GetStream());
                    STR = new StreamReader(Client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            if (Massegebox.Text != "")
            {
                textToSend = Massegebox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            Massegebox.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.chatScreentextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        chatScreentextBox.AppendText("Client : " + recieve + Environment.NewLine);
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Client.Connected)
            {
                STW.WriteLine(textToSend);
                this.chatScreentextBox.Invoke(new MethodInvoker(delegate ()
                {
                    chatScreentextBox.AppendText("Server : " + textToSend + Environment.NewLine);
                }));


            }
            else
            {
                MessageBox.Show("Sending Failed");
            }
            backgroundWorker2.CancelAsync();
        }
    }
}