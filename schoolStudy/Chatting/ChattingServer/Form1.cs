using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattingServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket server;
        Thread serverThread;
        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(
                                            IPAddress.Parse("127.0.0.1"),
                                            Int32.Parse(this.portTxt.Text)
                                           );
                server = new Socket(AddressFamily.InterNetwork,
                                    SocketType.Stream, ProtocolType.Tcp);
                server.Bind(endPoint);
                server.Listen(1000);
            }
            catch (Exception ee)
            {
                eventLB.Items.Add(ee.Message);
                eventTxt.Text = ee.Message + "\r\n" + eventTxt.Text;
                Console.WriteLine(ee.Message);
                return;
            }
            this.startBtn.Enabled = false;
            isServerRunning = true;
            serverThread = new Thread(
                delegate ()
                {
                    serverRun();
                }

                
                );
            serverThread.Start();
        }

        List<Socket>clientLst = new List<Socket>();
        public void serverRun ()
        {
            while (isServerRunning)
            {
                try
                {
                    Socket client = server.Accept();
                    clientLst.Add(client);
                    if (client != null)
                    {
                        string msg = "Welcome aboard";
                        string packet;
                        packet = String.Format
                            ("{0}:who:all:{1}\r\n", "unknown",msg);
                        client.Send(Encoding.ASCII.GetBytes(packet));
                        eventTxt.Text = "Welcome aboard!" + "\r\n" + eventTxt.Text;

                        new Thread(
                            delegate ()
                            {
                                while(true)
                                {
                                    Byte[] binary = new Byte[1024];
                                    int n = client.Receive(binary);
                                    string message = Encoding.ASCII.GetString(binary, 0, n).Trim();
                                    eventLB.Items.Add(msg);
                                    eventTxt.Text = message + "\r\n" + eventTxt.Text;
                                    Console.WriteLine(message);
                                    foreach (Socket obj in clientLst)
                                        obj.Send(Encoding.ASCII.GetBytes(message + "\r\n"));
                                    Thread.Sleep(1);
                                }
                            }
                        ).Start();
                    }
                    Thread.Sleep(1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    eventLB.Items.Add(ex.Message);
                    eventTxt.Text = ex.Message + "\n" + eventTxt.Text;
                    break;
                }
            }
            startBtn.Enabled = true;
        }
        Boolean isServerRunning = false;
        private void stopBtn_Click(object sender, EventArgs e)
        {
            isServerRunning = false;
            serverThread.Interrupt();
            try
            {
                server.Close();
            }
            catch (Exception)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                serverThread.Interrupt();
            }
            catch (Exception)
            {

            }
        }
    }
}
