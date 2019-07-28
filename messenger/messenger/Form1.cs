using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace messenger
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public Form1()
        {
            InitializeComponent();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);

                 if (size > 0) { // used to help us on getting the data
                byte[] receivedData = new byte[1464];

                // getting the message data
                receivedData = (byte[])aResult.AsyncState;

                // converts message data byte array to string
                ASCIIEncoding eEncoding = new ASCIIEncoding();
                string receivedMessage = eEncoding.GetString(receivedData);

                // adding Message to the listbox
                listMessage.Items.Add("Friend: " + receivedMessage);
            }

    // starts to listen the socket again
           byte[] buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }
catch (Exception exp)
{
    MessageBox.Show(exp.ToString());
}


}

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { // converts from string to byte[]
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                // sending the message
                sck.Send(msg);

                // add to listbox
                listMessage.Items.Add("You: " + textMessage.Text);

                // clear txtMessage
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            { // binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                // connect to remote IP and port
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);

                // starts to listen to an specific port
               byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                AsyncCallback(MessageCallBack), buffer);

                // release button to send message
                buttonSend.Enabled = true;
                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                buttonSend.Enabled = true;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicTacToeWin32.Form1 bb = new TicTacToeWin32.Form1();
            bb.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Screen_capture.Form1 cc = new Screen_capture.Form1();
            cc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Speech_rec.Form1 dd = new Speech_rec.Form1();
            dd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get own IP
            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
            


    }

        private void button4_Click(object sender, EventArgs e)
        {
           PDF_Reader.Form1 pdf = new PDF_Reader.Form1();
           pdf.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            VoiceRecognization.Form1 vc = new VoiceRecognization.Form1();
            vc.Show();
        }
}
}
