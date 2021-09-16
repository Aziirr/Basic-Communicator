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
using System.IO;


namespace TCPClient
{
    public partial class TCPClient : Form
    {
        public string username = "";
        public StreamWriter Sw = null;
        public StreamReader Sr = null;
        public TcpClient socket = null;

        public TCPClient(String nick, TcpClient newSocket, StreamWriter newSw)
        {
            InitializeComponent();
            username = nick;
            Sw = newSw;
            socket = newSocket;

        }


        private bool activeCall = false;

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string msgRecived;
                while ((msgRecived = Sr.ReadLine()) != "END")
                {
                    messageList.Invoke(new MethodInvoker(delegate { messageList.DocumentText = messageList.DocumentText + DateTime.Now.ToShortTimeString() + msgRecived + "<hr>"; }));
                }
                socket.Close();
            }
            catch
            {
                activeCall = false;

            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                string msgSend = msg.Text;
                msg.Text = "";
                Sw.WriteLine(msgSend);
                Sw.Flush();
            }
            catch
            {
                lbCom.Invoke(new MethodInvoker(delegate { lbCom.Items.Add("Blad: Próba nawiązania połączenia zakończyła się niepowodzeniem"); }));
                activeCall = false;
            }
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Sr = new StreamReader(socket.GetStream());
                activeCall = true;
                bgw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                lbCom.Invoke(new MethodInvoker(delegate { lbCom.Items.Add("Blad: Próba nawiązania połączenia zakończyła się niepowodzeniem"); }));
                activeCall = false;
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg.Text += "<b></b>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msg.Text += "<i></i>";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            msg.Text += "<u></u>";
        }

        private void msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void msg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                send.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            };
        }

        private void messageList_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            messageList.Document.Window.ScrollTo(0, messageList.Document.Window.Size.Height);
        }


        private void nudPort_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TCPClient_Load(object sender, EventArgs e)
        {
            bwConnection.RunWorkerAsync();
        }

        private void messageList_ControlAdded(object sender, ControlEventArgs e)
        {
        }

     

        private void messageList_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (messageList.Document != null)
            {
                messageList.Invoke(new MethodInvoker(delegate { messageList.Document.Window.ScrollTo(0, messageList.Document.Body.ScrollRectangle.Height); }));
            }
        }

        private void lbCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            socket.Close();
            this.Hide();
            Form2 okienko = new Form2();
            okienko.Show();
        }

 
    }
}
