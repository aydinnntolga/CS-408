using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class Form1 : Form
    {
        // initialize socket
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> clientSockets = new List<Socket>();
        List<String> usernames = new List<String>();

        bool terminating = false;
        bool listening = false;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            int serverPort;
            if (Int32.TryParse(textBoxPort.Text, out serverPort))
            {
                // create and bind the endpoint so that clients connect
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(5);

                listening = true;
                buttonListen.Enabled = false;

                // connect the client socket
                Thread acceptThread = new Thread(Accept);
                acceptThread.Start();

                logs.AppendText("Started listening on port: " + serverPort + "\n");

            }
            else
            {
                logs.AppendText("Check the port number!\n");
            }
        }

        private void Accept()
        {
            while (listening)
            {
                try
                {                  
                    Socket newClient = serverSocket.Accept();                  
                    //clientSockets.Add(newClient);
                    logs.AppendText("A client is connected.\n");

                    // get messages from clients
                    Thread receiveThread = new Thread(() => Receive(newClient));
                    receiveThread.Start();

                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        logs.AppendText("Socket stopped working!\n");
                    }
                }

            }
        }

        private void Receive(Socket thisClient)
        {
            bool connected = true;
            while (connected && !terminating)
            {
                try
                {
                    Byte[] buffer = new Byte[128];
                    thisClient.Receive(buffer);

                    string clientMessage = Encoding.Default.GetString(buffer);
                    clientMessage = clientMessage.Substring(0, clientMessage.IndexOf("\0"));
                    // check the client message, if it starts with username check the username
                    logs.AppendText("Client: " + clientMessage + "\n");
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("A client has disconnected\n");            
                    }
                    thisClient.Close();
                    clientSockets.Remove(thisClient);
                    connected = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            listening = false;
            terminating = true;
            Environment.Exit(0);
        }
    }
}
