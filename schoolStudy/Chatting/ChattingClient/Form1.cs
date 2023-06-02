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

namespace ChattingClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket client;
        Thread clientThread;
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(
                                            IPAddress.Parse(this.ipTxt.Text),
                                            Int32.Parse(this.portTxt.Text)
                                           );
                client = new Socket(AddressFamily.InterNetwork,
                                    SocketType.Stream, ProtocolType.Tcp);
                client.Connect(endPoint);
                eventLB.Items.Add("서버 연결");
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                return;
            }

            clientThread = new Thread(
                delegate()
                {
                    isThreadRunning = true;
                    try
                    {
                        while(isThreadRunning)
                        {
                            Byte []binary = new Byte[1024];
                            int n = client.Receive(binary);
                            string msg = Encoding.ASCII.GetString(binary, 0, n).Trim();
                            eventLB.Items.Add(msg);
                            eventTxt.Text = msg + "\r\n" + eventTxt.Text;
                            Console.WriteLine(msg);
                            Thread.Sleep(1);
                        }
                    }
                    catch (Exception ee) 
                    {
                        eventLB.Items.Add(ee.Message);
                        eventTxt.Text = ee.Message + "\r\n" + eventTxt.Text;
                        Console.WriteLine(ee.Message);
                    }
                }
            );
            clientThread.Start();
        }

        Boolean isThreadRunning = false;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            isThreadRunning = false;
            clientThread.Interrupt();
            try
            {
                client.Close();
            }
            catch (Exception)
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                client.Close();
            }
            catch (Exception)
            {

            }
            try
            {
                clientThread.Interrupt();  
            }
            catch (Exception)
            {

            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client.Send(Encoding.ASCII.GetBytes(this.messageTxt.Text + "\r\n"));
            }
            catch (Exception)
            {

                
            }
        }
    }
}
