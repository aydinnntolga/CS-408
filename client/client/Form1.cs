using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        bool terminating = false;
        bool connected = false;
        Socket clientSocket;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // initialize socket
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // get fields
            string IP = textBoxIP.Text;
            string username = textBoxUsername.Text;

            if (IP == "" || username == "")
            { // invalid input
                logs.AppendText("Could not connect to the server !\n");
            }
            else
            { // check port field
                int portNum;
                if (Int32.TryParse(textBoxPort.Text, out portNum))
                {
                    try
                    {
                        clientSocket.Connect(IP, portNum);
                        // get usernames from server and check if username exists or not
                        connected = true;
                        logs.AppendText("Connected to the server!\n");
                    }
                    catch
                    {
                        // an error occured
                        logs.AppendText("Could not connect to the server!\n");
                    }
                }
                else
                {
                    // port field is not integer
                    logs.AppendText("Invalid port field!\n");
                }
            }
        }

        private void Receive()
        {
            // thread function to handle incoming messages from server
            while (connected)
            {
                try
                {
                    Byte[] buffer = new Byte[128];
                    clientSocket.Receive(buffer); // receive the byte array from server

                    string serverMessage = Encoding.Default.GetString(buffer);
                    serverMessage = serverMessage.Substring(0, serverMessage.IndexOf("\0"));

                    logs.AppendText("Server: " + serverMessage + "\n");
                }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("The server has disconnected!\n");
                    }

                    clientSocket.Close();
                    connected = false;
             
                }

            }
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }
    }
}
